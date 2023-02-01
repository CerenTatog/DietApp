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
                    Form2 frm2 = new Form2();
                    frm2.Show();
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

       
    }
}
