using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;

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
            var query = (from ua in db.UserActivityRepository.GetAll()
                         select new
                         {
                             ua.UserID,
                             ua.StepCount
                         }).Where(x => x.UserID == UserID).FirstOrDefault();
           double LostCalorieByStep = Convert.ToDouble(query.StepCount * 0.03);
            return LostCalorieByStep;
        }

        public double CalculateConsumedCalorieByActivity(int UserId)
        {
            var query = (from u in db.UserRepository.GetAll()
                         join ua in db.UserActivityRepository.GetAll() on u.ID equals ua.UserID
                         join a in db.ActivityRepository.GetAll() on ua.ActivityID equals a.ID
                         select new
                         {
                             u.ID,
                             ua.ActivityID,
                             ua.Duration,
                             a.LostCalorie,
                             TotalLostCalorie = ua.Duration * a.LostCalorie
                         }).Where(x => x.ID == UserId).ToList();
            //int Activity = query.ActivityID;
            //double Duration = query.Duration;
            //double LostCalorie = query.LostCalorie;
            // double LostCalorieByAcrivity =LostCalorie * Duration;
            
            double LostCalorieByAcrivity = Convert.ToDouble(query.Select(x=>x.TotalLostCalorie)); //??Burası düzenlenecek ??


            return LostCalorieByAcrivity;
        }



    }
}
