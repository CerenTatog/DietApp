using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class DailyActivity
    {
        public int ID { get; set; }
        [DisplayName("Süresi")]
        public double Duration { get; set; }
        [DisplayName("Aktivite Adı")]
        public string ActivityName { get; set; }
    }
}
