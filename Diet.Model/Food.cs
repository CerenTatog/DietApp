using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Food : Base
    {
        public Food()
        {
            this.MealFoods = new List<MealFood>();
        }
        [Required]
        [StringLength(120)] 
        public string FoodName { get; set; }
        public QuantityType Portion{ get; set; }
        public double Calorie { get; set; }
        public int CategoryID { get; set; }        
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public byte[] FoodPicture { get; set; }
        public double PortionQuantity { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public virtual ICollection<MealFood> MealFoods { get; set; }
    }
    public enum QuantityType 
    {
        [Display(Name ="Adet")]
        Adet=1,
        [Display(Name = "Ml")]
        Ml,
        [Display(Name = "Gr")]
        Gr,
        [Display(Name = "Dilim")]
        Dilim
    }
}
