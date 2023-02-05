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
using Diet.Model.Dto.Report;
using System.Web.UI.Design.WebControls;

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
                             f.PortionQuantity,
                             mf.Quantity,
                             m.MealType
                         }).ToList();
            var groupQuery = (from gq in query
                              group gq by gq.MealType into g
                              select new DailyUserCalori
                              {
                                  MealType = g.Key,
                                  TotalCalori = g.Sum(x => (x.Quantity / x.PortionQuantity) * x.Calorie)
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
        //weekly carbonhyrate alanı düzenlenecek hesaplamada sıkıntı var.
        public double DailyTakenCarbonhyrate(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateToday && x.MealDate < dateEnd && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Carbonhydrate,
                             f.PortionQuantity,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate
                              group gq by dt into g
                              select new
                              {
                                  Date = g.Key,
                                  Carbonhyrate = g.Sum(x => x.Carbonhydrate * (x.Quantity / x.PortionQuantity))
                              }).ToList();

            return groupQuery.Sum(x => x.Carbonhyrate);


        }

        public double DailyTakenProtein(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateToday && x.MealDate < dateEnd && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Protein,
                             f.PortionQuantity,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate
                              group gq by dt into g
                              select new
                              {
                                  Date = g.Key,
                                  Protein = g.Sum(x => x.Protein * (x.Quantity / x.PortionQuantity))
                              }).ToList();

            return groupQuery.Sum(x => x.Protein);

        }

        public double DailyTakenFat(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateToday && x.MealDate < dateEnd && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Fat,
                             mf.Quantity,
                             f.PortionQuantity,
                             m.MealDate,
                             m.MealType
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate
                              group gq by dt into g
                              select new
                              {
                                  Date = g.Key,
                                  Fat = g.Sum(x => x.Fat * (x.Quantity / x.PortionQuantity))
                              }).ToList();

            return groupQuery.Sum(x => x.Fat);
        }
        public double DailyDrinkingWater(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyWater = db.UserWaterRepository.GetAll().Where(x => x.DrinkTime >= dateEnd && x.DrinkTime < dateToday && x.UserID == UserId);
            var groupQuery = (from gq in userDailyWater
                              let dt = gq.DrinkTime
                              group gq by dt into g
                              select new
                              {
                                  Date = g.Key,
                                  TotalMl = g.Sum(x => x.Quantity)
                              }).ToList();
            return groupQuery.Sum(x => x.TotalMl);

        }

        public List<MostEatenFoods> OtherUserMostEatenFood(int UserId, MealType mealType)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID != UserId && x.MealType == mealType);
            var query = (from mf in db.MealFoodRepository.GetAll()
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         join um in userMeal on mf.MealID equals um.ID
                         select new
                         {
                             f.FoodName,
                             c.CategoryName,
                             f.PortionQuantity,
                             mf.Quantity
                         });
            var groupQuery = (from gq in query
                              group gq by new { gq.FoodName, gq.CategoryName } into g
                              select new MostEatenFoods
                              {
                                  FoodName = g.Key.FoodName,
                                  CategoryName = g.Key.CategoryName,
                                  TotalQuantity = g.Sum(x => x.Quantity / x.PortionQuantity)
                              }).OrderByDescending(x => x.TotalQuantity).Take(10).ToList();

            return groupQuery.ToList();
        }

        public List<UserDailyMeaListByMealTypeDto> GetUserDailyMeaListByMealType(int UserId, MealType mealType)
        {
            List<UserDailyMeaListByMealTypeDto> mealList = new List<UserDailyMeaListByMealTypeDto>();

            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateToday && x.MealDate < dateEnd && x.UserID == UserId && x.MealType == mealType);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f,
                             mf
                         }).ToList();
            var groupQuery = (from gq in query
                              group gq by gq.f.FoodName into g
                              select new
                              {
                                  FoodName = g.Key,
                                  UserDailyMeaList = g.Select(x => new UserDailyMeaListByMealTypeDto
                                  {
                                      Food = x.f,
                                      MealFood = x.mf
                                  })
                              }).ToList();

            foreach (var item in groupQuery)
            {
                mealList.AddRange(item.UserDailyMeaList);
            }

            return mealList;
        }
    }
}
