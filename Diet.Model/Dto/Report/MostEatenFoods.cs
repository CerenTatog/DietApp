using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class MostEatenFoods
    {
       
        public string FoodName { get; set; }
        public string CategoryName { get; set;}
       //public QuantityType QuantityType { get; set;}
        public double TotalQuantity { get; set; }

    }
}
