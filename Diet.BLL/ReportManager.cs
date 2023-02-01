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

        public static double CalculateProtein()
        {
            return 0;

        }

        public static double CalculateFat()
        {
            return 0;

        }

        //haftalık su tüketimi

        //haftalık aktivite kayıtları

        //haftalık adım sayısı

        //kilo takibi
    }
}
