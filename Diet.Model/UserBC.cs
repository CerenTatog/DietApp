using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserBC : Base
    {
        public int UserID { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
        public DateTime MeasuredDate { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
