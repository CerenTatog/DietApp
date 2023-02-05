using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class MostEatenFoods
    {
        [DisplayName("Besin Adı")]
        public string FoodName { get; set; }
        [DisplayName("Kategori")]
        public string CategoryName { get; set; }
        [DisplayName("Miktar")]
        public double TotalQuantity { get; set; }

    }
}
