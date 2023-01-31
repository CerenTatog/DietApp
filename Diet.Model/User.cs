using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class User:Base
    {
        public User()
        {
            this.Meals = new List<Meal>();
            this.UserActivities = new List<UserActivity>();
            this.UserBCs = new List<UserBC>();
        }
        [Required]//
        [StringLength(50)]
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        [Required]
        [StringLength(128)]
        public string Password { get; set; }
        [Required]
        [StringLength(80)]
        public string Email { get; set; }
        public UserType UserType { get; set; }

       
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<UserActivity> UserActivities { get; set; }

        public virtual ICollection<UserBC> UserBCs { get; set; }
    }
    public enum UserType
    {
        Admin=1,
        User
    }
}
 
