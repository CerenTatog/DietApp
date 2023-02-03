using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;

namespace Diet.BLL
{
    public class ActivityManager
    {
        static UnitOfWork db = new UnitOfWork();
        
        public double TotalCalculateConsumedCalorie(int UserId) 
        {//bystep+byactivity
            double TotalLostCalorie = CalculateConsumedCalorieByStep(UserId) + CalculateConsumedCalorieByActivity(UserId);

            return TotalLostCalorie;
        }

        public static double CalculateConsumedCalorieByStep(int UserID) 
        {
            var query = (from ua in db.UserActivityRepository.GetAll()
                         select new
                         {
                             ua.UserID,
                             ua.StepCount
                         }).Where(x => x.UserID == UserID).FirstOrDefault();
           double LostCalorieByStep = Convert.ToDouble(query.StepCount * 0.03);
            return LostCalorieByStep;
        }

        public static double CalculateConsumedCalorieByActivity(int UserId)
        {
            var query = (from u in db.UserRepository.GetAll()
                         join ua in db.UserActivityRepository.GetAll() on u.ID equals ua.UserID
                         join a in db.ActivityRepository.GetAll() on ua.ActivityID equals a.ID
                         select new
                         {
                             u.ID,
                             ua.ActivityID,
                             ua.Duration,
                             a.LostCalorie
                         }).Where(x => x.ID == UserId).FirstOrDefault();
            int Activity = query.ActivityID;
            //double Duration = query.Duration;
            //double LostCalorie = query.LostCalorie;
            // double LostCalorieByAcrivity =LostCalorie * Duration;
            double LostCalorieByAcrivity = query.Duration * query.LostCalorie;


            return LostCalorieByAcrivity;
        }



    }
}
