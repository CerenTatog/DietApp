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
        DietAppContext db = new DietAppContext();
        public static double TotalCalculateConsumedCalorie() 
        {//bystep+byactivity
            return 0;
        }

        public static double CalculateConsumedCalorieByStep() 
        {
            return 0;
        }

        public static double CalculateConsumedCalorieByActivity()
        {
            return 0;
        }



    }
}
