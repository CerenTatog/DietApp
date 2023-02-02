using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserActivity:Base
    {
        public int UserID { get; set; }
        public int ActivityID { get; set; }
        public DateTime ActivityTime { get; set; }
        public double Duration { get; set; }
        
        public int? StepCount { get; set; }
        public double CalculatedCalorie { get; set; } //?
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        [ForeignKey("ActivityID")]
        public virtual Activity Activity { get; set; }
        
    }
}
