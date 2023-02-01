using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Model;
using Diet.DAL;
using Diet.DAL.Entities;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;
using Diet.DAL.GenericRepository;
using Diet.Model.Dto;

namespace Diet.BLL
{
    public class FoodManager
    {
        //DietAppContext db = new DietAppContext();
        UnitOfWork db = new UnitOfWork();
        //Repository<Food> foodRepo = new Repository<Food>();
        //Repository<Meal> mealRepo = new Repository<Meal>();
        //Repository<MealFood> meailFoodRepo = new Repository<MealFood>();
        //Repository<User> userRepo = new Repository<User>();
        //Repository<UserDetail> userDetailRepo = new Repository<UserDetail>();
        //Repository<Activity> activityRepo = new Repository<Activity>();
        //Repository<UserActivity> userActivityRepo = new Repository<UserActivity>();

        public double CalculateDailyCalorie(int UserId)
        {//Kişinin ilk etapta girdiği yaş,cinsiyet, harreket durumu vs.ye göre hesaplanacak değer.
         //kişinin kilo vermesine değişebilir. 
         //Men: BMR = 88.362 + (13.397 x weight in kg) +(4.799 x height in cm) – (5.677 x age in years) Women: BMR = 447.593 + (9.247 x weight in kg) +(3.098 x height in cm) – (4.330 x age in years)
         //Hareketsiz sedanter yaşama sahip kişilerde aktivite katsayısı 1,2’dir.
         //Haftada 1 - 2 kez spor yapan hafif aktif kişilerde 1,375;
         //haftada 3 - 5 kez spor yapanlarda 1,55;
         //haftada 6 - 7 gün spor yapan çok aktif kişilerde 1,725; her gün spor yapan ya da beden işçilerinde ise aktivite katsayısı 1,9’dur.
         //Kilo vermek istiyorsa 
         //Mifflin-St. Jeor
         //BMH(Erkek) = 10 X Ağırlık(kg) +6,25 X Yükseklik(cm) – 5 X yaş(y) +5
         //BMH(Kadın) = 10 X Ağırlık(kg) +6,25 X Yükseklik(cm) – 5 X yaş(y) – 161

            var userDetail = db.UserDetailRepository.GetAll().Where(x => x.UserID == UserId).FirstOrDefault();

            if (userDetail?.Gender == Gender.Men)
            {
                double katSayi = userDetail.ActivityStatus == ActivityStatus.NonActive ? 1.2 : userDetail.ActivityStatus == ActivityStatus.MidActive ? 1.375 : userDetail.ActivityStatus == ActivityStatus.Active ? 1.725 : 1.9;
                return (88.362 + (13.397 * userDetail.Weight) + (4.799 * userDetail.Height) - (5.677 * userDetail.Age)) * katSayi;
            }
            else if (userDetail?.Gender == Gender.Women)
            {
                double katSayi = userDetail.ActivityStatus == ActivityStatus.NonActive ? 1.2 : userDetail.ActivityStatus == ActivityStatus.MidActive ? 1.375 : userDetail.ActivityStatus == ActivityStatus.Active ? 1.725 : 1.9;
                return (447.593 + (9.247 * userDetail.Weight) + (3.098 * userDetail.Height) - (4.330 * userDetail.Age));
            }
            return 0;
        }

        public List<DailyUserCalori> CalculateCalorieIntake(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateToday && x.MealDate < dateEnd && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Calorie,
                             mf.Quantity,
                             m.MealType
                         }).ToList();
            var groupQuery = (from gq in query
                              group gq by gq.MealType into g
                              select new DailyUserCalori
                              {
                                  MealType = g.Key,
                                  TotalCalori = g.Sum(x => x.Quantity * x.Calorie)
                              }).ToList();

            return groupQuery;
        }

        public double CalculateTotalCalorie(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);

            double dailyMealCalori = CalculateCalorieIntake(UserId).Sum(x => x.TotalCalori);
            var dailyUserActivityRepo = db.UserActivityRepository.GetAll().Where(x => x.UserID == UserId && x.ActivityTime >= dateToday && x.ActivityTime < dateEnd);
            var dailyActivityCalori = (from userActivity in dailyUserActivityRepo
                                       join activity in db.ActivityRepository.GetAll() on userActivity.ActivityID equals activity.ID
                                       select new
                                       {
                                           userActivity.ID,
                                           activity.LostCalorie,
                                           userActivity.Duration
                                       });
            var groupQuery = (from da in dailyActivityCalori
                              group da by da.ID into g
                              select new
                              {
                                  Id = g.Key,
                                  TotalLostCalori = g.Sum(x => x.LostCalorie * x.Duration)
                              }).ToList();
            double totalLostCalori = groupQuery.Sum(x => x.TotalLostCalori);

            return dailyMealCalori - totalLostCalori;
        }

        public double DailyWaterNeeded(int UserId)
        {
            var userDetail = db.UserDetailRepository.GetAll().Where(x => x.UserID == UserId).FirstOrDefault();
            if (userDetail != null)
            {
                return userDetail.Weight * 0.033;
            }
            return 0;
        }
    }
}
