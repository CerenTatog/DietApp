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
    public partial class Form10 : MaterialForm
    {
        User _currentUser;
        UnitOfWork db = new UnitOfWork();
        public Form10()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.Amber400, Accent.Red100, TextShade.WHITE);
        }
        public Form10(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.BlueGrey900, Primary.Amber400, Accent.Orange700, TextShade.WHITE);
            _currentUser = user;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {//son girilen su?silmek isterse?
            UserWater water = new UserWater();
            water.Quantity = (double)(numericUpDown1.Value);
            water.DrinkTime = DateTime.Now;
            water.UserID = _currentUser.ID;
            db.UserWaterRepository.Create(water);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
