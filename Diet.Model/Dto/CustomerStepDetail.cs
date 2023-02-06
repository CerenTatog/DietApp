using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto
{
    public class CustomerStepDetail
    {
        [DisplayName("Adım Sayısı")]
        public int  StepCount { get; set; }
        [DisplayName("Kalori Hesabı")]
        public double  CalculatedCalorie { get; set; }
        [DisplayName("Zaman")]
        public double  Duration { get; set; }
    }
}
