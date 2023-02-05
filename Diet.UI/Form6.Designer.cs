namespace Diet.UI
{
    partial class Form6
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
            this.lblKCAL = new MaterialSkin.Controls.MaterialLabel();
            this.nmrStepCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddStepCount = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStepCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKCAL
            // 
            this.lblKCAL.AutoSize = true;
            this.lblKCAL.Depth = 0;
            this.lblKCAL.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblKCAL.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblKCAL.Location = new System.Drawing.Point(93, 14);
            this.lblKCAL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKCAL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKCAL.Name = "lblKCAL";
            this.lblKCAL.Size = new System.Drawing.Size(48, 29);
            this.lblKCAL.TabIndex = 0;
            this.lblKCAL.Text = "kCal";
            // 
            // nmrStepCount
            // 
            this.nmrStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrStepCount.Location = new System.Drawing.Point(170, 25);
            this.nmrStepCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmrStepCount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nmrStepCount.Name = "nmrStepCount";
            this.nmrStepCount.Size = new System.Drawing.Size(155, 29);
            this.nmrStepCount.TabIndex = 2;
            this.nmrStepCount.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // btnAddStepCount
            // 
            this.btnAddStepCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStepCount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStepCount.Depth = 0;
            this.btnAddStepCount.HighEmphasis = true;
            this.btnAddStepCount.Icon = null;
            this.btnAddStepCount.Location = new System.Drawing.Point(453, 259);
            this.btnAddStepCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddStepCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStepCount.Name = "btnAddStepCount";
            this.btnAddStepCount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStepCount.Size = new System.Drawing.Size(135, 36);
            this.btnAddStepCount.TabIndex = 3;
            this.btnAddStepCount.Text = "Ekle/Güncelle";
            this.btnAddStepCount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStepCount.UseAccentColor = false;
            this.btnAddStepCount.UseVisualStyleBackColor = true;
            this.btnAddStepCount.Click += new System.EventHandler(this.btnAddStepCount_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(26, 23);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 29);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Adım Sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStepCount);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialCard1);
            this.groupBox1.Location = new System.Drawing.Point(25, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(6, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 29);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Adım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diet.UI.Properties.Resources.foot_traffic;
            this.pictureBox1.Location = new System.Drawing.Point(21, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.nmrStepCount);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(220, 46);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(357, 176);
            this.materialCard1.TabIndex = 7;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblKCAL);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(135, 91);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(194, 60);
            this.materialCard2.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 409);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Adım Sayısı Gir";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrStepCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblKCAL;
        private System.Windows.Forms.NumericUpDown nmrStepCount;
        private MaterialSkin.Controls.MaterialButton btnAddStepCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}