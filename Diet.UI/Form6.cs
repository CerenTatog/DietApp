using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Diet.BLL;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Diet.UI
{
    public partial class Form6 : MaterialForm
    {

        UnitOfWork db = new UnitOfWork();
        User _currentUser;
        ActivityManager activityManager = new ActivityManager();
        public Form6()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public Form6(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAddStepCount_Click(object sender, EventArgs e)
        {
            //LostCalorie User ekranına gönderilmeli.
            var query = (from ua in db.UserActivityRepository.GetAll()
                         select new { ua.UserID, ua.StepCount }).Where(x => x.UserID == _currentUser.ID);
            UserActivity newuserAct = new UserActivity();
            newuserAct.UserID = _currentUser.ID;
            newuserAct.ActivityID = 1;
            newuserAct.ActivityTime = DateTime.Now;
            newuserAct.Duration = 25;
            newuserAct.CalculatedCalorie = activityManager.CalculateCalorieByStep((int)nmrStepCount.Value);
            newuserAct.StepCount = Convert.ToInt32(nmrStepCount.Value);
            db.UserActivityRepository.Create(newuserAct);
            lblKCAL.Text = newuserAct.CalculatedCalorie.ToString() + " kcal";
            this.Close();

            LoadStep();


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadStep();
        }
        void LoadStep()
        {


            var query = (from u in db.UserActivityRepository.GetAll()
                         select new CustomerStepDetail
                         {
                             StepCount = (int)u.StepCount,
                             CalculatedCalorie = u.CalculatedCalorie,
                             Duration = u.Duration

                         }).ToList();

            dataGridView1.DataSource = query;
        }
    }
}
