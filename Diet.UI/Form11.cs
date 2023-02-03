using Diet.DAL.GenericRepository;
using Diet.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.UI
{
    public partial class Form11 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
         public Form11()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadCategory();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        void LoadCategory()
        {
            var query = from f in db.CategoryRepository.GetAll()
                        select new {f.ID,  f.CategoryName, f.Description};
            dataGridView1.DataSource = query.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.CategoryName = txtKategoriAdi.Text;
            cat.Description = txtTanimlama.Text;           
            db.CategoryRepository.Create(cat);
            LoadCategory();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Category DeletedCat = new Category();
            DeletedCat = db.CategoryRepository.GetById(Id);
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show($@"{DeletedCat.CategoryName} besini silinecek besin listesini kalıcı olarak silmek istediğinizden eminmisiniz?", "Kalıcı Olarak Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                db.CategoryRepository.Delete(Id);
                LoadCategory();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //int ıd = Convert.ToInt32 (db.CategoryRepository.GetById(Id));
            Category UpdateCat = db.CategoryRepository.GetById(Id);
            UpdateCat.CategoryName = txtKategoriAdi.Text;
            UpdateCat.Description = txtTanimlama.Text;
            db.CategoryRepository.Update(UpdateCat);
            LoadCategory();           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKategoriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtTanimlama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form3 Frm3 = new Form3();
            Frm3.Show();
            Hide();
        }
    }
}
