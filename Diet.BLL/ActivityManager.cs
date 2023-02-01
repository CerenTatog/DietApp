using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;

namespace Diet.BLL
{
    public class ActivityManager
    {
        static DietAppContext db = new DietAppContext();
        public static double TotalCalculateConsumedCalorie(int Id, int StepCount) 
        {//bystep+byactivity
            double TotalLostCalorie = CalculateConsumedCalorieByStep(StepCount) + CalculateConsumedCalorieByActivity(Id);

            return TotalLostCalorie;
        }

        public static double CalculateConsumedCalorieByStep(int StepCount) 
        {
            double LostCalorieByStep = StepCount * 0.03;
            return LostCalorieByStep;
        }

        public static double CalculateConsumedCalorieByActivity(int Id)
        {
            var query = (from u in db.Users
                         join ua in db.UserActivities on u.ID equals ua.UserID
                         join a in db.Activities on ua.ActivityID equals a.ID
                         select new
                         {
                             u.ID,
                             ua.ActivityID,
                             ua.Duration,
                             a.LostCalorie
                         }).Where(x => x.ID == Id).FirstOrDefault();
            int Activity = query.ActivityID;
            //double Duration = query.Duration;
            //double LostCalorie = query.LostCalorie;
            // double LostCalorieByAcrivity =LostCalorie * Duration;
            double LostCalorieByAcrivity = query.Duration * query.LostCalorie;


            return LostCalorieByAcrivity;
        }



    }
}
