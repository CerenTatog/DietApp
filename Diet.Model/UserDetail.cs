using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserDetail:Base
    {
        
        public double Weight { get; set; }
        public double Height { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
        public int? UserID { get; set; }

        [ForeignKey("UserID")]
        public  virtual User User { get; set; } 
    }
    public enum Gender
    {
        Men=1,
        Women
    }
    public enum ActivityStatus
    {
        NonActive=1,
        MidActive,
        Active,
        FullActive

    }
}
