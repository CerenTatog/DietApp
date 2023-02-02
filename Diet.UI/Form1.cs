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
using Diet.DAL.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form1 : MaterialForm
    {
        UserManager userManager;
        public Form1()
        {
            InitializeComponent();
            userManager = new UserManager();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);
        }
        DietAppContext db = new DietAppContext();
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var user = db.Users.Where(u => u.UserName == txtKullaniciAdi.Text).FirstOrDefault();
            if (user != null)
            {
                if (user.Password == userManager.EncryptoPassword(txtSifre.Text))
                {
                    Form4 frm4 = new Form4();
                    frm4.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Kontrol Et!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
            if (userManager.CheckEmailFormat(txtSifre.Text)==false)
            {
                MessageBox.Show("Lütfen '.com' uzantılı mail adresinizi giriniz");
            }
        }

        private void btnUyelikOlustur_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Hide();
        }
    }
}
