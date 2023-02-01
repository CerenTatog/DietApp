using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Activity:Base
    {
        public Activity()
        {
            this.UserActivities = new List<UserActivity>();
        }
        [Required]
        [StringLength(50)]
        public string ActivityName { get; set; }
        public double LostCalorie { get; set; }
        
        public virtual ICollection<UserActivity> UserActivities { get; set; }//
    }
}
