namespace SystemSearchWFA
{
    partial class SearchForm
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
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbxMilitary = new System.Windows.Forms.ComboBox();
            this.cbxEyeColor = new System.Windows.Forms.ComboBox();
            this.cbxMarital = new System.Windows.Forms.ComboBox();
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.tbxSeries = new System.Windows.Forms.TextBox();
            this.tbxLivingPlace = new System.Windows.Forms.TextBox();
            this.tbxBirthPlace = new System.Windows.Forms.TextBox();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxIssueAuthority = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(107, 341);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 82;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 81;
            this.label17.Text = "Gender";
            // 
            // cbxBloodGroup
            // 
            this.cbxBloodGroup.FormattingEnabled = true;
            this.cbxBloodGroup.Location = new System.Drawing.Point(107, 372);
            this.cbxBloodGroup.Name = "cbxBloodGroup";
            this.cbxBloodGroup.Size = new System.Drawing.Size(100, 21);
            this.cbxBloodGroup.TabIndex = 80;
            this.cbxBloodGroup.SelectedIndexChanged += new System.EventHandler(this.cbxBloodGroup_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "Blood Group";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(292, 13);
            this.nudHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(73, 20);
            this.nudHeight.TabIndex = 78;
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "Height";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(288, 74);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber.TabIndex = 76;
            this.tbxNumber.TextChanged += new System.EventHandler(this.tbxNumber_TextChanged);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(107, 281);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(102, 20);
            this.dtpIssueDate.TabIndex = 75;
            this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(315, 43);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(102, 20);
            this.dtpExpiryDate.TabIndex = 74;
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dtpExpiryDate_ValueChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "MM/dd/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(109, 121);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(102, 20);
            this.dtpBirthDate.TabIndex = 73;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // cbxMilitary
            // 
            this.cbxMilitary.FormattingEnabled = true;
            this.cbxMilitary.Location = new System.Drawing.Point(109, 206);
            this.cbxMilitary.Name = "cbxMilitary";
            this.cbxMilitary.Size = new System.Drawing.Size(121, 21);
            this.cbxMilitary.TabIndex = 72;
            this.cbxMilitary.SelectedIndexChanged += new System.EventHandler(this.cbxMilitary_SelectedIndexChanged);
            // 
            // cbxEyeColor
            // 
            this.cbxEyeColor.FormattingEnabled = true;
            this.cbxEyeColor.Location = new System.Drawing.Point(109, 229);
            this.cbxEyeColor.Name = "cbxEyeColor";
            this.cbxEyeColor.Size = new System.Drawing.Size(121, 21);
            this.cbxEyeColor.TabIndex = 71;
            this.cbxEyeColor.SelectedIndexChanged += new System.EventHandler(this.cbxEyeColor_SelectedIndexChanged);
            // 
            // cbxMarital
            // 
            this.cbxMarital.FormattingEnabled = true;
            this.cbxMarital.Location = new System.Drawing.Point(109, 179);
            this.cbxMarital.Name = "cbxMarital";
            this.cbxMarital.Size = new System.Drawing.Size(121, 21);
            this.cbxMarital.TabIndex = 70;
            this.cbxMarital.SelectedIndexChanged += new System.EventHandler(this.cbxMarital_SelectedIndexChanged);
            // 
            // cbxNationality
            // 
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.Location = new System.Drawing.Point(109, 153);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(100, 21);
            this.cbxNationality.TabIndex = 69;
            this.cbxNationality.SelectedIndexChanged += new System.EventHandler(this.cbxNationality_SelectedIndexChanged);
            // 
            // tbxSeries
            // 
            this.tbxSeries.Location = new System.Drawing.Point(109, 307);
            this.tbxSeries.Name = "tbxSeries";
            this.tbxSeries.Size = new System.Drawing.Size(100, 20);
            this.tbxSeries.TabIndex = 68;
            this.tbxSeries.TextChanged += new System.EventHandler(this.tbxSeries_TextChanged);
            // 
            // tbxLivingPlace
            // 
            this.tbxLivingPlace.Location = new System.Drawing.Point(109, 255);
            this.tbxLivingPlace.Name = "tbxLivingPlace";
            this.tbxLivingPlace.Size = new System.Drawing.Size(100, 20);
            this.tbxLivingPlace.TabIndex = 67;
            this.tbxLivingPlace.TextChanged += new System.EventHandler(this.tbxLivingPlace_TextChanged);
            // 
            // tbxBirthPlace
            // 
            this.tbxBirthPlace.Location = new System.Drawing.Point(109, 96);
            this.tbxBirthPlace.Name = "tbxBirthPlace";
            this.tbxBirthPlace.Size = new System.Drawing.Size(100, 20);
            this.tbxBirthPlace.TabIndex = 66;
            this.tbxBirthPlace.TextChanged += new System.EventHandler(this.tbxBirthPlace_TextChanged);
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(109, 70);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(100, 20);
            this.tbxFatherName.TabIndex = 65;
            this.tbxFatherName.TextChanged += new System.EventHandler(this.tbxFatherName_TextChanged);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(109, 42);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 64;
            this.tbxSurname.TextChanged += new System.EventHandler(this.tbxSurname_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(109, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 63;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxIssueAuthority);
            this.groupBox1.Location = new System.Drawing.Point(15, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 49);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Authority";
            // 
            // tbxIssueAuthority
            // 
            this.tbxIssueAuthority.Location = new System.Drawing.Point(25, 19);
            this.tbxIssueAuthority.Name = "tbxIssueAuthority";
            this.tbxIssueAuthority.Size = new System.Drawing.Size(138, 20);
            this.tbxIssueAuthority.TabIndex = 25;
            this.tbxIssueAuthority.TextChanged += new System.EventHandler(this.tbxIssueAuthority_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Expiry Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "№";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Series";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Issue Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Living Place";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Eye Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Military Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Marital Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Birth Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Father Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Name";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(270, 121);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(697, 325);
            this.dgvSearch.TabIndex = 83;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 468);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxBloodGroup);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cbxMilitary);
            this.Controls.Add(this.cbxEyeColor);
            this.Controls.Add(this.cbxMarital);
            this.Controls.Add(this.cbxNationality);
            this.Controls.Add(this.tbxSeries);
            this.Controls.Add(this.tbxLivingPlace);
            this.Controls.Add(this.tbxBirthPlace);
            this.Controls.Add(this.tbxFatherName);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbxMilitary;
        private System.Windows.Forms.ComboBox cbxEyeColor;
        private System.Windows.Forms.ComboBox cbxMarital;
        private System.Windows.Forms.ComboBox cbxNationality;
        private System.Windows.Forms.TextBox tbxSeries;
        private System.Windows.Forms.TextBox tbxLivingPlace;
        private System.Windows.Forms.TextBox tbxBirthPlace;
        private System.Windows.Forms.TextBox tbxFatherName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxIssueAuthority;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearch;
    }
}