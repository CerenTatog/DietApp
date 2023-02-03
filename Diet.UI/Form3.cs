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
        ActivityManager activityManager = new ActivityManager();
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

            //var query = from u in db.UserRepository.GetAll()
            //            select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            //dataGridViewKullaniciListesi.DataSource = query.ToList();




        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Karbonhidrat,Yağ, Protein gösterim alanı
            mlKarbonhidratg.Text = foodManager.DailyTakenCarbonhyrate(_currentUser.ID).ToString();
            mlProteing.Text = foodManager.DailyTakenProtein(_currentUser.ID).ToString();
            mlYagg.Text = foodManager.DailyTakenFat(_currentUser.ID).ToString();

            //Öğünlere göre alınan kalori miktarları
            var calculateCalorieIntake = foodManager.CalculateCalorieIntake(_currentUser.ID);
            mlKahvaltıKalori.Text = calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Breakfast)?.TotalCalori.ToString();

            mlOgleYemegiCalori.Text = calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Lunch)?.TotalCalori.ToString();

            mlAksamYemegiKalori.Text = calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Dinner)?.TotalCalori.ToString();

            mlAtistirmalikKalori.Text = calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Snack)?.TotalCalori.ToString();

            //Toplam alınan kalori miktarı(öğün toplamı)
            double toplamAlınanKalori = calculateCalorieIntake.Sum(x => x.TotalCalori);
            //mlToplamAlinanKalori.Text = toplamAlınanKalori.ToString();


            var dailyCalculateConsumedCalorieByActivity = activityManager.CalculateConsumedCalorieByActivity(_currentUser.ID);
            var dailyCalculateConsumedCalorieByStep = activityManager.CalculateConsumedCalorieByStep(_currentUser.ID);
            //Harcanan kalori
            lblAdımSayisi.Text = activityManager.CalculateStepCountByUserId(_currentUser.ID).ToString();//form6'dan veri gelecek.
            lblAktivite.Text = dailyCalculateConsumedCalorieByActivity.ToString();
            //Harcanan Toplam Kalori
            double toplamVerilenKalori = dailyCalculateConsumedCalorieByActivity + dailyCalculateConsumedCalorieByStep;
            lblHarcananToplamKalori.Text = toplamVerilenKalori.ToString();

            //Günlük Toplam Kalori

            lblToplamKalori.Text = Math.Abs((toplamAlınanKalori - toplamVerilenKalori)).ToString();
            ////farkıyla alakalı bir gösterim.
            mlKalanKalori.Text = (foodManager.CalculateDailyCalorie(_currentUser.ID) - (toplamAlınanKalori - toplamVerilenKalori)).ToString();

            //Kullanıcı Bilgileri /Profil
            int yas = db.UserDetailRepository.GetAll().Select(x => x.Age).FirstOrDefault();
            lblUserYas.Text = yas.ToString();
            mlKalanKalorid.Text = foodManager.CalculateDailyCalorie(_currentUser.ID).ToString();
            mmlKilo.Text = mlKalanKalorid.Text;
            double mevcutKilo = db.UserDetailRepository.GetAll().Select(x => x.Weight).FirstOrDefault();
            lblMevcutKilo.Text = mevcutKilo.ToString();
            mlHedefKilo.Text = (mevcutKilo - 5).ToString();


            //Kullanıcı Listesi -Sistem Raporları
            var query = from u in db.UserRepository.GetAll()
                        select new { u.UserName, u.UserSurname, u.Email, u.CreatedDate };
            dataGridViewKullaniciListesi.DataSource = query.ToList();
            //dataGridView1.DataSource =;


            //Kullanıcı raporları
            dataGridView1.DataSource = reportManager.CalculateWeeklyCalorie(_currentUser.ID);
            dataGridView2.DataSource = reportManager.WeeklyMacroFood(_currentUser.ID);
            dataGridView3.DataSource = reportManager.WeeklyDrinkingWater(_currentUser.ID);
            dataGridView4.DataSource = reportManager.CalculateActivity(_currentUser.ID);
            //şüpheli - gün filtresi koymadık. hem label hem de liste için activity manager'da method tanımlanması gerekli.
            dataGridView5.DataSource = db.UserActivityRepository.GetAll().Select(x => x.StepCount);
            dataGridView6.DataSource = reportManager.CalculateWeight(_currentUser.ID);
            dataGridView7.DataSource = reportManager.WhichFoodsEatenAtBreakfast(_currentUser.ID);
            dataGridView8.DataSource = reportManager.WhichFoodsEatenAtLunch(_currentUser.ID);
            dataGridView9.DataSource = reportManager.WhichFoodsEatenAtDinner(_currentUser.ID);
            dataGridView10.DataSource = reportManager.WhichFoodsEatenAtSnack(_currentUser.ID);
            //dataGridView11.DataSource = reportManager.MostEatenFood(_currentUser.ID);

        }

        private void mfabKahvaltıEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel5.Text;
            Form5 form5 = new Form5(ogun, Model.MealType.Breakfast, _currentUser);
            form5.ShowDialog();
        }

        private void mfabOgleYemegiEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel6.Text;
            Form5 form5 = new Form5(ogun, MealType.Lunch, _currentUser);
            form5.ShowDialog();
        }

        private void mfabAksamYemegiEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel7.Text;
            Form5 form5 = new Form5(ogun, MealType.Dinner, _currentUser);
            form5.ShowDialog();
        }

        private void mfabAtıstırmalıkEkle_Click(object sender, EventArgs e)
        {
            string ogun = materialLabel8.Text;
            Form5 form5 = new Form5(ogun, MealType.Snack, _currentUser);
            form5.ShowDialog();
        }


        private void UrunEkle_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8(_currentUser);
            frm8.ShowDialog();


        }
        //userıd
        private void mlAktiviteDuzenle_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9(_currentUser);
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
            Form10 frm10 = new Form10(_currentUser);
            frm10.ShowDialog();

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
            Form6 form6 = new Form6(_currentUser);
            form6.ShowDialog();
        }

        private void mfabAktiviteEkle_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(_currentUser);
            form7.ShowDialog();
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
