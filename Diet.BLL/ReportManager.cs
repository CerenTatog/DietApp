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

        public List<WeeklyCarbonHydrateDo> CalculateCarb(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateSevenDayBefore && x.MealDate < dateToday && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Carbonhydrate,
                             mf.Quantity,
                             m.MealDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate.Date
                              group gq by dt into g
                              select new WeeklyCarbonHydrateDo
                              {
                                  Date = g.Key,
                                  Carb = g.Sum(x => x.Carbonhydrate * x.Quantity)
                              }).ToList();
            return groupQuery;

        }
        public List<WeeklyMacros> WeeklyMacroFood(int UserId) 
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyMealRepo = db.MealRepository.GetAll().Where(x => x.MealDate >= dateSevenDayBefore && x.MealDate < dateToday && x.UserID == UserId);
            var query = (from m in userDailyMealRepo
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         select new
                         {
                             f.Carbonhydrate,
                             f.Fat,
                             f.Protein,
                             mf.Quantity,
                             m.MealDate
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealDate.Date
                              group gq by dt into g
                              select new WeeklyMacros
                              {
                                  Date = g.Key,
                                  Carb = g.Sum(x => x.Carbonhydrate * x.Quantity),
                                  Protein = g.Sum(x => x.Protein * x.Quantity),
                                  Fat = g.Sum(x => x.Protein * x.Quantity),
                              }).ToList();
            return groupQuery;


        }

        public List<WeeklyUserProtein> CalculateProtein(int UserId)
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
                              select new WeeklyUserProtein
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

        //Haftalık su tüketimi
        public List<WeeklyWaterDto> WeeklyDrinkingWater(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyWater = db.UserWaterRepository.GetAll().Where(x => x.DrinkTime >= dateSevenDayBefore && x.DrinkTime < dateToday && x.UserID == UserId);
            var groupQuery = (from gq in userDailyWater
                              let dt = gq.DrinkTime
                              group gq by dt into g
                              select new WeeklyWaterDto
                              {
                                  Date = g.Key,
                                  Water = g.Sum(x => x.Quantity)
                              }).ToList();
            return groupQuery;


        }

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
        public List<WeeklyStepDto> CalculateStep(int UserId)
        {
            var dateToday = DateTime.Now;
            var dateSevenDayBefore = DateTime.Today.AddDays(-7);
            var userDailyStepRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateSevenDayBefore && x.ActivityTime < dateToday && x.UserID == UserId);
            var userDailyActivityRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateSevenDayBefore && x.ActivityTime < dateToday && x.UserID == UserId);
            var query = (from ua in userDailyActivityRepo
                         join a in db.ActivityRepository.GetAll() on ua.ActivityID equals a.ID
                         select new
                         {
                             
                             ua.StepCount,
                             ua.ActivityTime
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.ActivityTime.Date
                              group gq by dt into g
                              select new WeeklyStepDto
                              {
                                  Date = g.Key,
                                  Step = Convert.ToDouble(g.Sum(x => x.StepCount * 0.03))
                              }).ToList();
            return groupQuery;
        }

        //kilo takibi
        public List<WeeklyWeightDto> CalculateWeight(int UserId)
        {//şu tab
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
        //En çok tüketilen yemek 
        //Yediğimiz öğünleri haftalık/aylık bazda tüm kişiler ile öğün bazlı ve yemek kategorisi bazlı kıyaslamasını raporlasın.

        //Hangi yemeklerin hangi öğünlerde ne kadar yendiğini gösteren bir rapor hazırlansın.

        //bakılacak
        public List<FoodforMealBreakFast> WhichFoodsEatenAtBreakfast(int UserId)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID == UserId);

            var query = (from m in userMeal
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         select new
                         {
                             c.CategoryName,
                             f.FoodName,
                             f.QuantityType,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         }).Where(x => x.MealType == MealType.Breakfast).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.MealType
                              group gq by dt into g
                              select new FoodforMealBreakFast
                              {
                                  MealType = g.Key,
                                  FoodName = g.Select(x => x.FoodName).ToString(),
                                  TotalQuantity = g.Sum(x => x.Quantity)
                                  //toplam miktar?
                              }).OrderByDescending(x => x.TotalQuantity).Take(5).ToList();

            return groupQuery;

        }

        public List<FoodforMealLunch> WhichFoodsEatenAtLunch(int UserId)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID == UserId && x.MealType == MealType.Lunch);

            var query = (from m in userMeal
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         select new
                         {
                             c.CategoryName,
                             f.FoodName,
                             f.QuantityType,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         });
            var groupQuery = (from gq in query
                              group gq by gq.FoodName into g
                              select new FoodforMealLunch
                              {
                                  MealType = MealType.Lunch,
                                  FoodName = g.Key,
                                  TotalQuantity = g.Sum(x => x.Quantity),
                                  TotalCount = g.Count()
                                  //toplam miktar?
                              }).OrderByDescending(x => x.TotalQuantity).Take(5).ToList();

            return groupQuery;

        }

        public List<FoodforMealDinner> WhichFoodsEatenAtDinner(int UserId)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID == UserId);
            var query = (from m in userMeal
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         select new
                         {
                             c.CategoryName,
                             f.FoodName,
                             f.QuantityType,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         }).ToList().Where(x => x.MealType == MealType.Dinner);
            var groupQuery = (from gq in query
                              let dt = gq.MealType
                              group gq by dt into g
                              select new FoodforMealDinner
                              {
                                  MealType = g.Key,
                                  FoodName = g.Select(x => x.FoodName).ToString(),
                                  TotalQuantity = g.Sum(x => x.Quantity)
                                  //toplam miktar?
                              }).OrderByDescending(x => x.TotalQuantity).Take(5).ToList();

            return groupQuery;

        }

        public List<FoodforMealSnack> WhichFoodsEatenAtSnack(int UserId)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID == UserId);
            var query = (from m in userMeal
                         join mf in db.MealFoodRepository.GetAll() on m.ID equals mf.MealID
                         join f in db.FoodRepository.GetAll() on mf.FoodID equals f.ID
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         select new
                         {
                             c.CategoryName,
                             f.FoodName,
                             f.QuantityType,
                             mf.Quantity,
                             m.MealDate,
                             m.MealType
                         }).ToList().Where(x => x.MealType == MealType.Snack);
            var groupQuery = (from gq in query
                              let dt = gq.MealType
                              group gq by dt into g
                              select new FoodforMealSnack
                              {
                                  MealType = g.Key,
                                  FoodName = g.Select(x => x.FoodName).ToString(),
                                  TotalQuantity = g.Sum(x => x.Quantity)
                                  //toplam miktar?
                              }).OrderByDescending(x => x.TotalQuantity).Take(5).ToList();

            return groupQuery;

        }
        //En çok yenen yemekler raporu çıksın.
        public List<MostEatenFoods> MostEatenFood(int UserId)
        {
            var userMeal = db.MealRepository.GetAll().Where(x => x.UserID == UserId);
            var query = (from um in userMeal
                         from f in db.FoodRepository.GetAll()
                         join c in db.CategoryRepository.GetAll() on f.CategoryID equals c.ID
                         join mf in db.MealFoodRepository.GetAll() on f.ID equals mf.FoodID
                         select new
                         {
                             um.UserID,
                             c.CategoryName,
                             f.FoodName,
                             f.QuantityType,
                             mf.Quantity
                         }).ToList();
            var groupQuery = (from gq in query
                              let dt = gq.FoodName
                              group gq by dt into g
                              select new MostEatenFoods
                              {
                                  FoodName = g.Key,
                                  CategoryName = g.Select(x=>x.CategoryName).ToString(),
                                  //QuantityType = g.Select(x=>x.QuantityType).Value,
                                  TotalQuantity = g.Sum(x => x.Quantity)
                              }).OrderByDescending(x => x.TotalQuantity).ToList();

            return groupQuery.ToList();
        }
    }
}
