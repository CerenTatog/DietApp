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
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diet.UI
{
    public partial class Form7 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(User User)
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var query = (from u in db.ActivityRepository.GetAll()
                         select new
                         {
                             u.ID,
                             u.ActivityName
                         }).ToList();
            cmbActivities.Items.Add(query);
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            int ID = 1;//Kullanıcı giriş yaptığında tüm formlara gönderilecek.
            UserActivity NewActivity = new UserActivity();
            NewActivity.ActivityID = cmbActivities.SelectedIndex;
            NewActivity.ActivityTime = DateTime.Now;
            NewActivity.Duration = (double)nmrDuration.Value;
            double LostCalorieByAcrivity = ActivityManager.CalculateConsumedCalorieByActivity(ID); //Bu değer User Formuna gönderilmeli verilen kalori chart ına
            NewActivity.CalculatedCalorie = LostCalorieByAcrivity;
            db.UserActivityRepository.Create(NewActivity);
            lblKCAL.Text = LostCalorieByAcrivity.ToString() + " kCal TEBRİKLER:)";
        }
    }
}
