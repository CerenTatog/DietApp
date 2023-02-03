using MaterialSkin.Controls;
using MaterialSkin;
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
using Diet.BLL;

namespace Diet.UI
{
    public partial class Form2 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
        User newuser = new User();
        UserDetail newuserdetail = new UserDetail();
        UserManager um = new UserManager();

        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //var query = (from ud in db.UserDetailRepository.GetAll()
            //            select new {ud.ActivityStatus}).ToList();

            List<string> activityStatuses = new List<string>();
            activityStatuses.Add(ActivityStatus.NonActive.ToString());
            activityStatuses.Add(ActivityStatus.MidActive.ToString());
            activityStatuses.Add(ActivityStatus.Active.ToString());
            activityStatuses.Add(ActivityStatus.FullActive.ToString());
            foreach (var item in activityStatuses)
            {
                cmbActivityStatus.Items.Add(item);
               
            }
            List<string> gender = new List<string>();
            gender.Add(Gender.Women.ToString());
            gender.Add(Gender.Men.ToString());
            foreach (var item in gender)
            {
                cmbGender.Items.Add(item);
            }
            //cmbActivityStatus.DisplayMember = "Label";
            //cmbActivityStatus.ValueMember = "Value";

        }

        private void btnIlerle_Click(object sender, EventArgs e)
        {
            // uniq
            newuser.UserName = txtKullaniciAdi.Text;
            newuser.UserSurname = txtSoyad.Text;
            materialTabControl1.SelectedTab = tabPage2;

        }

        private void btnIlerle2_Click(object sender, EventArgs e)
        {
            if (um.CheckEmailFormat(txtEmail.Text) == true)
            {
                var query = db.UserRepository.GetAll().Count(x => x.Email == txtEmail.Text);
                if (query==0)
                {
                    newuser.Email = txtEmail.Text;
                    materialTabControl1.SelectedTab = tabPage3;
                }
                else
                {
                    MessageBox.Show("Bu mail adresi ile giriş yapılmış");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen .com lu bir mail adresi giriniz");
            }

        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage1;
        }

        private void btnIlerle3_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtTekrarSifre.Text)
            {
                if (um.IsValidPassword(txtSifre.Text) == true)
                {
                    newuser.Password = um.EncryptoPassword(txtSifre.Text);
                    materialTabControl1.SelectedTab = tabPage4;
                }
                else
                {
                    MessageBox.Show("Şifreleme kurallarına uyunuz!");
                }
            }
            else
            {
                MessageBox.Show("Şifrelerinizin aynı olduğundan emin olunuz!");
            }
        }

        private void btnGeri3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage2;
        }

        private void btnIler4_Click(object sender, EventArgs e)
        {
            newuserdetail.Height = Convert.ToDouble(txtBoy.Text);
            newuserdetail.Weight = Convert.ToDouble(txtKilo.Text);
            //newuserdetail. =Convert.ToDouble( txtBoy.Text); //Hedef kilonun veritabanında işlenmesi gerek.
            materialTabControl1.SelectedTab = tabPage5;
        }

        private void btnGeri4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage3;
        }

        private void btnKaydetBitir_Click(object sender, EventArgs e)
        {

            newuserdetail.Age = Convert.ToInt32(txtAge.Text);
            newuserdetail.ActivityStatus = (ActivityStatus)cmbActivityStatus.SelectedValue; //ActivityStatus Enum olarak var İnt Diet.Model.Activitystatus türüne dönüşemez uyarısı.

            db.UserRepository.Create(newuser);
            db.UserDetailRepository.Create(newuserdetail);
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void btnGeri5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage4;
        }
    }
}
