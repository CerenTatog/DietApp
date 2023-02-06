using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public double CalculateCalorieByStep(int stepCount)
        {
            return stepCount * 0.03;
        }

        public double CalculateConsumedCalorieByStep(int UserID)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyStepRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserID && x.StepCount > 0);

            var query = (from ua in userDailyStepRepo
                         select new
                         {
                             TotalCalorie = ua.StepCount * 0.03
                         }).ToList();

            return query.Sum(x => x.TotalCalorie.GetValueOrDefault());
        }

        public int CalculateStepCountByUserId(int UserID)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userDailyStepRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserID && x.StepCount > 0);

            var query = (from ua in userDailyStepRepo
                         select new
                         {
                             TotalStepCount = ua.StepCount
                         }).ToList();

            return query.Sum(x => x.TotalStepCount.GetValueOrDefault());
        }

        public double CalculateConsumedCalorieByActivity(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userActivityRepo = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserId && x.StepCount == null);

            var query = (from userActivity in userActivityRepo
                         join a in db.ActivityRepository.GetAll() on userActivity.ActivityID equals a.ID
                         select new
                         {
                             userActivity.UserID,
                             userActivity.ActivityID,
                             userActivity.ActivityTime,
                             userActivity.Duration,
                             a.LostCalorie
                         }).ToList();

            return query.Sum(x => x.LostCalorie * x.Duration);
        }

        public List<DailyStep> GetDailyStep(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var query = db.UserActivityRepository.GetAll().Where(x => x.ActivityTime >= dateToday && x.ActivityTime < dateEnd && x.UserID == UserId && x.StepCount > 0).Select(x => new DailyStep()
            {
                Step = x.StepCount.Value,
                Date = x.ActivityTime,
                Calorie = x.CalculatedCalorie
            }).ToList();
            return query;

        }
    }
}
