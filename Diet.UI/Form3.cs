using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Diet.BLL;
using Diet.BLL.Helper;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto.Report;
using LiveCharts;
using LiveCharts.Wpf;
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
        UserManager userManager = new UserManager();

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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700, Primary.BlueGrey600, Accent.LightBlue400, TextShade.WHITE);
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

            double dailyToplam= Math.Abs((toplamAlınanKalori - toplamVerilenKalori));
            ////farkıyla alakalı bir gösterim.
            mlKalanKalorid.Text = (foodManager.CalculateDailyCalorie(_currentUser.ID) - (toplamAlınanKalori - toplamVerilenKalori)).ToString();

            //Kullanıcı Bilgileri /Profil
            int yas = db.UserDetailRepository.GetAll().Select(x => x.Age).FirstOrDefault();
            lblUserYas.Text = yas.ToString();
           
            //mmlKilo.Text = mlKalanKalorid.Text;
            double mevcutKilo = db.UserDetailRepository.GetAll().Select(x => x.Weight).FirstOrDefault();
            lblMevcutKilo.Text = mevcutKilo.ToString();
            mlHedefKilo.Text = (mevcutKilo - (db.UserDetailRepository.GetById(_currentUser.ID).TargetWeight)).ToString();

            //Water
            lblWaterTotal.Text = $"{userManager.GetDailyWater(_currentUser.ID)} ml";
            //pictureBox2.Image = db.UserDetailRepository.GetAll().Where(x => x.UserID == _currentUser.ID &&x.Gender == Gender.Men).First ? Diet.UI.Properties.Resources.boy : Diet.UI.Properties.Resources.woman__3_;
            
            solidGauge1.From = 0;
            solidGauge1.To = dailyToplam;
            solidGauge1.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            solidGauge1.Base.GaugeActiveFill = new System.Windows.Media.LinearGradientBrush
            {
                GradientStops = new System.Windows.Media.GradientStopCollection

                { 
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Blue,0),
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Yellow,.5),
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Green,1),
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Red,1.1),
                   
                }

            };
            lblkarsilamaMesaji.Text = $"Hoşgeldin {_currentUser.UserName}";

            //pictureBox1.Image = Diet.UI.Properties.Resources.fried_rice;

            //Kullanıcı raporları

            //dataGridView2.DataSource = reportManager.WeeklyMacroFood(_currentUser.ID);
            //dataGridView3.DataSource = reportManager.WeeklyDrinkingWater(_currentUser.ID);
            //dataGridView4.DataSource = reportManager.CalculateActivity(_currentUser.ID);
            //dataGridView6.DataSource = reportManager.CalculateWeight(_currentUser.ID);

            //Çalışmıyor?
            //var data1 = reportManager.CalculateWeeklyCalorie(_currentUser.ID);
            //ColumnSeries series5 = new ColumnSeries()
            //{
            //    DataLabels = true,
            //    Values = new ChartValues<double>(),
            //    LabelPoint = point => point.Y.ToString()
            //};
            //Axis axisX = new Axis()
            //{
            //    Separator = new Separator() { Step = 1, IsEnabled = false },
            //    Labels = new List<string>()

            //};
            //Axis axisY = new Axis()
            //{
            //    LabelFormatter = y => y.ToString("C"),
            //    Separator = new Separator()
            //};
            //cartesianChart1.Series.Add(series5);
            //cartesianChart1.AxisX.Add(axisX);
            //cartesianChart1.AxisY.Add(axisY);
            //foreach (var item in data1)
            //{
            //    series5.Values.Add(item.Date);
            //    axisX.Labels.Add(item.Calori.ToString());
            //    
            //}



            //dataGridView11.DataSource = reportManager.MostEatenFood(_currentUser.ID);


            //günlük sayfası => gelen kullanıcıya göre isim alanı değişecek.
            //profil sayfası gelen kullanıcının cinsiyetine göre resim değişecek.
            //günlük sayfası => karbonhidrat/protein/yağ güncellenecek.
            //günlük sayfası=>su alanı bağlanacak. 

            //Pie Chart
            Func<ChartPoint, string> fu = x => string.Format("{0},{1:P}", x.Y, x.Participation);
        SeriesCollection series = new SeriesCollection();
            foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Breakfast))
            {
                PieSeries pie = new PieSeries();
        pie.Title = item.FoodName;
                pie.Values = new ChartValues<double> { item.TotalQuantity
    };
    pie.DataLabels = true;
                pie.LabelPoint = fu;
                series.Add(pie);
                pieChart1.Series = series;
            }
pieChart1.LegendLocation = LegendLocation.Right;

Func<ChartPoint, string> fu2 = x => string.Format("{0},{1:P}", x.Y, x.Participation);
SeriesCollection series2 = new SeriesCollection();
foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Lunch))
{
    PieSeries pie2 = new PieSeries();
    pie2.Title = item.FoodName;
    pie2.Values = new ChartValues<double> { item.TotalQuantity };
    pie2.DataLabels = true;
    pie2.LabelPoint = fu2;
    series2.Add(pie2);
    pieChart2.Series = series2;
}
pieChart2.LegendLocation = LegendLocation.Right;

Func<ChartPoint, string> fu3 = x => string.Format("{0},{1:P}", x.Y, x.Participation);
SeriesCollection series3 = new SeriesCollection();
foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Dinner))
{
    PieSeries pie3 = new PieSeries();
    pie3.Title = item.FoodName;
    pie3.Values = new ChartValues<double> { item.TotalQuantity };
    pie3.DataLabels = true;
    pie3.LabelPoint = fu3;
    series3.Add(pie3);
    pieChart3.Series = series3;
}
pieChart3.LegendLocation = LegendLocation.Right;

Func<ChartPoint, string> fu4 = x => string.Format("{0},{1:P}", x.Y, x.Participation);
SeriesCollection series4 = new SeriesCollection();
foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Snack))
{
    PieSeries pie4 = new PieSeries();
    pie4.Title = item.FoodName;
    pie4.Values = new ChartValues<double> { item.TotalQuantity };
    pie4.DataLabels = true;
    pie4.LabelPoint = fu4;
    series4.Add(pie4);
    pieChart4.Series = series4;
}
pieChart4.LegendLocation = LegendLocation.Right;


            //List<MostEatenFoods> mef =  reportManager.MostEatenFood(_currentUser.ID);
            //materialListBox1.Items.Add(new MaterialListBoxItem
            //{
            //    SecondaryText = "",
            //    Tag = mef.Foo,
            //    Text = $"{mef.} {yeniOgun.Quantity} {food.Portion.GetEnumDisplayName()} Kalori:{food.Calorie * (yeniOgun.Quantity / food.PortionQuantity)}"
            //});


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
    form5.FormClosing += Form5_FormClosing;
    form5.ShowDialog();
}

private void Form5_FormClosing(object sender, FormClosingEventArgs e)
{
    Form3_Load(sender, e);
}

private void mfabAksamYemegiEkle_Click(object sender, EventArgs e)
{
    string ogun = materialLabel7.Text;
    Form5 form5 = new Form5(ogun, MealType.Dinner, _currentUser);
    form5.FormClosing += Form5_FormClosing;
    form5.ShowDialog();
}

private void mfabAtıstırmalıkEkle_Click(object sender, EventArgs e)
{
    string ogun = materialLabel8.Text;
    Form5 form5 = new Form5(ogun, MealType.Snack, _currentUser);
    form5.ShowDialog();
}



private void materialLabel15_Click(object sender, EventArgs e)
{

}

private void mlHedefDuzenle_Click(object sender, EventArgs e)//bu alan değişecek. 
{

}

private void mfabSuEkle_Click(object sender, EventArgs e)
{
    double currentWater = userManager.AddDailyWater(_currentUser.ID);
    lblWaterTotal.Text = $"{currentWater} ml";

}

private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
{


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
    form7.FormClosing += Form7_FormClosing;
    form7.ShowDialog();
}

private void Form7_FormClosing(object sender, FormClosingEventArgs e)
{
    Form3_Load(sender, e);
}

private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}

private void materialButton1_Click(object sender, EventArgs e)
{
    Form11 frm11 = new Form11();
    frm11.Show();
    Hide();
}

private void materialFloatingActionButton1_Click(object sender, EventArgs e)
{
    double currentWater = userManager.RemoveDailyWater(_currentUser.ID);
    lblWaterTotal.Text = $"{currentWater} ml";
}
    }
}
