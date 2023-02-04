namespace Diet.UI
{
    partial class Form4
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mlAktiviteDuzenle = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BesinEkle = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mlAktiviteDuzenle);
            this.groupBox6.Location = new System.Drawing.Point(93, 501);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(915, 188);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Aktivite Verileri";
            // 
            // mlAktiviteDuzenle
            // 
            this.mlAktiviteDuzenle.AutoSize = true;
            this.mlAktiviteDuzenle.Depth = 0;
            this.mlAktiviteDuzenle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlAktiviteDuzenle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.mlAktiviteDuzenle.HighEmphasis = true;
            this.mlAktiviteDuzenle.Location = new System.Drawing.Point(859, 16);
            this.mlAktiviteDuzenle.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlAktiviteDuzenle.Name = "mlAktiviteDuzenle";
            this.mlAktiviteDuzenle.Size = new System.Drawing.Size(50, 17);
            this.mlAktiviteDuzenle.TabIndex = 1;
            this.mlAktiviteDuzenle.Text = "Düzenle";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BesinEkle);
            this.groupBox5.Location = new System.Drawing.Point(93, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(915, 188);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Besin Verileri";
            // 
            // BesinEkle
            // 
            this.BesinEkle.AutoSize = true;
            this.BesinEkle.Depth = 0;
            this.BesinEkle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BesinEkle.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.BesinEkle.HighEmphasis = true;
            this.BesinEkle.Location = new System.Drawing.Point(851, 16);
            this.BesinEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.BesinEkle.Name = "BesinEkle";
            this.BesinEkle.Size = new System.Drawing.Size(50, 17);
            this.BesinEkle.TabIndex = 0;
            this.BesinEkle.Text = "Düzenle";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewKullaniciListesi);
            this.groupBox4.Location = new System.Drawing.Point(93, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(915, 202);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanıcı Listesi";
            // 
            // dataGridViewKullaniciListesi
            // 
            this.dataGridViewKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullaniciListesi.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewKullaniciListesi.Name = "dataGridViewKullaniciListesi";
            this.dataGridViewKullaniciListesi.Size = new System.Drawing.Size(847, 150);
            this.dataGridViewKullaniciListesi.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1025, 244);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 758);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form4";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialLabel mlAktiviteDuzenle;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialLabel BesinEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewKullaniciListesi;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}