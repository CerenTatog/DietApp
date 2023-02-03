using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model.Dto.Report
{
    public class WeeklyMacros
    {
        public DateTime Date { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Carb { get; set; }
        
    }
}
