using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserNotification : Base
    {
        public int UserID { get; set; }
        public string Message { get; set; }
        public NotificationStateEnum State { get; set; }
        public bool IsRead { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }

    public enum NotificationStateEnum
    {
        Waiting = 1,
        Cancel,
        Approve
    }
}
