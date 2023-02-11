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
using Diet.BLL.Helper;
using Diet.DAL.Entities;
using Diet.DAL.GenericRepository;
using Diet.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Diet.UI
{
    public partial class Form1 : MaterialForm
    {
        
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);

        }

        UnitOfWork db = new UnitOfWork();


        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var user = db.UserRepository.GetAll().Where(u => u.Email == txtKullaniciAdi.Text).FirstOrDefault();
            if (txtKullaniciAdi.Text.Trim() == "admin" && txtSifre.Text.Trim() == "admin")
            {
                Form4 frm4 = new Form4(user);
                frm4.Show();
                Hide();
            }
            else if (user != null)
            {
                if (user.Password.Trim() == txtSifre.Text.EncryptoPassword())
                {
                    
                    Form3 frm3 = new Form3(user);
                    frm3.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Kontrol Et");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını Kontrol Ediniz");
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

        

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.CheckState==CheckState.Checked)
            {
               
                txtSifre.UseSystemPasswordChar = false;
                chkPassword.Text = "Şifreyi Gizle";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                chkPassword.Text = "Şifreyi Göster";
            }
        }
    }
}
