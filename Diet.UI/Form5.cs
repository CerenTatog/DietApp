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
    public partial class Form5 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
        MealType _mealType = MealType.Breakfast;
        User _currentUser = null;
        public Form5()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private readonly string _yazi;
        public Form5(string yazi, MealType mealType, User currentUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _yazi = yazi;
            _mealType = mealType;
            _currentUser = currentUser;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            materialLabel5.Text = _yazi;
            if (_yazi == "Kahvaltı")
            {
               pictureBox1.Image = Diet.UI.Properties.Resources.breakfast;
            }
            else if (_yazi == "Öğle Yemeği")
            {
                pictureBox1.Image = Diet.UI.Properties.Resources.fried_rice;
            }
            else if (_yazi == "Akşam Yemeği")
            {
                pictureBox1.Image = Diet.UI.Properties.Resources.omelette;
            }
            else if (_yazi == "Atıştırmalık")
            {
                pictureBox1.Image = Properties.Resources.cashew_atıstırmalık;
            }

            materialComboBox2.DataSource = db.FoodRepository.GetAll().Select(x => new { x.ID, x.FoodName }).ToList();
            materialComboBox2.DisplayMember = "FoodName";
            materialComboBox2.ValueMember = "ID";

        }
        List<MealFood> ogunListesi;
        private void materialButtonEkle_Click(object sender, EventArgs e)
        {
           
            if (materialComboBox2.SelectedValue != null && materialTextBox22 != null)
            {
                Meal meal = new Meal();
                meal.MealDate = DateTime.Now;
                meal.CreatedDate = DateTime.Now;
                meal.MealType = _mealType;
                meal.UserID = _currentUser.ID;
                db.MealRepository.Create(meal);

                MealFood yeniOgun = new MealFood();
                yeniOgun.FoodID = (int)materialComboBox2.SelectedValue;
                yeniOgun.MealID = meal.ID;
                yeniOgun.CreatedDate = DateTime.Now;    
                yeniOgun.Quantity = Convert.ToDouble(materialTextBox22.Text);
                db.MealFoodRepository.Create(yeniOgun);

                ogunListesi = new List<MealFood>();
                ogunListesi.Add(yeniOgun);

                foreach (MealFood item in ogunListesi)
                {
                    materialListBox1.Items.Add(new MaterialListBoxItem()
                    {
                        Text = item.Food.FoodName,
                        Tag = item
                    }) ;
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun. ");
            }

        }

        private void materialButtonSil_Click(object sender, EventArgs e)
        {
            if (materialListBox1.SelectedIndex > 0)
            {
                var mealFood = materialListBox1.SelectedItem.Tag as MealFood;
                materialListBox1.Items.RemoveAt(materialListBox1.SelectedIndex);
                db.MealFoodRepository.Delete(mealFood.ID);
                materialListBox1.Refresh();


            }
           
        }

        private void materialButtonTamamla_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bu alan güncellenecek.
        }
    }
}
