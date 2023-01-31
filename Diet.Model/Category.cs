using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Category:Base
    {
        public Category()
        {
            this.Foods = new List<Food>();
        }
        [Required]
        [StringLength(60)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string Description { get; set; } 

        public virtual ICollection<Food> Foods { get; set; }

    }
}
