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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.Amber400, Accent.Red100, TextShade.WHITE);
            
           
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
            dataGridViewKullaniciListesi.DataSource = query.ToList();

           
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Karbonhidrat,Yağ, Protein gösterim alanı
            mlKarbonhidratg.Text = foodManager.DailyTakenCarbonhyrate(/*_currentUser.ID*/0).ToString();
            mlProteing.Text = foodManager.DailyTakenProtein(/*_currentUser.ID*/0).ToString();
            mlYagg.Text = foodManager.DailyTakenFat(/*_currentUser.ID*/0).ToString();
            
            //Öğünlere göre alınan kalori miktarları
            mlKahvaltıKalori.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Breakfast)?.TotalCalori.ToString();

            mlOgleYemegiCalori.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Lunch)?.TotalCalori.ToString();

            mlAksamYemegiKalori.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Dinner)?.TotalCalori.ToString();

            mlAtistirmalikKalori.Text = foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Snack)?.TotalCalori.ToString();

            //Toplam alınan kalori miktarı(öğün toplamı)
            mlToplamAlinanKalori.Text = (foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Breakfast)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Lunch)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Dinner)?.TotalCalori + foodManager.CalculateCalorieIntake(/*_currentUser.ID*/0).FirstOrDefault(x => x.MealType == MealType.Snack)?.TotalCalori).ToString();

            //Kullanıcı Bilgileri /Profil
            int yas = db.UserDetailRepository.GetAll().Select(x=>x.Age).FirstOrDefault();
            lblUserYas.Text = yas.ToString();
            mlKalanKalorid.Text = foodManager.CalculateDailyCalorie(/*_currentUser.ID*/0).ToString();
            mmlKilo.Text = mlKalanKalorid.Text;
            double mevcutKilo = db.UserDetailRepository.GetAll().Select(x => x.Weight).FirstOrDefault();
            lblMevcutKilo.Text = mevcutKilo.ToString();
            mlHedefKilo.Text = (mevcutKilo - 5).ToString();
            

            //Kullanıcı Listesi -Sistem Raporları
            //var query = from u in db.UserRepository.GetAll()
            //            select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            //dataGridViewKullaniciListesi.DataSource = query.ToList();
            //dataGridView1.DataSource= 



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

        
        private void UrunEkle_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
            

        }
        //userıd
        private void mlAktiviteDuzenle_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
         
        }

        private void materialLabel15_Click(object sender, EventArgs e)
        {

        }

        private void mlHedefDuzenle_Click(object sender, EventArgs e)//bu alan değişecek. 
        {
            if (mlHedefDuzenle.Text == "Düzenle")
            {
                mlHedefDuzenle.Text = "Kaydet";
                mmlBeslenme.ReadOnly = false;
                mmlHedef.ReadOnly = false;
                mmlKalori.ReadOnly = false;
                mmlAdim.ReadOnly = false;
                mmlHedef.ReadOnly = false;
            }
            else if (mlHedefDuzenle.Text == "Kaydet")
            {
                mlHedefDuzenle.Text = "Düzenle";
                mmlBeslenme.ReadOnly = true;
                mmlHedef.ReadOnly = true;
                mmlKalori.ReadOnly = true;
                mmlAdim.ReadOnly = true;
                mmlHedef.ReadOnly = true;
            }
        }

        private void mfabSuEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber100, Primary.Blue900, Primary.Amber400, Accent.Red100, TextShade.WHITE);

        }

        private void materialFloatingActionButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;
        }

        private void mfabAdımSayisiEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
