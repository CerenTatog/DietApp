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
            ((System.ComponentModel.ISupportInitialize)(this.nmrStepCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKCAL
            // 
            this.lblKCAL.AutoSize = true;
            this.lblKCAL.Depth = 0;
            this.lblKCAL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKCAL.Location = new System.Drawing.Point(281, 122);
            this.lblKCAL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKCAL.Name = "lblKCAL";
            this.lblKCAL.Size = new System.Drawing.Size(32, 19);
            this.lblKCAL.TabIndex = 0;
            this.lblKCAL.Text = "kCal";
            // 
            // nmrStepCount
            // 
            this.nmrStepCount.Location = new System.Drawing.Point(147, 217);
            this.nmrStepCount.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nmrStepCount.Name = "nmrStepCount";
            this.nmrStepCount.Size = new System.Drawing.Size(388, 22);
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
            this.btnAddStepCount.Location = new System.Drawing.Point(248, 309);
            this.btnAddStepCount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStepCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStepCount.Name = "btnAddStepCount";
            this.btnAddStepCount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStepCount.Size = new System.Drawing.Size(144, 36);
            this.btnAddStepCount.TabIndex = 3;
            this.btnAddStepCount.Text = "Adım Sayısı Ekle";
            this.btnAddStepCount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStepCount.UseAccentColor = false;
            this.btnAddStepCount.UseVisualStyleBackColor = true;
            this.btnAddStepCount.Click += new System.EventHandler(this.btnAddStepCount_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(157, 184);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(255, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Lütfen Günlük Adım Sayınızı Giriniz.";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 417);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnAddStepCount);
            this.Controls.Add(this.nmrStepCount);
            this.Controls.Add(this.lblKCAL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Adım Sayısı Gir";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrStepCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblKCAL;
        private System.Windows.Forms.NumericUpDown nmrStepCount;
        private MaterialSkin.Controls.MaterialButton btnAddStepCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}