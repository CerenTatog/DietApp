using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserWater:Base
    {
        public int UserID { get; set; }
        public double Quantity { get; set; }
        public DateTime DrinkTime { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

    }
}
