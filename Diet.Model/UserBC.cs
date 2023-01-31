using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserBC:Base
    {
        public int UserID { get; set; }
        public int BCID { get; set; }
        public int MeasurementValue { get; set; }
        public DateTime MeasuredDate { get; set; }
        public MeasureType MeasureType { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        [ForeignKey("BCID")]
        public virtual BodyCharacteristic BodyCharacteristic { get; set; }
    }
    public enum MeasureType
    {
        cm,
        kg

    }
}
