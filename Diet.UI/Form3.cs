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
    public partial class Form3 : MaterialForm
    {
        FoodManager foodManager = new FoodManager();
        ReportManager reportManager = new ReportManager();
        User _currentUser;
        UnitOfWork db = new UnitOfWork();

        //parametreli constructor yapılacak User bilgisi aktarılacak
        public Form3()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.BlueGrey900, Primary.Amber400, Accent.Purple400, TextShade.WHITE);
            
           
        }
        public Form3(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.BlueGrey900, Primary.Amber400, Accent.Orange700, TextShade.WHITE);
            _currentUser = user;

            var query = from u in db.UserRepository.GetAll()
                        select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            dataGridView1.DataSource = query.ToList();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Karbonhidrat,Yağ, Protein gösterim alanı
            label1.Text = foodManager.DailyTakenCarbonhyrate(/*_currentUser.ID*/0).ToString();
            label4.Text = foodManager.DailyTakenProtein(/*_currentUser.ID*/0).ToString();
            label6.Text = foodManager.DailyTakenFat(/*_currentUser.ID*/0).ToString();
            //Öğünlere göre alınan kalori miktarları
            materialLabel29.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Breakfast)?.TotalCalori.ToString();

            materialLabel30.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Lunch)?.TotalCalori.ToString();

            materialLabel31.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Dinner)?.TotalCalori.ToString();

            materialLabel32.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Snack)?.TotalCalori.ToString();

            //Toplam alınan kalori miktarı(öğün toplamı)
            materialLabel27.Text = (foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Breakfast)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Lunch)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Dinner)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Snack)?.TotalCalori).ToString();
        }

        private void mfabKahvaltıEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel5.Text;
            Form5 form5 = new Form5(ogun,Model.MealType.Breakfast,_currentUser);
            form5.ShowDialog();
        }

        private void mfabOgleYemegiEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel6.Text;
            Form5 form5 = new Form5(ogun,MealType.Lunch,_currentUser);
            form5.ShowDialog();
        }

        private void mfabAksamYemegiEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel7.Text;
            Form5 form5 = new Form5(ogun,MealType.Dinner,_currentUser);
            form5.ShowDialog();
        }

        private void mfabAtıstırmalıkEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel8.Text;
            Form5 form5 = new Form5(ogun,MealType.Snack,_currentUser);
            form5.ShowDialog();
        }
    }
}
