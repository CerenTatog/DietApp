using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Model;
using Diet.DAL;
using Diet.DAL.Entities;

namespace Diet.BLL
{
    public class FoodManager
    {
        DietAppContext db = new DietAppContext();
        public static double CalculateDailyCalorie()
        {//Kişinin ilk etapta girdiği yaş,cinsiyet, harreket durumu vs.ye göre hesaplanacak değer.
            //kişinin kilo vermesine değişebilir. 

            return 0;
        }

        public static double CalculateCalorieIntake()
        {
            return 0;
        }

        public static double CalculateTotalCalorie() 
        {
            return 0;
        }

        public static double DailyWaterNeeded() 
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
