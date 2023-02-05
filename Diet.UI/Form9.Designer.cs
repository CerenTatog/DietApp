namespace Diet.UI
{
    partial class Form9
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtActivityType = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtCalorie = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAddActivity = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteActivity = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdateActivity = new MaterialSkin.Controls.MaterialButton();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(96, 157);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Aktivite Türü";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(27, 219);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(159, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Kalori (Dakika Başına)";
            // 
            // txtActivityType
            // 
            this.txtActivityType.AllowPromptAsInput = true;
            this.txtActivityType.AnimateReadOnly = false;
            this.txtActivityType.AsciiOnly = false;
            this.txtActivityType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtActivityType.BeepOnError = false;
            this.txtActivityType.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtActivityType.Depth = 0;
            this.txtActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtActivityType.HidePromptOnLeave = false;
            this.txtActivityType.HideSelection = true;
            this.txtActivityType.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtActivityType.LeadingIcon = null;
            this.txtActivityType.Location = new System.Drawing.Point(202, 137);
            this.txtActivityType.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityType.Mask = "";
            this.txtActivityType.MaxLength = 32767;
            this.txtActivityType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtActivityType.Name = "txtActivityType";
            this.txtActivityType.PasswordChar = '\0';
            this.txtActivityType.PrefixSuffixText = null;
            this.txtActivityType.PromptChar = '_';
            this.txtActivityType.ReadOnly = false;
            this.txtActivityType.RejectInputOnFirstFailure = false;
            this.txtActivityType.ResetOnPrompt = true;
            this.txtActivityType.ResetOnSpace = true;
            this.txtActivityType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtActivityType.SelectedText = "";
            this.txtActivityType.SelectionLength = 0;
            this.txtActivityType.SelectionStart = 0;
            this.txtActivityType.ShortcutsEnabled = true;
            this.txtActivityType.Size = new System.Drawing.Size(188, 48);
            this.txtActivityType.SkipLiterals = true;
            this.txtActivityType.TabIndex = 2;
            this.txtActivityType.TabStop = false;
            this.txtActivityType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActivityType.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtActivityType.TrailingIcon = null;
            this.txtActivityType.UseSystemPasswordChar = false;
            this.txtActivityType.ValidatingType = null;
            // 
            // txtCalorie
            // 
            this.txtCalorie.AllowPromptAsInput = true;
            this.txtCalorie.AnimateReadOnly = false;
            this.txtCalorie.AsciiOnly = false;
            this.txtCalorie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalorie.BeepOnError = false;
            this.txtCalorie.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCalorie.Depth = 0;
            this.txtCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalorie.HidePromptOnLeave = false;
            this.txtCalorie.HideSelection = true;
            this.txtCalorie.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCalorie.LeadingIcon = null;
            this.txtCalorie.Location = new System.Drawing.Point(202, 206);
            this.txtCalorie.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalorie.Mask = "";
            this.txtCalorie.MaxLength = 32767;
            this.txtCalorie.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalorie.Name = "txtCalorie";
            this.txtCalorie.PasswordChar = '\0';
            this.txtCalorie.PrefixSuffixText = null;
            this.txtCalorie.PromptChar = '_';
            this.txtCalorie.ReadOnly = false;
            this.txtCalorie.RejectInputOnFirstFailure = false;
            this.txtCalorie.ResetOnPrompt = true;
            this.txtCalorie.ResetOnSpace = true;
            this.txtCalorie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalorie.SelectedText = "";
            this.txtCalorie.SelectionLength = 0;
            this.txtCalorie.SelectionStart = 0;
            this.txtCalorie.ShortcutsEnabled = true;
            this.txtCalorie.Size = new System.Drawing.Size(188, 48);
            this.txtCalorie.SkipLiterals = true;
            this.txtCalorie.TabIndex = 3;
            this.txtCalorie.TabStop = false;
            this.txtCalorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalorie.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCalorie.TrailingIcon = null;
            this.txtCalorie.UseSystemPasswordChar = false;
            this.txtCalorie.ValidatingType = null;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddActivity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddActivity.Depth = 0;
            this.btnAddActivity.HighEmphasis = true;
            this.btnAddActivity.Icon = null;
            this.btnAddActivity.Location = new System.Drawing.Point(122, 302);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddActivity.Size = new System.Drawing.Size(64, 36);
            this.btnAddActivity.TabIndex = 4;
            this.btnAddActivity.Text = "Ekle";
            this.btnAddActivity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddActivity.UseAccentColor = false;
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteActivity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteActivity.Depth = 0;
            this.btnDeleteActivity.HighEmphasis = true;
            this.btnDeleteActivity.Icon = null;
            this.btnDeleteActivity.Location = new System.Drawing.Point(209, 302);
            this.btnDeleteActivity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteActivity.Size = new System.Drawing.Size(64, 36);
            this.btnDeleteActivity.TabIndex = 5;
            this.btnDeleteActivity.Text = "Sil";
            this.btnDeleteActivity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteActivity.UseAccentColor = false;
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateActivity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdateActivity.Depth = 0;
            this.btnUpdateActivity.HighEmphasis = true;
            this.btnUpdateActivity.Icon = null;
            this.btnUpdateActivity.Location = new System.Drawing.Point(296, 302);
            this.btnUpdateActivity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdateActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateActivity.Size = new System.Drawing.Size(94, 36);
            this.btnUpdateActivity.TabIndex = 6;
            this.btnUpdateActivity.Text = "Güncelle";
            this.btnUpdateActivity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateActivity.UseAccentColor = false;
            this.btnUpdateActivity.UseVisualStyleBackColor = true;
            this.btnUpdateActivity.Click += new System.EventHandler(this.btnUpdateActivity_Click);
            // 
            // dgvActivities
            // 
            this.dgvActivities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivities.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivities.Location = new System.Drawing.Point(443, 139);
            this.dgvActivities.Margin = new System.Windows.Forms.Padding(2);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.Size = new System.Drawing.Size(370, 199);
            this.dgvActivities.TabIndex = 7;
            this.dgvActivities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(667, 96);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(146, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Ana Ekrana Dön";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(21, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 418);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.btnUpdateActivity);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.txtCalorie);
            this.Controls.Add(this.txtActivityType);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Aktivie İşlemleri(Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtActivityType;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCalorie;
        private MaterialSkin.Controls.MaterialButton btnAddActivity;
        private MaterialSkin.Controls.MaterialButton btnDeleteActivity;
        private MaterialSkin.Controls.MaterialButton btnUpdateActivity;
        private System.Windows.Forms.DataGridView dgvActivities;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}