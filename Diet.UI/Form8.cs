using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class Form8 : MaterialForm
    {
        public Form8()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        UnitOfWork db = new UnitOfWork();
        Food food = new Food();
        MealFood mfood = new MealFood();

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadFood();
        }   
        private void btnEkle_Click(object sender, EventArgs e)
        {
            food.FoodName = txtBesinAdi.Text;
            //food.MeasureType //??????
           // mfood.Quantity =Convert.ToDouble(txtMıktar.Text); //?? ölçü ve miktar veritabannında tutulmuyor mealsfood da quantity var ama o öğünün miktarı?
            food.Carbonhydrate =Convert.ToDouble(txtKarbonhıdrat.Text);
            food.Fat = Convert.ToDouble(txtYag.Text);
            food.Protein = Convert.ToDouble(txtProtein.Text);
            food.Calorie =Convert.ToDouble(txtKalori.Text);
            db.FoodRepository.Create(food);
            LoadFood();
                      
        }
        void LoadFood()
        {
            var query = from f in db.FoodRepository.GetAll()
                        select new { f.FoodName, f.Carbonhydrate, f.Fat, f.Calorie };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
