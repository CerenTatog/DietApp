using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.BLL;
using Diet.DAL.Entities;
using MaterialSkin.Controls;


namespace Diet.UI
{
    public partial class Form6 : MaterialForm
    {
        DietAppContext db = new DietAppContext();
        public Form6()
        {
            InitializeComponent();
        }

        private void btnAddStepCount_Click(object sender, EventArgs e)
        {
            double LostCalorieByStep= (ActivityManager.CalculateConsumedCalorieByStep((int)nmrStepCount.Value));
            lblKCAL.Text = LostCalorieByStep.ToString() + " kCal TEBRİKLER.";
        }
    }
}
