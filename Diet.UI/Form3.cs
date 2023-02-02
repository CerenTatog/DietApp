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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form3 : MaterialForm
    {
        FoodManager foodManager = new FoodManager();
        //DietAppContext db1 = new DietAppContext();
        UnitOfWork db = new UnitOfWork();
        //parametreli constructor yapılacak User bilgisi aktarılacak
        public Form3()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.BlueGrey900, Primary.Amber400, Accent.Orange700, TextShade.WHITE);
            
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //var query = from u in db.UserRepository.GetAll()
            //            select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            //dataGridView1.DataSource = query.ToList(); //?? no connection string hatası ??
        }

        private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            var dailyMeail = foodManager.CalculateCalorieIntake(0);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            Hide();
        }

        private void btnAktiviteEkle_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            Hide();
        }
    }
}
