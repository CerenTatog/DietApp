using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class UserBC : Base
    {
        public int UserID { get; set; }
        public BodyCharacteristicTypeEnum BodyCharacteristicType { get; set; }
        public double MeasurementValue { get; set; }
        public DateTime MeasuredDate { get; set; }
        public MeasureTypeEnum MeasureType { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
    public enum MeasureTypeEnum
    {
        cm = 1,
        kg
    }
    /// <summary>
    /// bu alan güncellenecek
    /// </summary>
    public enum BodyCharacteristicTypeEnum
    {
        Kilo = 1,
        Boy,
    }
}
