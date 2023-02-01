using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Model;
using Diet.DAL;
using Diet.DAL.Entities;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;

namespace Diet.BLL
{
    public class FoodManager
    {
        DietAppContext db = new DietAppContext();

        public double CalculateDailyCalorie(int Id)
        {//Kişinin ilk etapta girdiği yaş,cinsiyet, harreket durumu vs.ye göre hesaplanacak değer.
         //kişinin kilo vermesine değişebilir. 
         //Men: BMR = 88.362 + (13.397 x weight in kg) +(4.799 x height in cm) – (5.677 x age in years) Women: BMR = 447.593 + (9.247 x weight in kg) +(3.098 x height in cm) – (4.330 x age in years)
         //Hareketsiz sedanter yaşama sahip kişilerde aktivite katsayısı 1,2’dir.
         //Haftada 1 - 2 kez spor yapan hafif aktif kişilerde 1,375;
         //haftada 3 - 5 kez spor yapanlarda 1,55;
         //haftada 6 - 7 gün spor yapan çok aktif kişilerde 1,725; her gün spor yapan ya da beden işçilerinde ise aktivite katsayısı 1,9’dur.
         //Kilo vermek istiyorsa 
         //Mifflin-St. Jeor
         //BMH(Erkek) = 10 X Ağırlık(kg) +6,25 X Yükseklik(cm) – 5 X yaş(y) +5
        //BMH(Kadın) = 10 X Ağırlık(kg) +6,25 X Yükseklik(cm) – 5 X yaş(y) – 161

            //KATSAYILAR BU KISMA EKLENECEK AKTİVİTE DURUMUNA GÖRE
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

        public double CalculateCalorieIntake(int Id)//check ettirilecek. 
        {
            var query = (from u in db.Users
                        join m in db.Meals on u.ID equals m.UserID
                        join mf in db.MealFoods on m.ID equals mf.MealID
                        join f in db.Foods on mf.FoodID equals f.ID
                        join fd in db.FoodDetails on f.ID equals fd.FoodID
                        select new
                        {   u.ID,
                            f.FoodName,
                            f.Calorie,
                            fd.Quantity,
                            fd.CalculateCalorie, 
                            hCalculatedCalorie = (fd.Quantity * f.Calorie)//bu hesaplamayı satıra nasıl yazdıracağım?
                        }).Where(x=>x.ID == Id).FirstOrDefault();

            var query2 = Convert.ToDouble(query.hCalculatedCalorie);
            return query2;
        }

        public double CalculateTotalCalorie(int Id) 
        {
            //Activity'den gelen metod ile CalculateCalorieIntake farklı 
            return 0;
        }

        public double DailyWaterNeeded(int Id) 
        {//sıcaklık koşulları ignore edilecek. 
            //GSI = kg * 0.033
            var GSI = (from u in db.Users
                       join ud in db.UserDetails on u.ID equals ud.UserID
                       select new
                       {
                           u.ID,
                           ud.Weight,
                           GSI = (ud.Weight * 0.033)
                       }).Where(x => x.ID == Id).FirstOrDefault(); ;

            return GSI.GSI;


        }

        





    }
}
