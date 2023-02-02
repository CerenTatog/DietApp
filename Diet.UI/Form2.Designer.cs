namespace Diet.UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnIlerle = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.btnIlerle2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox26 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox25 = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox27 = new MaterialSkin.Controls.MaterialTextBox2();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 79);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(798, 461);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnIlerle);
            this.tabPage1.Controls.Add(this.txtSifre);
            this.tabPage1.Controls.Add(this.txtKullaniciAdi);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.No;
            this.tabPage1.ImageKey = "r1.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ad Soyad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnIlerle
            // 
            this.btnIlerle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlerle.BackColor = System.Drawing.Color.Transparent;
            this.btnIlerle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIlerle.Depth = 0;
            this.btnIlerle.HighEmphasis = true;
            this.btnIlerle.Icon = null;
            this.btnIlerle.Location = new System.Drawing.Point(524, 275);
            this.btnIlerle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIlerle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIlerle.Name = "btnIlerle";
            this.btnIlerle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIlerle.Size = new System.Drawing.Size(68, 36);
            this.btnIlerle.TabIndex = 3;
            this.btnIlerle.Text = "İlerle";
            this.btnIlerle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIlerle.UseAccentColor = false;
            this.btnIlerle.UseVisualStyleBackColor = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.HideSelection = true;
            this.txtSifre.Hint = "Soyadınız";
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(185, 169);
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
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TabStop = false;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.HideSelection = true;
            this.txtKullaniciAdi.Hint = "Adınız";
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(185, 94);
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
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.TrailingIcon = null;
            this.txtKullaniciAdi.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.materialButton7);
            this.tabPage2.Controls.Add(this.btnIlerle2);
            this.tabPage2.Controls.Add(this.materialTextBox21);
            this.tabPage2.ImageKey = "mail_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "E-mail";
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.BackColor = System.Drawing.Color.Transparent;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(175, 224);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(64, 36);
            this.materialButton7.TabIndex = 10;
            this.materialButton7.Text = "Geri";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = false;
            // 
            // btnIlerle2
            // 
            this.btnIlerle2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlerle2.BackColor = System.Drawing.Color.Transparent;
            this.btnIlerle2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIlerle2.Depth = 0;
            this.btnIlerle2.HighEmphasis = true;
            this.btnIlerle2.Icon = null;
            this.btnIlerle2.Location = new System.Drawing.Point(514, 224);
            this.btnIlerle2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIlerle2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIlerle2.Name = "btnIlerle2";
            this.btnIlerle2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIlerle2.Size = new System.Drawing.Size(68, 36);
            this.btnIlerle2.TabIndex = 4;
            this.btnIlerle2.Text = "İlerle";
            this.btnIlerle2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIlerle2.UseAccentColor = false;
            this.btnIlerle2.UseVisualStyleBackColor = false;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "E-mail Adresinizi Giriniz";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(175, 133);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox21.TabIndex = 3;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialButton6);
            this.tabPage3.Controls.Add(this.materialButton1);
            this.tabPage3.Controls.Add(this.materialTextBox23);
            this.tabPage3.Controls.Add(this.materialTextBox22);
            this.tabPage3.ImageKey = "password_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Şifre";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.BackColor = System.Drawing.Color.Transparent;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(172, 251);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(64, 36);
            this.materialButton6.TabIndex = 10;
            this.materialButton6.Text = "Geri";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(511, 251);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(68, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "İlerle";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // materialTextBox23
            // 
            this.materialTextBox23.AnimateReadOnly = false;
            this.materialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox23.Depth = 0;
            this.materialTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox23.HideSelection = true;
            this.materialTextBox23.Hint = "Şifrenizi Tekrar Giriniz";
            this.materialTextBox23.LeadingIcon = null;
            this.materialTextBox23.Location = new System.Drawing.Point(172, 174);
            this.materialTextBox23.MaxLength = 32767;
            this.materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox23.Name = "materialTextBox23";
            this.materialTextBox23.PasswordChar = '\0';
            this.materialTextBox23.PrefixSuffixText = null;
            this.materialTextBox23.ReadOnly = false;
            this.materialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox23.SelectedText = "";
            this.materialTextBox23.SelectionLength = 0;
            this.materialTextBox23.SelectionStart = 0;
            this.materialTextBox23.ShortcutsEnabled = true;
            this.materialTextBox23.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox23.TabIndex = 5;
            this.materialTextBox23.TabStop = false;
            this.materialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox23.TrailingIcon = null;
            this.materialTextBox23.UseSystemPasswordChar = false;
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.Hint = "Şifrenizi Giriniz";
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(172, 87);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox22.TabIndex = 5;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialButton5);
            this.tabPage4.Controls.Add(this.materialButton2);
            this.tabPage4.Controls.Add(this.materialTextBox26);
            this.tabPage4.Controls.Add(this.materialTextBox24);
            this.tabPage4.Controls.Add(this.materialTextBox25);
            this.tabPage4.ImageKey = "settings_accessibility_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kişisel Özellikler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.BackColor = System.Drawing.Color.Transparent;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(183, 311);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(64, 36);
            this.materialButton5.TabIndex = 10;
            this.materialButton5.Text = "Geri";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(522, 311);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(68, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "İlerle";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            // 
            // materialTextBox26
            // 
            this.materialTextBox26.AnimateReadOnly = false;
            this.materialTextBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox26.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox26.Depth = 0;
            this.materialTextBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox26.HideSelection = true;
            this.materialTextBox26.Hint = "Hedeflediğiniz Kilo";
            this.materialTextBox26.LeadingIcon = null;
            this.materialTextBox26.Location = new System.Drawing.Point(183, 218);
            this.materialTextBox26.MaxLength = 32767;
            this.materialTextBox26.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox26.Name = "materialTextBox26";
            this.materialTextBox26.PasswordChar = '\0';
            this.materialTextBox26.PrefixSuffixText = null;
            this.materialTextBox26.ReadOnly = false;
            this.materialTextBox26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox26.SelectedText = "";
            this.materialTextBox26.SelectionLength = 0;
            this.materialTextBox26.SelectionStart = 0;
            this.materialTextBox26.ShortcutsEnabled = true;
            this.materialTextBox26.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox26.TabIndex = 6;
            this.materialTextBox26.TabStop = false;
            this.materialTextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox26.TrailingIcon = null;
            this.materialTextBox26.UseSystemPasswordChar = false;
            // 
            // materialTextBox24
            // 
            this.materialTextBox24.AnimateReadOnly = false;
            this.materialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox24.Depth = 0;
            this.materialTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox24.HideSelection = true;
            this.materialTextBox24.Hint = "Kilonuz Kaç kg?";
            this.materialTextBox24.LeadingIcon = null;
            this.materialTextBox24.Location = new System.Drawing.Point(183, 136);
            this.materialTextBox24.MaxLength = 32767;
            this.materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox24.Name = "materialTextBox24";
            this.materialTextBox24.PasswordChar = '\0';
            this.materialTextBox24.PrefixSuffixText = null;
            this.materialTextBox24.ReadOnly = false;
            this.materialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox24.SelectedText = "";
            this.materialTextBox24.SelectionLength = 0;
            this.materialTextBox24.SelectionStart = 0;
            this.materialTextBox24.ShortcutsEnabled = true;
            this.materialTextBox24.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox24.TabIndex = 6;
            this.materialTextBox24.TabStop = false;
            this.materialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox24.TrailingIcon = null;
            this.materialTextBox24.UseSystemPasswordChar = false;
            // 
            // materialTextBox25
            // 
            this.materialTextBox25.AnimateReadOnly = false;
            this.materialTextBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox25.Depth = 0;
            this.materialTextBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox25.HideSelection = true;
            this.materialTextBox25.Hint = "Boyunuz Kaç cm?";
            this.materialTextBox25.LeadingIcon = null;
            this.materialTextBox25.Location = new System.Drawing.Point(183, 49);
            this.materialTextBox25.MaxLength = 32767;
            this.materialTextBox25.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox25.Name = "materialTextBox25";
            this.materialTextBox25.PasswordChar = '\0';
            this.materialTextBox25.PrefixSuffixText = null;
            this.materialTextBox25.ReadOnly = false;
            this.materialTextBox25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox25.SelectedText = "";
            this.materialTextBox25.SelectionLength = 0;
            this.materialTextBox25.SelectionStart = 0;
            this.materialTextBox25.ShortcutsEnabled = true;
            this.materialTextBox25.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox25.TabIndex = 7;
            this.materialTextBox25.TabStop = false;
            this.materialTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox25.TrailingIcon = null;
            this.materialTextBox25.UseSystemPasswordChar = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialCheckbox1);
            this.tabPage5.Controls.Add(this.materialButton4);
            this.tabPage5.Controls.Add(this.materialButton3);
            this.tabPage5.Controls.Add(this.materialTextBox27);
            this.tabPage5.ImageKey = "transgender_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(790, 418);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Yaş Cinsiyet";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.ForeColor = System.Drawing.Color.Black;
            this.materialCheckbox1.Location = new System.Drawing.Point(191, 210);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(171, 37);
            this.materialCheckbox1.TabIndex = 10;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.BackColor = System.Drawing.Color.Transparent;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(191, 290);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 9;
            this.materialButton4.Text = "Geri";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.Transparent;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(461, 290);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(137, 36);
            this.materialButton3.TabIndex = 9;
            this.materialButton3.Text = "Kaydet ve Bitir";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialTextBox27
            // 
            this.materialTextBox27.AnimateReadOnly = false;
            this.materialTextBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox27.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox27.Depth = 0;
            this.materialTextBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox27.HideSelection = true;
            this.materialTextBox27.Hint = "Yaşınızı Griniz";
            this.materialTextBox27.LeadingIcon = null;
            this.materialTextBox27.Location = new System.Drawing.Point(191, 109);
            this.materialTextBox27.MaxLength = 32767;
            this.materialTextBox27.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox27.Name = "materialTextBox27";
            this.materialTextBox27.PasswordChar = '\0';
            this.materialTextBox27.PrefixSuffixText = null;
            this.materialTextBox27.ReadOnly = false;
            this.materialTextBox27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox27.SelectedText = "";
            this.materialTextBox27.SelectionLength = 0;
            this.materialTextBox27.SelectionStart = 0;
            this.materialTextBox27.ShortcutsEnabled = true;
            this.materialTextBox27.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox27.TabIndex = 8;
            this.materialTextBox27.TabStop = false;
            this.materialTextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox27.TrailingIcon = null;
            this.materialTextBox27.UseSystemPasswordChar = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "r1.png");
            this.ımageList1.Images.SetKeyName(1, "r2.png");
            this.ımageList1.Images.SetKeyName(2, "r3.png");
            this.ımageList1.Images.SetKeyName(3, "r4.jpg");
            this.ımageList1.Images.SetKeyName(4, "r5.jpg");
            this.ımageList1.Images.SetKeyName(5, "r6.png");
            this.ımageList1.Images.SetKeyName(6, "mail_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(7, "password_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(8, "settings_accessibility_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(9, "transgender_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 544);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ImageList ımageList1;
        private MaterialSkin.Controls.MaterialButton btnIlerle;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialTextBox2 txtKullaniciAdi;
        private MaterialSkin.Controls.MaterialButton btnIlerle2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox26;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox25;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox27;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}