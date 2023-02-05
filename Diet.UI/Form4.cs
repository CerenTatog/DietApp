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

        private void Form4_Load(object sender, EventArgs e)
        {
            //Kullanıcı Listesi -Sistem Raporları
            //var query = from u in db.UserRepository.GetAll()
            //            select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            //dataGridViewKullaniciListesi.DataSource = query.ToList();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void BesinEkle_Click(object sender, EventArgs e)
        {
            //Form8 frm8 = new Form8(_currentUser);
            //frm8.ShowDialog();


        }
        //userıd
        private void mlAktiviteDuzenle_Click(object sender, EventArgs e)
        {
            //Form9 frm9 = new Form9(_currentUser);
            //frm9.ShowDialog();

        }

        private void materialCard10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
