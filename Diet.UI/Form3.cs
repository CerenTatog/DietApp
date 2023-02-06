using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;
using Diet.BLL;
using Diet.BLL.Helper;
using Diet.DAL.GenericRepository;
using Diet.Model;
using Diet.Model.Dto;
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
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //ımageList1.Images.Add
            //Karbonhidrat,Yağ, Protein gösterim alanı
            mlKarbonhidratg.Text = foodManager.DailyTakenCarbonhyrate(_currentUser.ID).ToString();
            mlProteing.Text = foodManager.DailyTakenProtein(_currentUser.ID).ToString();
            mlYagg.Text = foodManager.DailyTakenFat(_currentUser.ID).ToString();

            //Öğünlere göre alınan kalori miktarları
            var calculateCalorieIntake = foodManager.CalculateCalorieIntake(_currentUser.ID);
            mlKahvaltıKalori.Text = (Math.Round((calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Breakfast).TotalCalori),2)).ToString();

            mlOgleYemegiCalori.Text = (Math.Round((calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Lunch).TotalCalori), 2)).ToString();

            mlAksamYemegiKalori.Text = (Math.Round((calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Dinner).TotalCalori), 2)).ToString();

            mlAtistirmalikKalori.Text = (Math.Round((calculateCalorieIntake.FirstOrDefault(x => x.MealType == MealType.Snack).TotalCalori), 2)).ToString();
            //Gender

            var userDetail = db.UserDetailRepository.GetAll().FirstOrDefault(x => x.UserID == _currentUser.ID);
            if (userDetail != null && userDetail.Gender == Gender.Men)
            {
                pictureBox2.Image = Diet.UI.Properties.Resources.boy;
            }
            else if(userDetail != null && userDetail.Gender == Gender.Women)
            {
                pictureBox2.Image = Diet.UI.Properties.Resources.woman__3_;
            }

            //günlük sayfası => karbonhidrat/protein/yağ güncellenecek.
            mlSabahKarb.Text = reportManager.CalculateDailyCarbByMealType(_currentUser.ID, MealType.Breakfast).ToString();
            mlSabahProtein.Text = reportManager.CalculateDailyProteinByMealType(_currentUser.ID, MealType.Breakfast).ToString();
            mlSabahYag.Text = reportManager.CalculateDailyFatByMealType(_currentUser.ID, MealType.Breakfast).ToString();

            mlOgleKarb.Text = reportManager.CalculateDailyCarbByMealType(_currentUser.ID, MealType.Lunch).ToString();
            mlOgleProtein.Text = reportManager.CalculateDailyProteinByMealType(_currentUser.ID, MealType.Lunch).ToString();
            mlOgleYag.Text = reportManager.CalculateDailyFatByMealType(_currentUser.ID, MealType.Lunch).ToString();

            mlAksamKarb.Text = reportManager.CalculateDailyCarbByMealType(_currentUser.ID, MealType.Dinner).ToString();
            mlAksamProtein.Text = reportManager.CalculateDailyProteinByMealType(_currentUser.ID, MealType.Dinner).ToString();
            mlAksamYag.Text = reportManager.CalculateDailyFatByMealType(_currentUser.ID, MealType.Dinner).ToString();

            mlAtistirmalıkKarb.Text = reportManager.CalculateDailyCarbByMealType(_currentUser.ID, MealType.Snack).ToString();
            mlAtistirmalıkProtein.Text = reportManager.CalculateDailyProteinByMealType(_currentUser.ID, MealType.Snack).ToString();
            mlAtistirmalıkYag.Text = reportManager.CalculateDailyFatByMealType(_currentUser.ID, MealType.Snack).ToString();



            //Toplam alınan kalori miktarı(öğün toplamı)
            double toplamAlınanKalori = calculateCalorieIntake.Sum(x => x.TotalCalori);
            mlToplamAlinanKalori.Text = toplamAlınanKalori.ToString();


            var dailyCalculateConsumedCalorieByActivity = activityManager.CalculateConsumedCalorieByActivity(_currentUser.ID);
            var dailyCalculateConsumedCalorieByStep = activityManager.CalculateConsumedCalorieByStep(_currentUser.ID);
            //Harcanan kalori
            lblAdımSayisi.Text = activityManager.CalculateStepCountByUserId(_currentUser.ID).ToString();//form6'dan veri gelecek.
            lblAktivite.Text = dailyCalculateConsumedCalorieByActivity.ToString();

            //Harcanan Toplam Kalori
            double toplamVerilenKalori = dailyCalculateConsumedCalorieByActivity + dailyCalculateConsumedCalorieByStep;
            lblHarcananToplamKalori.Text = toplamVerilenKalori.ToString();

            //Günlük Toplam Kalori

            double dailyToplam = Math.Abs((toplamAlınanKalori - toplamVerilenKalori));
            ////farkıyla alakalı bir gösterim.
            mlKalanKalorid.Text = (foodManager.CalculateDailyCalorie(_currentUser.ID) - (toplamAlınanKalori - toplamVerilenKalori)).ToString();

            //Kullanıcı Bilgileri /Profil
            int yas = db.UserDetailRepository.GetAll().Select(x => x.Age).FirstOrDefault();
            lblUserYas.Text = yas.ToString();

            //mmlKilo.Text = mlKalanKalorid.Text;
            double mevcutKilo = db.UserDetailRepository.GetAll().Select(x => x.Weight).FirstOrDefault();
            lblMevcutKilo.Text = mevcutKilo.ToString();
            //?
            double hedefkilo = db.UserDetailRepository.GetAll().Where(x=>x.UserID == _currentUser.ID).Select(x => x.TargetWeight).FirstOrDefault();
            if (hedefkilo > mevcutKilo)
            {
                lblHedef.Text = "Kilo Almak";
            }
            else if (hedefkilo < mevcutKilo)
            {
                lblHedef.Text = "Kilo Vermek";
            }
            else
            {
                lblHedef.Text = "Kilo Kontrolü";
            }
            



            //mlHedefKilo.Text = (mevcutKilo - (db.UserDetailRepository.GetById(_currentUser.ID).TargetWeight)).ToString();
            lblMevcutKilo.Text = db.UserDetailRepository.GetAll().Where(x => x.UserID== _currentUser.ID).Select(x => x.Weight).FirstOrDefault().ToString();
            mlAdimProfild.Text = lblAdımSayisi.Text;
            
            lblWaterTotal.Text = $"{userManager.GetDailyWater(_currentUser.ID)} ml";
            

            solidGauge1.From = 0;
            solidGauge1.To = foodManager.CalculateDailyCalorie(_currentUser.ID);
            solidGauge1.Value = Math.Round(dailyToplam,2);
            solidGauge1.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            solidGauge1.ForeColor = System.Drawing.Color.White;
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
            lblkarsilamaMesaji.Text = $"Hoşgeldin, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_currentUser.UserName)}";



            //Makro Besin chart;
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            var weeklyMacroFood = reportManager.WeeklyMacroFood(_currentUser.ID);
            double[] protein = reportManager.WeeklyMacroFood(_currentUser.ID).Select(x => x.Protein).ToArray();
            double[] carb = reportManager.WeeklyMacroFood(_currentUser.ID).Select(x => x.Carb).ToArray();
            double[] fat = reportManager.WeeklyMacroFood(_currentUser.ID).Select(x => x.Fat).ToArray();
            cartesianChart2.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Protein",
                    Values = new ChartValues<double>(protein)
                }
            };

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = "Karbonhidrat",
                Values = new ChartValues<double>(carb)
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = "Yağ",
                Values = new ChartValues<double>(fat)
            });

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "",
                Labels = weeklyMacroFood.Select(x => x.Date.ToString("dd/MM/yyyy")).ToList(),
            });

            //Günlük Alınan Kalori Chart
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

            var data1 = reportManager.CalculateWeeklyCalorie(_currentUser.ID);
            ColumnSeries series5 = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<double>(),
                LabelPoint = point => point.Y.ToString(),
                Title = "Kalori",
                Fill = System.Windows.Media.Brushes.DarkGoldenrod
                
            };
            Axis axisX = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = new List<string>()

            };
            Axis axisY = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                //Separator = new Separator()
            };
            cartesianChart1.Series.Add(series5);
            cartesianChart1.AxisX.Add(axisX);
            cartesianChart1.AxisY.Add(axisY);

            foreach (var item in data1)
            {
                series5.Values.Add(item.Calori);
                axisX.Labels.Add(item.Date.ToString("dd/MM/yyyy"));
            }

            //Günlük Su Tüketimi 

            cartesianChart3.Series.Clear();
            cartesianChart3.AxisX.Clear();
            cartesianChart3.AxisY.Clear();

            var data2 = reportManager.WeeklyDrinkingWater(_currentUser.ID);
            ColumnSeries series6 = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<double>(),
                LabelPoint = point => point.Y.ToString(),
                Title = "Su(ml)",
                Fill = System.Windows.Media.Brushes.BlueViolet
            };
            Axis axisX2 = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = new List<string>()

            };
            Axis axisY2 = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                //Separator = new Separator()
            };
            cartesianChart3.Series.Add(series6);
            cartesianChart3.AxisX.Add(axisX2);
            cartesianChart3.AxisY.Add(axisY2);

            foreach (var item in data2)
            {
                series6.Values.Add(item.Water);
                axisX2.Labels.Add(item.Date.ToString("dd/MM/yyyy"));
            }

            //Aktivite Kayıtları
            cartesianChart4.Series.Clear();
            cartesianChart4.AxisX.Clear();
            cartesianChart4.AxisY.Clear();

            var data3 = reportManager.CalculateActivity(_currentUser.ID);
            ColumnSeries series7 = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<double>(),
                LabelPoint = point => point.Y.ToString(),
                Title = "Kalori"
            };
            Axis axisX3 = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = new List<string>()

            };
            Axis axisY3 = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                //Separator = new Separator()
            };
            cartesianChart4.Series.Add(series7);
            cartesianChart4.AxisX.Add(axisX3);
            cartesianChart4.AxisY.Add(axisY3);

            foreach (var item in data3)
            {
                series7.Values.Add(item.Activity);
                axisX3.Labels.Add(item.Date.ToString("dd/MM/yyyy"));
            }

            //Günlük Adım Sayısı
            cartesianChart5.Series.Clear();
            cartesianChart5.AxisX.Clear();
            cartesianChart5.AxisY.Clear();

            var data4 = reportManager.CalculateWeeklyStepCount(_currentUser.ID);
            ColumnSeries series8 = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<double>(),
                LabelPoint = point => point.Y.ToString(),
                Title = "Adım",
                Fill = System.Windows.Media.Brushes.DarkOliveGreen
            };
            Axis axisX4 = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = new List<string>()

            };
            Axis axisY4 = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                //Separator = new Separator()
            };
            cartesianChart5.Series.Add(series8);
            cartesianChart5.AxisX.Add(axisX4);
            cartesianChart5.AxisY.Add(axisY4);

            foreach (var item in data4)
            {
                series8.Values.Add(item.Step);
                axisX4.Labels.Add(item.Date.ToString("dd/MM/yyyy"));
            }

            //Kilo Değişimi
            cartesianChart6.Series.Clear();
            cartesianChart6.AxisX.Clear();
            cartesianChart6.AxisY.Clear();

            var data5 = reportManager.CalculateWeight(_currentUser.ID);//bi bak
            LineSeries series9 = new LineSeries()
            {
                DataLabels = true,
                Values = new ChartValues<double>(),
                LabelPoint = point => point.Y.ToString(),
                Title = "Kg",
                Fill = System.Windows.Media.Brushes.DarkSalmon,
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15,
                LineSmoothness = 0,

            };
            Axis axisX5 = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = new List<string>()

            };
            Axis axisY5 = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                //Separator = new Separator()
            };
            cartesianChart6.Series.Add(series9);
            cartesianChart6.AxisX.Add(axisX5);
            cartesianChart6.AxisY.Add(axisY5);

            foreach (var item in data5)
            {
                series9.Values.Add(item.Weight);
                axisX5.Labels.Add(item.Date.ToString("dd/MM/yyyy"));
            }


            

            //Pie Chart
            //Sabah
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
            //pieChart1.LegendLocation = LegendLocation.Right;
            //Oglen
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
            //pieChart2.LegendLocation = LegendLocation.Right;
            //Atıştırmalık
            Func<ChartPoint, string> fu3 = x => string.Format("{0},{1:P}", x.Y, x.Participation);
            SeriesCollection series3 = new SeriesCollection();
            foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Snack))
            {
                PieSeries pie3 = new PieSeries();
                pie3.Title = item.FoodName;
                pie3.Values = new ChartValues<double> { item.TotalQuantity };
                pie3.DataLabels = true;
                pie3.LabelPoint = fu3;
                series3.Add(pie3);
                pieChart3.Series = series3;
            }
            //pieChart3.LegendLocation = LegendLocation.Right;

            //Akşam yemeği
            Func<ChartPoint, string> fu4 = x => string.Format("{0},{1:P}", x.Y, x.Participation);
            
             SeriesCollection series4 = new SeriesCollection();
            foreach (var item in reportManager.WhichFoodsEatenByMealType(_currentUser.ID, MealType.Dinner))
            {
                PieSeries pie4 = new PieSeries();
                pie4.Title = item.FoodName;
                pie4.Values = new ChartValues<double> { item.TotalQuantity };
                pie4.DataLabels = true;
                pie4.LabelPoint = fu4;
                series4.Add(pie4);
                pieChart4.Series = series4;
            }
            //pieChart4.LegendLocation = LegendLocation.Right;


            List<MostEatenFoods> mef = reportManager.MostEatenFood(_currentUser.ID);

            mListBoxMostEaten.Items.Clear();
            foreach (var item in mef)
            {
                mListBoxMostEaten.Items.Add(new MaterialListBoxItem
                {
                    SecondaryText = "",
                    Tag = item,
                    Text = $"{item.CategoryName} grubundan  {item.TotalQuantity} {item.Portion.GetEnumDisplayName()} {item.FoodName} yedin."
                });
            }
            mListBoxMostEaten.Refresh();


            List<ActivityStatus> activityStatusList = Enum.GetValues(typeof(ActivityStatus)).Cast<ActivityStatus>().ToList();
            List<CustomSelectItem> activityTypeList = activityStatusList.Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbAktivite.DataSource = activityTypeList;
            cmbAktivite.DisplayMember = "Label";
            cmbAktivite.ValueMember = "Value";

            List<Gender> genderList = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            List<CustomSelectItem> genderTypeList = genderList.Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbCinsiyet.DataSource = genderTypeList;
            cmbCinsiyet.DisplayMember = "Label";
            cmbCinsiyet.ValueMember = "Value";
            LoadBodyAnalyz();

            if (materialTabControl1.SelectedTab == tabPage10)
            {
                this.Close();
            }
        }

        private void mfabKahvaltıEkle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(MealType.Breakfast, _currentUser);
            form5.FormClosing += Form5_FormClosing;
            form5.ShowDialog();
        }

        private void mfabOgleYemegiEkle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(MealType.Lunch, _currentUser);
            form5.FormClosing += Form5_FormClosing;
            form5.ShowDialog();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void mfabAksamYemegiEkle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(MealType.Dinner, _currentUser);
            form5.FormClosing += Form5_FormClosing;
            form5.ShowDialog();
        }

        private void mfabAtıstırmalıkEkle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(MealType.Snack, _currentUser);
            form5.FormClosing += Form5_FormClosing;
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
            form6.FormClosing += Form6_FormClosing;
            form6.ShowDialog();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3_Load(sender, e);
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

        private void btnChangePasword_Click(object sender, EventArgs e)
        {

            if (txtOldPassword.Text.EncryptoPassword() == _currentUser.Password)
            {
                if (txtNewPassword.Text.Trim() == txtNewPasswordAgain.Text.Trim())
                {

                    _currentUser.Password = txtNewPassword.Text.EncryptoPassword();
                    db.UserRepository.Update(_currentUser);

                }
            }
            else
            {
                MessageBox.Show("Şifrenizi hatalı girdiniz");
            }
        }

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = db.UserDetailRepository.GetAll().FirstOrDefault(x => x.UserID == _currentUser.ID);
            userDetail.Height = Convert.ToInt32(nmrBoy.Value);
            userDetail.Weight = Convert.ToInt32(nmrKilo.Value);
            userDetail.Age = Convert.ToInt32(cmbYas.Value);
            userDetail.Gender = (Gender)cmbCinsiyet.SelectedValue;
            userDetail.ActivityStatus = (ActivityStatus)cmbAktivite.SelectedValue;
            db.UserDetailRepository.Update(userDetail);

            var dateToday = DateTime.Today;
            var dateEnd = DateTime.Today.AddDays(1).AddSeconds(-1);

            var userBC = db.UserBcRepository.GetAll().Where(x => x.MeasuredDate >= dateToday && x.MeasuredDate < dateEnd && x.UserID == _currentUser.ID).FirstOrDefault();
            if (userBC != null)
            {
                userBC.MeasuredDate = DateTime.Now;
                userBC.ActivityStatus = userDetail.ActivityStatus;
                userBC.Weight = userDetail.Weight;
                userBC.Height = userDetail.Height;
                db.UserBcRepository.Update(userBC);
            }
            else
            {
                userBC = new UserBC();
                userBC.UserID = _currentUser.ID;
                userBC.MeasuredDate = DateTime.Now;
                userBC.ActivityStatus = userDetail.ActivityStatus;
                userBC.Weight = userDetail.Weight;
                userBC.Height = userDetail.Height;
                db.UserBcRepository.Create(userBC);
            }

            LoadBodyAnalyz();
        }
        void LoadBodyAnalyz()
        {
            var query = from a in db.UserBcRepository.GetAll().Where(x => x.UserID == _currentUser.ID)
                        select new
                        {
                            a.Height,
                            a.Weight,
                            a.ActivityStatus
                        };
            dataGridView1.DataSource = query.ToList();


        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {

        }
    }
}
