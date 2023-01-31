using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Food:Base
    {
        public Food()
        {
            this.FoodDetails = new List<FoodDetail>();
            this.MealFoods = new List<MealFood>();
        }
        [Required]
        [StringLength(120)] //1dilim ekmek vb şeklinde yazacagız
        public string FoodName { get; set; }        
        public double Calorie { get; set; }
        public Nullable<int> CategoryID { get; set; }

        public virtual ICollection<FoodDetail> FoodDetails { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public virtual ICollection<MealFood> MealFoods { get; set; }
    }
}
