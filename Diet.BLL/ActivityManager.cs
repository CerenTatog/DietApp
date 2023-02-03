using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto.Report;

namespace Diet.BLL
{
    public class ActivityManager
    {
        UnitOfWork db = new UnitOfWork();
        User _currentUser;
        public double TotalCalculateConsumedCalorie(int UserId) 
        {//bystep+byactivity
            double TotalLostCalorie = CalculateConsumedCalorieByStep(UserId) + CalculateConsumedCalorieByActivity(UserId);

            return TotalLostCalorie;
        }

        public double CalculateConsumedCalorieByStep(int UserID) 
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            //var userDailyStepRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserID);

            var query = (from ua in db.UserActivityRepository.GetAll()
                         select new
                         {
                             ua.UserID,
                             ua.ActivityTime,
                             ua.StepCount
                         }).ToList();
           //double LostCalorieByStep = Convert.ToDouble(query.StepCount * 0.03);
            var groupQuery = (from gq in query
                              let dt = gq.ActivityTime.Date
                              group gq by dt into g
                              select new DailyStep
                              {
                                  Date = g.Key,
                                  Step = Convert.ToDouble(g.Sum(x => x.StepCount * 0.03))
                              }).ToList();
            return Convert.ToDouble(groupQuery);
        }

        public double CalculateConsumedCalorieByActivity(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyMealRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserId);

            var query = (from u in db.UserRepository.GetAll()
                         join ua in db.UserActivityRepository.GetAll() on u.ID equals ua.UserID
                         join a in db.ActivityRepository.GetAll() on ua.ActivityID equals a.ID
                         select new
                         {
                             u.ID,
                             ua.ActivityID,
                             ua.ActivityTime,
                             ua.Duration,
                             a.LostCalorie
                         }).ToList();
            //int Activity = query.ActivityID;
            //double Duration = query.Duration;
            //double LostCalorie = query.LostCalorie;
            // double LostCalorieByAcrivity =LostCalorie * Duration;
            //double LostCalorieByAcrivity = query.Duration * query.LostCalorie;
            var groupQuery = (from gq in query
                              let dt = gq.ActivityTime.Date
                              group gq by dt into g
                              select new DailyActivity
                              {
                                  Date = g.Key,
                                  Activity=g.Sum(x=> x.LostCalorie*x.Duration)
                              }).ToList();

            return Convert.ToDouble(groupQuery);
        }



    }
}
