namespace SystemSearchWFA
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxIssueAuthority = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.tbxBirthPlace = new System.Windows.Forms.TextBox();
            this.tbxLivingPlace = new System.Windows.Forms.TextBox();
            this.tbxSeries = new System.Windows.Forms.TextBox();
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.cbxMarital = new System.Windows.Forms.ComboBox();
            this.cbxEyeColor = new System.Windows.Forms.ComboBox();
            this.cbxMilitary = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maritalStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.militaryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxBloodGroup = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(156, 191);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(34, 23);
            this.btnRemoveImage.TabIndex = 1;
            this.btnRemoveImage.Text = "-";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(156, 162);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(34, 23);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nationality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Marital Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Military Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Eye Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Living Place";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Issue Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 531);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Series";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 531);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "№";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Expiry Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxIssueAuthority);
            this.groupBox1.Location = new System.Drawing.Point(27, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Authority";
            // 
            // tbxIssueAuthority
            // 
            this.tbxIssueAuthority.Location = new System.Drawing.Point(25, 19);
            this.tbxIssueAuthority.Name = "tbxIssueAuthority";
            this.tbxIssueAuthority.Size = new System.Drawing.Size(138, 20);
            this.tbxIssueAuthority.TabIndex = 25;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(121, 233);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 19;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(121, 263);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 20;
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(121, 291);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(100, 20);
            this.tbxFatherName.TabIndex = 21;
            // 
            // tbxBirthPlace
            // 
            this.tbxBirthPlace.Location = new System.Drawing.Point(121, 317);
            this.tbxBirthPlace.Name = "tbxBirthPlace";
            this.tbxBirthPlace.Size = new System.Drawing.Size(100, 20);
            this.tbxBirthPlace.TabIndex = 22;
            // 
            // tbxLivingPlace
            // 
            this.tbxLivingPlace.Location = new System.Drawing.Point(121, 476);
            this.tbxLivingPlace.Name = "tbxLivingPlace";
            this.tbxLivingPlace.Size = new System.Drawing.Size(100, 20);
            this.tbxLivingPlace.TabIndex = 23;
            // 
            // tbxSeries
            // 
            this.tbxSeries.Location = new System.Drawing.Point(121, 528);
            this.tbxSeries.Name = "tbxSeries";
            this.tbxSeries.Size = new System.Drawing.Size(100, 20);
            this.tbxSeries.TabIndex = 24;
            // 
            // cbxNationality
            // 
            this.cbxNationality.DisplayMember = "Text";
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.Location = new System.Drawing.Point(121, 374);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(100, 21);
            this.cbxNationality.TabIndex = 25;
            this.cbxNationality.ValueMember = "Value";
            // 
            // cbxMarital
            // 
            this.cbxMarital.DisplayMember = "Text";
            this.cbxMarital.FormattingEnabled = true;
            this.cbxMarital.Location = new System.Drawing.Point(121, 400);
            this.cbxMarital.Name = "cbxMarital";
            this.cbxMarital.Size = new System.Drawing.Size(121, 21);
            this.cbxMarital.TabIndex = 26;
            this.cbxMarital.ValueMember = "Value";
            // 
            // cbxEyeColor
            // 
            this.cbxEyeColor.DisplayMember = "Text";
            this.cbxEyeColor.FormattingEnabled = true;
            this.cbxEyeColor.Location = new System.Drawing.Point(121, 450);
            this.cbxEyeColor.Name = "cbxEyeColor";
            this.cbxEyeColor.Size = new System.Drawing.Size(121, 21);
            this.cbxEyeColor.TabIndex = 27;
            this.cbxEyeColor.ValueMember = "Value";
            // 
            // cbxMilitary
            // 
            this.cbxMilitary.DisplayMember = "Text";
            this.cbxMilitary.FormattingEnabled = true;
            this.cbxMilitary.Location = new System.Drawing.Point(121, 427);
            this.cbxMilitary.Name = "cbxMilitary";
            this.cbxMilitary.Size = new System.Drawing.Size(121, 21);
            this.cbxMilitary.TabIndex = 29;
            this.cbxMilitary.ValueMember = "Value";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Checked = false;
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(119, 342);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.ShowCheckBox = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(102, 20);
            this.dtpBirthDate.TabIndex = 30;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Checked = false;
            this.dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(304, 502);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.ShowCheckBox = true;
            this.dtpExpiryDate.Size = new System.Drawing.Size(102, 20);
            this.dtpExpiryDate.TabIndex = 31;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Checked = false;
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(119, 502);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.ShowCheckBox = true;
            this.dtpIssueDate.Size = new System.Drawing.Size(102, 20);
            this.dtpIssueDate.TabIndex = 32;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(277, 528);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxNumber.TabIndex = 33;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(425, 31);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(773, 522);
            this.dgvPerson.TabIndex = 34;
            this.dgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellClick);
            this.dgvPerson.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_RowEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Height";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(304, 401);
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
            this.nudHeight.TabIndex = 36;
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(425, 559);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 23);
            this.btnUp.TabIndex = 37;
            this.btnUp.Text = "<";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(487, 559);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(58, 23);
            this.btnDown.TabIndex = 38;
            this.btnDown.Text = ">";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(562, 559);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(961, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add New Person";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1042, 559);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1123, 559);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.catalogToolStripMenuItem,
            this.postionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nationalityToolStripMenuItem,
            this.maritalStatusToolStripMenuItem,
            this.militaryStatusToolStripMenuItem,
            this.eyeColorToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.catalogToolStripMenuItem.Text = "Catalog";
            // 
            // nationalityToolStripMenuItem
            // 
            this.nationalityToolStripMenuItem.Name = "nationalityToolStripMenuItem";
            this.nationalityToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nationalityToolStripMenuItem.Text = "Nationality";
            this.nationalityToolStripMenuItem.Click += new System.EventHandler(this.nationalityToolStripMenuItem_Click);
            // 
            // maritalStatusToolStripMenuItem
            // 
            this.maritalStatusToolStripMenuItem.Name = "maritalStatusToolStripMenuItem";
            this.maritalStatusToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.maritalStatusToolStripMenuItem.Text = "Marital Status";
            this.maritalStatusToolStripMenuItem.Click += new System.EventHandler(this.maritalStatusToolStripMenuItem_Click);
            // 
            // militaryStatusToolStripMenuItem
            // 
            this.militaryStatusToolStripMenuItem.Name = "militaryStatusToolStripMenuItem";
            this.militaryStatusToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.militaryStatusToolStripMenuItem.Text = "Military Status";
            this.militaryStatusToolStripMenuItem.Click += new System.EventHandler(this.militaryStatusToolStripMenuItem_Click);
            // 
            // eyeColorToolStripMenuItem
            // 
            this.eyeColorToolStripMenuItem.Name = "eyeColorToolStripMenuItem";
            this.eyeColorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eyeColorToolStripMenuItem.Text = "Eye Color";
            this.eyeColorToolStripMenuItem.Click += new System.EventHandler(this.eyeColorToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.bloodGroupToolStripMenuItem.Text = "Blood Group";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // postionToolStripMenuItem
            // 
            this.postionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.postionToolStripMenuItem.Name = "postionToolStripMenuItem";
            this.postionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.postionToolStripMenuItem.Text = "Postion";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // cbxBloodGroup
            // 
            this.cbxBloodGroup.DisplayMember = "Text";
            this.cbxBloodGroup.FormattingEnabled = true;
            this.cbxBloodGroup.Location = new System.Drawing.Point(319, 374);
            this.cbxBloodGroup.Name = "cbxBloodGroup";
            this.cbxBloodGroup.Size = new System.Drawing.Size(100, 21);
            this.cbxBloodGroup.TabIndex = 45;
            this.cbxBloodGroup.ValueMember = "Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Blood Group";
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Gender";
            // 
            // cbxGender
            // 
            this.cbxGender.DisplayMember = "Text";
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(319, 345);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 47;
            this.cbxGender.ValueMember = "Value";
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(319, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 613);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxBloodGroup);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvPerson);
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
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Search System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxIssueAuthority;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxFatherName;
        private System.Windows.Forms.TextBox tbxBirthPlace;
        private System.Windows.Forms.TextBox tbxLivingPlace;
        private System.Windows.Forms.TextBox tbxSeries;
        private System.Windows.Forms.ComboBox cbxNationality;
        private System.Windows.Forms.ComboBox cbxMarital;
        private System.Windows.Forms.ComboBox cbxEyeColor;
        private System.Windows.Forms.ComboBox cbxMilitary;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maritalStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem militaryStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxBloodGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
        private System.Windows.Forms.Button btnReset;
    }
}

