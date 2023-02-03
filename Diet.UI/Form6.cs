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
using Diet.DAL.GenericRepository;
using Diet.Model;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Diet.UI
{
    public partial class Form6 : MaterialForm
    {
        
        UnitOfWork db = new UnitOfWork();
        User _currentUser;
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
            currentUser = _currentUser;
        }

        private void btnAddStepCount_Click(object sender, EventArgs e)
        {
            //LostCalorie User ekranına gönderilmeli.
            var query = (from ua in db.UserActivityRepository.GetAll()
                         select new { ua.UserID, ua.StepCount }).Where(x => x.UserID == _currentUser.ID);
            double LostCalorieByStep= ActivityManager.CalculateConsumedCalorieByStep(_currentUser.ID);
            UserActivity newuserAct = new UserActivity();
            newuserAct.UserID = _currentUser.ID;
            newuserAct.ActivityID = 1;
            newuserAct.ActivityTime = DateTime.Now;
            newuserAct.Duration = 25;
            newuserAct.CalculatedCalorie = LostCalorieByStep;
            newuserAct.StepCount =Convert.ToInt32(nmrStepCount.Value);
            db.UserActivityRepository.Create(newuserAct);
            lblKCAL.Text = LostCalorieByStep.ToString() + " kCal TEBRİKLER.";


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
