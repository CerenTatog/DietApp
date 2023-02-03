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

            List<string> Type = new List<string>();
            Type.Add(QuantityType.adet.ToString());
            Type.Add(QuantityType.dilim.ToString());
            Type.Add(QuantityType.ml.ToString());
            Type.Add(QuantityType.gr.ToString());

            foreach (var item in Type)
            {
                cmbMiktarTuru.Items.Add(item);
            }
        }
        public Form8(User currentUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            List<string> Type = new List<string>();
            Type.Add(QuantityType.adet.ToString());
            Type.Add(QuantityType.dilim.ToString());
            Type.Add(QuantityType.ml.ToString());
            Type.Add(QuantityType.gr.ToString());
            
            foreach (var item in Type)
            {
                cmbMiktarTuru.Items.Add(item);
            }
        }
        UnitOfWork db = new UnitOfWork();
        
        private void Form8_Load(object sender, EventArgs e)
        {
            LoadFood();
        }   
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.FoodName = txtBesinAdi.Text;            
            food.Carbonhydrate =Convert.ToDouble(txtKarbonhıdrat.Text);
            food.QuantityType =(QuantityType)(cmbMiktarTuru.SelectedIndex);
            food.Fat = Convert.ToDouble(txtYag.Text);
            food.Protein = Convert.ToDouble(txtProtein.Text);
            food.Calorie =Convert.ToDouble(txtKalori.Text);
            db.FoodRepository.Create(food);
            LoadFood();
                      
        }
        void LoadFood()
        {
            var query = from f in db.FoodRepository.GetAll()
                        select new { f.ID,f.FoodName,f.QuantityType, f.Carbonhydrate, f.Fat, f.Protein,f.Calorie };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Food DeletedFood = new Food();
            DeletedFood = db.FoodRepository.GetById(Id);
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{DeletedFood.FoodName} besini silinecek besin listesini kalıcı olarak silmek istediğinizden eminmisiniz?", "Kalıcı Olarak Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                db.FoodRepository.Delete(Id);// REMOVE HATA ALDIK
                LoadFood();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBesinAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //cmbMiktarTuru.SelectedIndex = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKarbonhıdrat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYag.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtProtein.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           txtKalori.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Food UpdatedFood = new Food();
            UpdatedFood.FoodName = txtBesinAdi.Text;
            UpdatedFood.Carbonhydrate =Convert.ToInt32(txtKarbonhıdrat.Text);
            UpdatedFood.QuantityType =(QuantityType)cmbMiktarTuru.SelectedIndex;
            UpdatedFood.Fat =Convert.ToInt32(txtYag.Text);
            UpdatedFood.Protein =Convert.ToInt32(txtProtein.Text);
            UpdatedFood.Calorie =Convert.ToInt32(txtKalori.Text);
            db.FoodRepository.Update(UpdatedFood);//SaveChanges hata verdi
            LoadFood();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 Frm3 = new Form3();
            Frm3.Show();
            Hide();
        }
    }
}
