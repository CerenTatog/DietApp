using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Model;
using Diet.DAL;
using Diet.DAL.Entities;
using System.Security.Cryptography;

namespace Diet.BLL
{
    public class FoodManager
    {
        DietAppContext db = new DietAppContext();

        public double CalculateDailyCalorie(int Id)
        {//Kişinin ilk etapta girdiği yaş,cinsiyet, harreket durumu vs.ye göre hesaplanacak değer.
         //kişinin kilo vermesine değişebilir. 
         //Men: BMR = 88.362 + (13.397 x weight in kg) +(4.799 x height in cm) – (5.677 x age in years) Women: BMR = 447.593 + (9.247 x weight in kg) +(3.098 x height in cm) – (4.330 x age in years)

            //double weight = db.UserDetails.Select(X=>X.Weight);


            //double BMR = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);

            var querygender = (from u in db.Users
                               join ud in db.UserDetails on u.ID equals ud.UserID
                               select ud).Where(x=>x.ID == Id).FirstOrDefault();
            if (querygender.Gender == Gender.Men)
            {
                var query = (from u in db.Users
                             join ud in db.UserDetails on u.ID equals ud.UserID
                             select new
                             {
                                 u.ID,
                                 TotalBMR = (88.362 + (13.397 * ud.Weight) + (4.799 * ud.Height) - (5.677 * ud.Age))
                             }).Where(x => x.ID == Id).FirstOrDefault();
                double BMR1 = Convert.ToDouble(query.TotalBMR);

                return BMR1;
            }
            else
            {
                var query = (from u in db.Users
                             join ud in db.UserDetails on u.ID equals ud.UserID
                             select new
                             {
                                 u.ID,
                                 TotalBMR = (447.593 + (9.247 * ud.Weight) + (3.098*ud.Height) - (4.330*ud.Age))
                             }).Where(x => x.ID == Id).FirstOrDefault();
                double BMR2 = Convert.ToDouble(query.TotalBMR);

                return BMR2;
            }
            
        }

        public double CalculateCalorieIntake()
        {
            return 0;
        }

        public double CalculateTotalCalorie() 
        {
            return 0;
        }

        public double DailyWaterNeeded() 
        {
            return 0;

        }

        //private void FiyatiOrtalamanınUzerindeOlanlar()
        //{
        //    var query = (from p in db.Products
        //                 let avg = db.Products.Select(x => x.UnitPrice).Average()
        //                 where p.UnitPrice > avg
        //                 select new { p.ProductID, p.ProductName, p.UnitPrice }).ToList();

        //    var query2 = db.Products.Select(x => x.UnitPrice).Average();

        //    var query3 = db.Products.Where(x => x.UnitPrice > query2).ToList();
        //}

        //Parametreli
        //private List<Products> ProductGetByLessThenPrice(decimal unitPrice)
        //{
        //    return db.Products.Where(x => x.UnitPrice > unitPrice && x.Discontinued == false).ToList();
        //}

        //private void YilaGoreMaxSatisiHesapla(DateTime time)
        //{
        //    var query = (from od in db.Order_Details
        //                 join o in db.Orders on od.OrderID equals o.OrderID
        //                 where o.OrderDate.Value.Year == time.Year
        //                 select new
        //                 {
        //                     o.OrderID,
        //                     o.OrderDate,
        //                     od.UnitPrice,
        //                     od.Quantity,
        //                     od.Discount
        //                 }).ToList();
        //    var groupquery = (from odg in query
        //                      group odg by odg.OrderID into g
        //                      select new
        //                      {
        //                          OrderID = g.Key,
        //                          TotalPrice = g.Sum(x => (x.UnitPrice * ((decimal)(x.Quantity)) * (decimal)(1 - x.Discount)))
        //                      }).OrderByDescending(x => x.TotalPrice).ToList();

        //}





    }
}
