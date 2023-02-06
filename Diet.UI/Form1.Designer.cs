namespace Diet.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGirisYap = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnUyelikOlustur = new MaterialSkin.Controls.MaterialButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkPassword = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.HideSelection = true;
            this.txtKullaniciAdi.Hint = "Kullanıcı Adı";
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(15, 241);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PrefixSuffixText = null;
            this.txtKullaniciAdi.ReadOnly = false;
            this.txtKullaniciAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(305, 48);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.TrailingIcon = null;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AutoSize = false;
            this.btnGirisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGirisYap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGirisYap.Depth = 0;
            this.btnGirisYap.HighEmphasis = true;
            this.btnGirisYap.Icon = null;
            this.btnGirisYap.Location = new System.Drawing.Point(182, 411);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGirisYap.Size = new System.Drawing.Size(138, 36);
            this.btnGirisYap.TabIndex = 1;
            this.btnGirisYap.Text = "      Giriş Yap     ";
            this.btnGirisYap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGirisYap.UseAccentColor = false;
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.HideSelection = true;
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(15, 303);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PrefixSuffixText = null;
            this.txtSifre.ReadOnly = false;
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(305, 48);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // btnUyelikOlustur
            // 
            this.btnUyelikOlustur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUyelikOlustur.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUyelikOlustur.Depth = 0;
            this.btnUyelikOlustur.HighEmphasis = true;
            this.btnUyelikOlustur.Icon = null;
            this.btnUyelikOlustur.Location = new System.Drawing.Point(17, 411);
            this.btnUyelikOlustur.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUyelikOlustur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUyelikOlustur.Name = "btnUyelikOlustur";
            this.btnUyelikOlustur.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUyelikOlustur.Size = new System.Drawing.Size(138, 36);
            this.btnUyelikOlustur.TabIndex = 1;
            this.btnUyelikOlustur.Text = "Üyelik Oluştur";
            this.btnUyelikOlustur.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUyelikOlustur.UseAccentColor = false;
            this.btnUyelikOlustur.UseVisualStyleBackColor = true;
            this.btnUyelikOlustur.Click += new System.EventHandler(this.btnUyelikOlustur_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "not-visible.png");
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Depth = 0;
            this.chkPassword.Location = new System.Drawing.Point(213, 353);
            this.chkPassword.Margin = new System.Windows.Forms.Padding(0);
            this.chkPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.ReadOnly = false;
            this.chkPassword.Ripple = true;
            this.chkPassword.Size = new System.Drawing.Size(107, 37);
            this.chkPassword.TabIndex = 6;
            this.chkPassword.Text = "Şifre Gizle";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.chkPassword);
            this.materialCard1.Controls.Add(this.btnGirisYap);
            this.materialCard1.Controls.Add(this.txtKullaniciAdi);
            this.materialCard1.Controls.Add(this.txtSifre);
            this.materialCard1.Controls.Add(this.btnUyelikOlustur);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(53, 185);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(343, 485);
            this.materialCard1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Diet.UI.Properties.Resources.logomuzkare;
            this.pictureBox1.Location = new System.Drawing.Point(165, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diet.UI.Properties.Resources.boy__1_;
            this.pictureBox2.Location = new System.Drawing.Point(97, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialCard1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Kullanıcı Girişi    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtKullaniciAdi;
        private MaterialSkin.Controls.MaterialButton btnGirisYap;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialButton btnUyelikOlustur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList ımageList1;
        private MaterialSkin.Controls.MaterialCheckbox chkPassword;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}

