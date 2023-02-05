using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.DAL.GenericRepository;
using Diet.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form9 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
        public Form9()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadActivities();
        }
        public Form9(User currentUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadActivities();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            Activity AddetActivity = new Activity();
            AddetActivity.ActivityName = txtActivityType.Text;
            AddetActivity.LostCalorie = Convert.ToDouble(txtCalorie.Text);
            AddetActivity.CreatedDate = DateTime.Now;
            db.ActivityRepository.Create(AddetActivity);
            loadActivities();
        }
        void loadActivities()
        {
            var query = from a in db.ActivityRepository.GetAll()
                        select new { a.ID, a.ActivityName, a.LostCalorie, a.CreatedDate };
            dgvActivities.DataSource = query.ToList();
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvActivities.CurrentRow.Cells[0].Value.ToString());
            Activity DeletedActivity = new Activity();
            DeletedActivity = db.ActivityRepository.GetById(Id);
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{DeletedActivity.ActivityName} Aktivitesi silinecek Aktivite listesini kalıcı olarak silmek istediğinizden eminmisiniz?", "Kalıcı Olarak Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                db.ActivityRepository.Delete(Id); // REMOVE HATA ALDIK
                loadActivities();
            }
        }

        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgvActivities.CurrentRow.Cells[0].Value.ToString());
            Activity UpdatedActivity = new Activity();
            UpdatedActivity.ActivityName = txtActivityType.Text;
            UpdatedActivity.LostCalorie = Convert.ToDouble( txtCalorie.Text);
            UpdatedActivity.CreatedDate = DateTime.Now;
            db.ActivityRepository.Update(UpdatedActivity); //SaveChanges hata verdi
            loadActivities();
        }

        private void dgvActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActivityType.Text = dgvActivities.CurrentRow.Cells[1].Value.ToString();
            txtCalorie.Text = dgvActivities.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 Frm3 = new Form3();
            Frm3.Show();
            Hide();
        }
    }
}
