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
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form4 : MaterialForm
    {
        FoodManager foodManager = new FoodManager();
        ReportManager reportManager = new ReportManager();
        User _currentUser;
        ActivityManager activityManager = new ActivityManager();
        UnitOfWork db = new UnitOfWork();
        public Form4()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public Form4(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _currentUser = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //userdetail?
            var query = (from u in db.UserRepository.GetAll()
                         select new AdminUserListDto
                         {
                             CreatedDate = u.CreatedDate,
                             Email = u.Email,
                             UserName = u.UserName,
                             UserSurname = u.UserSurname
                         }).ToList();

            dataGridViewKullaniciListesi.DataSource = query;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }


        private void materialLabel4_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11(_currentUser);
            frm11.ShowDialog();
            this.Hide();
        }

        private void BesinEkle_Click_1(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8(_currentUser);
            frm8.ShowDialog();
            this.Hide();
        }

        private void mlAktiviteDuzenle_Click_1(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9(_currentUser);
            frm9.ShowDialog();
            this.Hide();
        }
    }
}
