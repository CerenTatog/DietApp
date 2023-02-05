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
using Diet.BLL.Helper;
using Diet.Model.Dto;

namespace Diet.UI
{
    public partial class Form2 : MaterialForm
    {
        UnitOfWork db = new UnitOfWork();
        User newuser = new User();
        UserDetail newuserdetail = new UserDetail();

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
            List<ActivityStatus> activityStatusList = Enum.GetValues(typeof(ActivityStatus)).Cast<ActivityStatus>().ToList();
            List<CustomSelectItem> activityTypeList = activityStatusList.Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbActivityStatus.DataSource = activityTypeList;
            cmbActivityStatus.DisplayMember = "Label";
            cmbActivityStatus.ValueMember = "Value";

            List<Gender> genderList = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            List<CustomSelectItem> genderTypeList = genderList.Select(x => new CustomSelectItem
            {
                Label = x.GetEnumDisplayName(),
                Value = (int)x
            }).ToList();
            cmbGender.DataSource = genderTypeList;
            cmbGender.DisplayMember = "Label";
            cmbGender.ValueMember = "Value";
        }

        private void btnIlerle_Click(object sender, EventArgs e)
        {
            // uniq
            newuser.UserName = txtKullaniciAdi.Text.Trim();
            newuser.UserSurname = txtSoyad.Text.Trim();
            materialTabControl1.SelectedTab = tabPage2;

        }

        private void btnIlerle2_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.CheckEmailFormat() == true)
            {
                var query = db.UserRepository.GetAll().Count(x => x.Email == txtEmail.Text);
                if (query == 0)
                {
                    newuser.Email = txtEmail.Text.Trim();
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
            if (txtSifre.Text.Trim() == txtTekrarSifre.Text.Trim())
            {
                if (txtSifre.Text.IsValidPassword() == true)
                {
                    newuser.Password = txtSifre.Text.EncryptoPassword();
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
            newuserdetail.Height = Convert.ToDouble(nmrBoy.Value);
            newuserdetail.Weight = Convert.ToDouble(nmrKilo.Value);
            newuserdetail.TargetWeight = Convert.ToInt32(nmrHedefKilo.Value);
            materialTabControl1.SelectedTab = tabPage5;
        }

        private void btnGeri4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage3;
        }

        private void btnKaydetBitir_Click(object sender, EventArgs e)
        {
            newuserdetail.Age = Convert.ToInt32(nmrYas.Value);
            newuserdetail.ActivityStatus = (ActivityStatus)cmbActivityStatus.SelectedValue;
            newuserdetail.Gender = (Gender)cmbGender.SelectedValue;
            newuser.CreatedDate = DateTime.Now;
            db.UserRepository.Create(newuser);
            newuserdetail.UserID = newuser.ID;
            newuserdetail.CreatedDate = DateTime.Now;
            db.UserDetailRepository.Create(newuserdetail);

            UserBC userBC = new UserBC();
            userBC.UserID = newuser.ID;
            userBC.MeasuredDate = DateTime.Now;
            userBC.ActivityStatus = newuserdetail.ActivityStatus;
            userBC.Weight = newuserdetail.Weight;
            userBC.Height = newuserdetail.Height;
            db.UserBcRepository.Create(userBC);

            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void btnGeri5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage4;
        }


        private void materialLabel7_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
