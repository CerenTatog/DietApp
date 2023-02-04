namespace Diet.UI
{
    partial class Form7
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbActivities = new MaterialSkin.Controls.MaterialComboBox();
            this.nmrDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddActivity = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKCAL
            // 
            this.lblKCAL.AutoSize = true;
            this.lblKCAL.Depth = 0;
            this.lblKCAL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKCAL.Location = new System.Drawing.Point(231, 97);
            this.lblKCAL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKCAL.Name = "lblKCAL";
            this.lblKCAL.Size = new System.Drawing.Size(32, 19);
            this.lblKCAL.TabIndex = 0;
            this.lblKCAL.Text = "kCal";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 176);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Lütfen Aktivite Seçiniz.";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(9, 238);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(219, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Lütfen Aktivite Süresini Seçiniz";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(505, 238);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(24, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Dk.";
            // 
            // cmbActivities
            // 
            this.cmbActivities.AutoResize = false;
            this.cmbActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbActivities.Depth = 0;
            this.cmbActivities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbActivities.DropDownHeight = 174;
            this.cmbActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivities.DropDownWidth = 121;
            this.cmbActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbActivities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.IntegralHeight = false;
            this.cmbActivities.ItemHeight = 43;
            this.cmbActivities.Location = new System.Drawing.Point(234, 163);
            this.cmbActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbActivities.MaxDropDownItems = 4;
            this.cmbActivities.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(347, 49);
            this.cmbActivities.StartIndex = 0;
            this.cmbActivities.TabIndex = 4;
            // 
            // nmrDuration
            // 
            this.nmrDuration.Location = new System.Drawing.Point(234, 235);
            this.nmrDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrDuration.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmrDuration.Name = "nmrDuration";
            this.nmrDuration.Size = new System.Drawing.Size(253, 22);
            this.nmrDuration.TabIndex = 5;
            this.nmrDuration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddActivity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddActivity.Depth = 0;
            this.btnAddActivity.HighEmphasis = true;
            this.btnAddActivity.Icon = null;
            this.btnAddActivity.Location = new System.Drawing.Point(175, 306);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddActivity.Size = new System.Drawing.Size(122, 36);
            this.btnAddActivity.TabIndex = 6;
            this.btnAddActivity.Text = "Aktivite Ekle";
            this.btnAddActivity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddActivity.UseAccentColor = false;
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(21, 364);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(155, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Günlük Aktiviteler";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 684);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.nmrDuration);
            this.Controls.Add(this.cmbActivities);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblKCAL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Aktivite Ekle(Kullanıcı)";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblKCAL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmbActivities;
        private System.Windows.Forms.NumericUpDown nmrDuration;
        private MaterialSkin.Controls.MaterialButton btnAddActivity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}