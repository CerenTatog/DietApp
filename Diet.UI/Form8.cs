using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.BLL.Helper;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form8 : MaterialForm
    {
        byte[] foodImage;
        public Form8()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            List<CustomSelectItem> quantityTypeList = Enum.GetValues(typeof(QuantityType)).Cast<QuantityType>().ToList().Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbMiktarTuru.DataSource = quantityTypeList;
            cmbMiktarTuru.DisplayMember = "Label";
            cmbMiktarTuru.ValueMember = "Value";

            var query = from c in db.CategoryRepository.GetAll()
                        select new CustomSelectItem()
                        {
                            Label = c.CategoryName,
                            Value = c.ID
                        };
            cmbCategories.DataSource = query.ToList();
            cmbCategories.DisplayMember = "Label";
            cmbCategories.ValueMember = "Value";
        }
        public Form8(User currentUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            List<CustomSelectItem> quantityTypeList = Enum.GetValues(typeof(QuantityType)).Cast<QuantityType>().ToList().Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbMiktarTuru.DataSource = quantityTypeList;
            cmbMiktarTuru.DisplayMember = "Label";
            cmbMiktarTuru.ValueMember = "Value";

            var query = from c in db.CategoryRepository.GetAll()
                        select new CustomSelectItem()
                        {
                            Label = c.CategoryName,
                            Value = c.ID
                        };
            cmbCategories.DataSource = query.ToList();
            cmbCategories.DisplayMember = "Label";
            cmbCategories.ValueMember = "Value";
        }
        UnitOfWork db = new UnitOfWork();

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadFood();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string foodName = txtBesinAdi.Text.Trim();
            var checkFood = db.FoodRepository.GetAll().Any(x => x.FoodName == foodName);
            if (checkFood)
            {
                MessageBox.Show("Aynı isimli besin zaten eklenmiştir.");
            }
            else
            {
                Food food = new Food();
                food.FoodName = txtBesinAdi.Text.Trim();
                food.Carbonhydrate = Convert.ToDouble(txtKarbonhıdrat.Text);
                food.Portion = (QuantityType)cmbMiktarTuru.SelectedValue;
                food.CategoryID = (int)cmbCategories.SelectedValue;
                food.Fat = Convert.ToDouble(txtYag.Text);
                food.Protein = Convert.ToDouble(txtProtein.Text);
                food.Calorie = Convert.ToDouble(txtKalori.Text);
                food.FoodPicture = foodImage;
                db.FoodRepository.Create(food);

                LoadFood();

            }
        }
        void LoadFood()
        {
            var query = from f in db.FoodRepository.GetAll()
                        select new { f.ID, f.FoodName, f.Portion, f.Carbonhydrate, f.Fat, f.Protein, f.Calorie, f.FoodPicture };

            //Set AutoGenerateColumns False.
            dataGridView1.AutoGenerateColumns = false;

            //Set Columns Count.
            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.ColumnCount = 8;

                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].DataPropertyName = "ID";

                dataGridView1.Columns[1].HeaderText = "FoodName";
                dataGridView1.Columns[1].Name = "FoodName";
                dataGridView1.Columns[1].DataPropertyName = "FoodName";

                dataGridView1.Columns[2].HeaderText = "Portion";
                dataGridView1.Columns[2].Name = "Portion";
                dataGridView1.Columns[2].DataPropertyName = "Portion";

                dataGridView1.Columns[3].HeaderText = "Carbonhydrate";
                dataGridView1.Columns[3].Name = "Carbonhydrate";
                dataGridView1.Columns[3].DataPropertyName = "Carbonhydrate";

                dataGridView1.Columns[4].HeaderText = "Fat";
                dataGridView1.Columns[4].Name = "Fat";
                dataGridView1.Columns[4].DataPropertyName = "Fat";

                dataGridView1.Columns[5].HeaderText = "Protein";
                dataGridView1.Columns[5].Name = "Protein";
                dataGridView1.Columns[5].DataPropertyName = "Protein";

                dataGridView1.Columns[6].HeaderText = "Calorie";
                dataGridView1.Columns[6].Name = "Calorie";
                dataGridView1.Columns[6].DataPropertyName = "Calorie";

                //Add a Image Column to the DataGridView at the third position.

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "FoodPicture";
                imageColumn.DataPropertyName = "FoodPicture";
                imageColumn.HeaderText = "FoodPicture";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.Columns.Insert(7, imageColumn);
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Columns[7].Width = 50;
            }

            dataGridView1.DataSource = query.OrderByDescending(x => x.ID).ToList();
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
            UpdatedFood = db.FoodRepository.GetById(Id);
            UpdatedFood.FoodName = txtBesinAdi.Text;
            UpdatedFood.Carbonhydrate = Convert.ToInt32(txtKarbonhıdrat.Text);
            UpdatedFood.Portion = (QuantityType)cmbMiktarTuru.SelectedValue;
            UpdatedFood.Fat = Convert.ToInt32(txtYag.Text);            
            UpdatedFood.Protein = Convert.ToInt32(txtProtein.Text);
            UpdatedFood.Calorie = Convert.ToInt32(txtKalori.Text);
            db.FoodRepository.Update(UpdatedFood);//SaveChanges hata verdi
            LoadFood();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form4 Frm4 = new Form4();
            Frm4.Show();
            Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    byte[] bytes = File.ReadAllBytes(fileName);
                    foodImage = bytes;
                    string contentType = "";
                    //Set the contenttype based on File Extension

                    switch (Path.GetExtension(fileName))
                    {
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                        case ".gif":
                            contentType = "image/gif";
                            break;
                        case ".bmp":
                            contentType = "image/bmp";
                            break;
                    }

                    //string constr = @"Data Source=.\SQL2014;Initial Catalog=dbFiles;Integrated Security=true";
                    //using (SqlConnection conn = new SqlConnection(constr))
                    //{
                    //    string sql = "INSERT INTO tblFiles VALUES(@Name, @ContentType, @Data)";
                    //    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    //    {
                    //        cmd.Parameters.AddWithValue("@Name", Path.GetFileName(fileName));
                    //        cmd.Parameters.AddWithValue("@ContentType", contentType);
                    //        cmd.Parameters.AddWithValue("@Data", bytes);
                    //        conn.Open();
                    //        cmd.ExecuteNonQuery();
                    //        conn.Close();
                    //    }
                    //}

                    //7.BindDataGridView();

                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
