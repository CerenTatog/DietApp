using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class MealFood:Base
    {
        public int MealID { get; set; }
        public int FoodID { get; set; }

        [ForeignKey("FoodID")]
        public virtual Food Food { get; set; }
        [ForeignKey("MealID")]
        public virtual Meal Meal { get; set; }



    }
}
