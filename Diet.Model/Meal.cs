using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual User User { get; set; }

    }
    public enum MealType
    {
        [Display(Name ="Kahvaltı")]
        Breakfast=1,
        [Display(Name = "Öğlen Yemeği")]
        Lunch,
        [Display(Name = "Akşam Yemeği")]
        Dinner,
        [Display(Name = "Atıştırmalık")]
        Snack
       
    }
}
