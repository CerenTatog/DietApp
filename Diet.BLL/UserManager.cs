using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto.Report;

namespace Diet.BLL
{
    public class UserManager
    {
        UnitOfWork db = new UnitOfWork();

        public double GetDailyWater(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userWater = db.UserWaterRepository.GetAll().Where(x => x.DrinkTime >= dateToday && x.DrinkTime < dateEnd && x.UserID == UserId).FirstOrDefault();
            return userWater != null ? userWater.Quantity : 0;
        }
        public double AddDailyWater(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userWater = db.UserWaterRepository.GetAll().Where(x => x.DrinkTime >= dateToday && x.DrinkTime < dateEnd && x.UserID == UserId).FirstOrDefault();
            if (userWater == null)
            {
                UserWater dbItem = new UserWater
                {
                    CreatedDate = DateTime.Now,
                    DrinkTime = DateTime.Now,
                    Quantity = 250,
                    UserID = UserId
                };
                db.UserWaterRepository.Create(dbItem);
                return dbItem.Quantity;
            }
            else
            {
                userWater.Quantity += 250;
                db.UserWaterRepository.Update(userWater);
                return userWater.Quantity;
            }
        }

        public double RemoveDailyWater(int UserId)
        {
            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);
            var userWater = db.UserWaterRepository.GetAll().Where(x => x.DrinkTime >= dateToday && x.DrinkTime < dateEnd && x.UserID == UserId).FirstOrDefault();
            if (userWater != null)
            {
                if (userWater.Quantity == 250)
                {
                    db.UserWaterRepository.Delete(userWater.ID);
                    return 0;
                }
                else
                {
                    userWater.Quantity -= 250;
                    db.UserWaterRepository.Update(userWater);
                    return userWater.Quantity;
                }
            }
            return 0;
        }

       

    }
}
