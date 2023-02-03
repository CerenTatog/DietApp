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
        ActivityManager activityManager = new ActivityManager();
        User _currentUser = null;
        
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(User currentUser)
        {
            InitializeComponent();
            //eşitlenmesi gerekiyor. globalde tanımlanıp
            _currentUser = currentUser;
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var query = (from u in db.ActivityRepository.GetAll()
                         select new
                         {
                             u.ID,
                             u.ActivityName
                         }).ToList();
           
            cmbActivities.DataSource = db.ActivityRepository.GetAll().Select(x => new { x.ID, x.ActivityName }).ToList();
            cmbActivities.DisplayMember = "ActivityName";
            cmbActivities.ValueMember = "ID";
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (cmbActivities.SelectedValue !=null)
            {
                UserActivity NewActivity = new UserActivity();

                NewActivity.ActivityID = (int)cmbActivities.SelectedValue;
                NewActivity.UserID = _currentUser.ID;
                NewActivity.ActivityTime = DateTime.Now;
                NewActivity.Duration = (double)nmrDuration.Value;                             
                NewActivity.CalculatedCalorie = db.ActivityRepository.GetById(NewActivity.ActivityID).LostCalorie * NewActivity.Duration; 
                db.UserActivityRepository.Create(NewActivity);
                lblKCAL.Text = NewActivity.CalculatedCalorie.ToString() + " kCal TEBRİKLER:)";
                
            }
            else
            {
                MessageBox.Show("Lütfen Aktivite Giriniz");
            }
           
        }

        
    }
}
