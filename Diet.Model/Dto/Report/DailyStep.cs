using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class DailyStep
    {
        [DisplayName("Adım")]
        public double Step { get; set; }
        [DisplayName("Kalori")]
        public double Calorie { get; set; }
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }
    }
}
