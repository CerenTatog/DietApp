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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public Form7(User currentUser)
        {
            InitializeComponent();
            //eşitlenmesi gerekiyor. globalde tanımlanıp
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _currentUser = currentUser;
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadCmbAndDgv();
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
                lblKCAL.Text = NewActivity.CalculatedCalorie.ToString() + " kCal";
                LoadCmbAndDgv();                
            }
            else
            {
                MessageBox.Show("Lütfen Aktivite Giriniz");
            }
           
        }
        public void LoadCmbAndDgv()
        {
            // cmb Aktivite seçenekleri
            cmbActivities.DataSource = db.ActivityRepository.GetAll().Select(x => new { x.ID, x.ActivityName }).ToList();
            cmbActivities.DisplayMember = "ActivityName";
            cmbActivities.ValueMember = "ID";

            dataGridView1.DataSource = activityManager.GetDailyActivity(_currentUser.ID);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButtonSil_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult sor = new DialogResult();
            sor = System.Windows.Forms.MessageBox.Show("Aktivite silinecek. Silmek istediğinizden eminmisiniz?", "Kalıcı Olarak Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                db.UserActivityRepository.Delete(Id);
                LoadCmbAndDgv();
            }
        }
    }
}
