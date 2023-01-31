using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class BodyCharacteristic:Base
    {
        public BodyCharacteristic()
        {
            this.UserBCs = new List<UserBC>();
        }
        public string BCName { get; set; }

        public virtual ICollection<UserBC> UserBCs { get; set; }
    }
}
