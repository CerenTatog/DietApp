using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto;
using Diet.Model.Dto.Report;

namespace Diet.BLL
{
    public class ReportManager
    {
        UnitOfWork db = new UnitOfWork();
        //Repository<Food> foodRepo = new Repository<Food>();
        //Repository<Meal> mealRepo = new Repository<Meal>();
        //Repository<MealFood> meailFoodRepo = new Repository<MealFood>();
        //Repository<User> userRepo = new Repository<User>();
        //Repository<UserDetail> userDetailRepo = new Repository<UserDetail>();
        //Repository<Activity> activityRepo = new Repository<Activity>();
        //Repository<UserActivity> userActivityRepo = new Repository<UserActivity>();
        public List<WeeklyCaloriDto> CalculateWeeklyCalorie(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateSevenDayBefore && x.MealDate < dateToday && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Calorie,
                             mf.Quantity,
                             m.MealDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate.Date
                              group gq by dt into g
                              select new WeeklyCaloriDto
                              {
                                  Date = g.Key,
                                  Calori = g.Sum(x => x.Calorie * x.Quantity)
                              }).ToList();

            return groupQuery;
        }

        public List<DailyUserProtein> CalculateProtein(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateSevenDayBefore && x.MealDate < dateToday && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Protein,
                             mf.Quantity,
                             m.MealDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate.Date
                              group gq by dt into g
                              select new DailyUserProtein
                              {
                                  Date = g.Key,
                                  Protein = g.Sum(x => x.Protein * x.Quantity)
                              }).ToList();
            return groupQuery;

        }

        public List<WeeklyFatDbo> CalculateFat(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateSevenDayBefore && x.MealDate < dateToday && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Fat,
                             mf.Quantity,
                             m.MealDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate.Date
                              group gq by dt into g
                              select new WeeklyFatDbo
                              {
                                  Date = g.Key,
                                  Fat = g.Sum(x => x.Fat * x.Quantity)
                              }).ToList();
            return groupQuery;

        }

        //haftalık su tüketimi Veri tabanında su tutmuyoruz bakılacak KİLO*0.003 İLE HESAPLANIYOR
        //public List<WeeklyWaterDto> CalculateWater(int UserId)
        //{
        //    var dateToday = DateTime.Now;
        //    var dateSevenDayBefore = DateTime.Today.AddDays(-7);
        //}

        //haftalık aktivite kayıtları
        public List<WeeklyActivityDto> CalculateActivity(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyActivityRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateSevenDayBefore && x.ActivityTime < dateToday && x.UserID == UserId);
            var query = (from ua in userDailyActivityRepo
                         join a in db.ActivityRepository.GetAll() on ua.ActivityID equals a.ID                 
                         select new
                         {
                             a.LostCalorie,
                             ua.Duration,
                             ua.ActivityTime
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.ActivityTime.Date
                              group gq by dt into g
                              select new WeeklyActivityDto
                              {
                                  Date = g.Key,
                                  Activity = g.Sum(x => x.LostCalorie * x.Duration)
                              }).ToList();
            return groupQuery;
        }

        //haftalık adım sayısı Veri tabanında Adım sayısı tutulmuyor.
        //public List<WeeklyStepDto> CalculateStep(int UserId)
        //{
        //    var dateToday = DateTime.Now;
        //    var dateSevenDayBefore = DateTime.Today.AddDays(-7);
        //    var userDailyStepRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateSevenDayBefore && x.ActivityTime < dateToday && x.UserID == UserId);
        //}

        //kilo takibi
        public List<WeeklyWeightDto> CalculateWeight(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyWeigthRepo = db.UserDetailRepository.GetAll().Where(x => x.CreatedDate >= dateSevenDayBefore && x.CreatedDate < dateToday && x.UserID == UserId);
            var query = (from ud in userDailyWeigthRepo
                         //join u in db.UserRepository.GetAll() on ud.UserID equals u.ID
                         //join ub in db.UserBcRepository.GetAll() on u.ID equals ub.UserID
                         select new 
                         {
                            ud.Weight,
                            ud.CreatedDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.CreatedDate?.Date
                              group gq by dt into g
                              select new WeeklyWeightDto
                              {
                                  Date = (DateTime)g.Key,//Nullubeal hatası bir bakalım
                                  Weight = g.Sum(x => x.Weight)
                              }).ToList();
            return groupQuery;
        }
    }
}
