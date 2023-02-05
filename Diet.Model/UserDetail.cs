using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public double TargetWeight { get; set;}
        public int? UserID { get; set; }

        [ForeignKey("UserID")]
        public  virtual User User { get; set; } 
    }
    public enum Gender
    {
        [Display(Name = "Erkek")]
        Men =1,
        [Display(Name = "Kadın")]
        Women
    }
    public enum ActivityStatus
    {
        [Display(Name ="Aktif Değil")]
        NonActive=1,
        [Display(Name = "Orta Aktif")]
        MidActive,
        [Display(Name = "Aktif")]
        Active,
        [Display(Name = "Çok Aktif")]
        FullActive

    }
}
