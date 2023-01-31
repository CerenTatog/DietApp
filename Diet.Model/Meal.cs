using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Meal:Base
    {
        public Meal()
        {
            this.MealFoods = new List<MealFood>();
        }
        public MealType MealType { get; set; }
        public DateTime MealDate { get; set; }
        public int UserID { get; set; }

        public virtual ICollection<MealFood> MealFoods { get; set; }
        [ForeignKey("UserID")] 
        public virtual User User { get; set; } //?

    }
    public enum MealType
    {
        Breakfast=1,
        Lunch,
        Dinner,
        Snack
    }
}
