using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class FoodDetail:Base
    {
       
        public double CalculateCalorie { get; set; }

        public double Quantity { get; set; }
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public int FoodID { get; set; }

        [ForeignKey("FoodID")]
        public virtual Food Food { get; set; }
    }
    
}
