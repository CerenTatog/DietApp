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
using Diet.Model;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Diet.UI
{
    public partial class Form6 : MaterialForm
    {
        DietAppContext db = new DietAppContext();
        public Form6()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public Form6(User currentUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAddStepCount_Click(object sender, EventArgs e)
        {
            //LostCalorie User ekranına gönderilmeli.
            double LostCalorieByStep= (ActivityManager.CalculateConsumedCalorieByStep((int)nmrStepCount.Value));
            lblKCAL.Text = LostCalorieByStep.ToString() + " kCal TEBRİKLER.";
        }
    }
}
