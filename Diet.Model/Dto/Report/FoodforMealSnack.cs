using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class FoodforMealSnack
    {
        //burası okey mi?
        public MealType MealType { get; set; } = MealType.Snack;
        public string FoodName { get; set; }
        public double TotalQuantity { get; set; }
        
                                 

    }
}
