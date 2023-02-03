﻿namespace Diet.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGirisYap = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnUyelikOlustur = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtKullaniciAdi.Location = new System.Drawing.Point(54, 216);
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
            this.txtKullaniciAdi.Size = new System.Drawing.Size(407, 48);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.TrailingIcon = null;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGirisYap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGirisYap.Depth = 0;
            this.btnGirisYap.HighEmphasis = true;
            this.btnGirisYap.Icon = null;
            this.btnGirisYap.Location = new System.Drawing.Point(343, 377);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGirisYap.Size = new System.Drawing.Size(111, 36);
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
            this.txtSifre.Location = new System.Drawing.Point(54, 291);
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
            this.txtSifre.Size = new System.Drawing.Size(407, 48);
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
            this.btnUyelikOlustur.Location = new System.Drawing.Point(54, 489);
            this.btnUyelikOlustur.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUyelikOlustur);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtKullaniciAdi;
        private MaterialSkin.Controls.MaterialButton btnGirisYap;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialButton btnUyelikOlustur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

