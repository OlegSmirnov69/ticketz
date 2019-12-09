namespace Kursova
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sigendbDataSet = new Kursova.sigendbDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Kursova.sigendbDataSetTableAdapters.employeeTableAdapter();
            this.jobTableAdapter = new Kursova.sigendbDataSetTableAdapters.jobTableAdapter();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn_clear_employee = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.combo_job = new MetroFramework.Controls.MetroComboBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeejobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_add_emp = new MetroFramework.Controls.MetroButton();
            this.txt_adress = new MetroFramework.Controls.MetroTextBox();
            this.btn_del_employee = new MetroFramework.Controls.MetroButton();
            this.txt_surname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_phone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_update_employee = new MetroFramework.Controls.MetroButton();
            this.txt_gender = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_clear_job = new MetroFramework.Controls.MetroButton();
            this.btn_del_job = new MetroFramework.Controls.MetroButton();
            this.btn_update_job = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_jobname = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_add_job = new MetroFramework.Controls.MetroButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jobnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigendbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            this.jobBindingSource.DataSource = this.sigendbDataSet;
            // 
            // sigendbDataSet
            // 
            this.sigendbDataSet.DataSetName = "sigendbDataSet";
            this.sigendbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.sigendbDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(942, 417);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_clear_employee);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.combo_job);
            this.metroTabPage1.Controls.Add(this.txt_name);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.btn_add_emp);
            this.metroTabPage1.Controls.Add(this.txt_adress);
            this.metroTabPage1.Controls.Add(this.btn_del_employee);
            this.metroTabPage1.Controls.Add(this.txt_surname);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.txt_phone);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.btn_update_employee);
            this.metroTabPage1.Controls.Add(this.txt_gender);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(934, 378);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Працівники";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btn_clear_employee
            // 
            this.btn_clear_employee.Location = new System.Drawing.Point(0, 331);
            this.btn_clear_employee.Name = "btn_clear_employee";
            this.btn_clear_employee.Size = new System.Drawing.Size(143, 44);
            this.btn_clear_employee.TabIndex = 20;
            this.btn_clear_employee.Text = "Очистити поля";
            this.btn_clear_employee.Click += new System.EventHandler(this.btn_clear_employee_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(165, 335);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 25);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Посада";
            // 
            // combo_job
            // 
            this.combo_job.DataSource = this.jobBindingSource;
            this.combo_job.DisplayMember = "job_name";
            this.combo_job.FormattingEnabled = true;
            this.combo_job.ItemHeight = 23;
            this.combo_job.Location = new System.Drawing.Point(259, 331);
            this.combo_job.Name = "combo_job";
            this.combo_job.Size = new System.Drawing.Size(669, 29);
            this.combo_job.TabIndex = 8;
            this.combo_job.ValueMember = "job_id";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(259, 171);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(669, 29);
            this.txt_name.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(165, 175);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Ім\'я";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(165, 207);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Прізвище";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeenameDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.employeesurnameDataGridViewTextBoxColumn,
            this.employeegenderDataGridViewTextBoxColumn,
            this.employeephoneDataGridViewTextBoxColumn,
            this.employeeadressDataGridViewTextBoxColumn,
            this.employeejobidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(149, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(785, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeesurnameDataGridViewTextBoxColumn
            // 
            this.employeesurnameDataGridViewTextBoxColumn.DataPropertyName = "employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.employeesurnameDataGridViewTextBoxColumn.Name = "employeesurnameDataGridViewTextBoxColumn";
            this.employeesurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeegenderDataGridViewTextBoxColumn
            // 
            this.employeegenderDataGridViewTextBoxColumn.DataPropertyName = "employee_gender";
            this.employeegenderDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.employeegenderDataGridViewTextBoxColumn.Name = "employeegenderDataGridViewTextBoxColumn";
            // 
            // employeephoneDataGridViewTextBoxColumn
            // 
            this.employeephoneDataGridViewTextBoxColumn.DataPropertyName = "employee_phone";
            this.employeephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.employeephoneDataGridViewTextBoxColumn.Name = "employeephoneDataGridViewTextBoxColumn";
            this.employeephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeadressDataGridViewTextBoxColumn
            // 
            this.employeeadressDataGridViewTextBoxColumn.DataPropertyName = "employee_adress";
            this.employeeadressDataGridViewTextBoxColumn.HeaderText = "Адреса проживання";
            this.employeeadressDataGridViewTextBoxColumn.Name = "employeeadressDataGridViewTextBoxColumn";
            this.employeeadressDataGridViewTextBoxColumn.Width = 192;
            // 
            // employeejobidDataGridViewTextBoxColumn
            // 
            this.employeejobidDataGridViewTextBoxColumn.DataPropertyName = "employee_job_id";
            this.employeejobidDataGridViewTextBoxColumn.HeaderText = "employee_job_id";
            this.employeejobidDataGridViewTextBoxColumn.Name = "employeejobidDataGridViewTextBoxColumn";
            this.employeejobidDataGridViewTextBoxColumn.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(165, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Стать";
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Location = new System.Drawing.Point(0, 170);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Size = new System.Drawing.Size(143, 44);
            this.btn_add_emp.TabIndex = 9;
            this.btn_add_emp.Text = "Додати працівника";
            this.btn_add_emp.Click += new System.EventHandler(this.btn_add_emp_Click);
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(259, 299);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(669, 29);
            this.txt_adress.TabIndex = 7;
            // 
            // btn_del_employee
            // 
            this.btn_del_employee.Location = new System.Drawing.Point(0, 281);
            this.btn_del_employee.Name = "btn_del_employee";
            this.btn_del_employee.Size = new System.Drawing.Size(143, 44);
            this.btn_del_employee.TabIndex = 11;
            this.btn_del_employee.Text = "Видалити";
            this.btn_del_employee.Click += new System.EventHandler(this.btn_del_employee_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(259, 203);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(669, 29);
            this.txt_surname.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(165, 303);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 25);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Адреса";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(259, 267);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(669, 29);
            this.txt_phone.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(165, 271);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 25);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Телефон";
            // 
            // btn_update_employee
            // 
            this.btn_update_employee.Location = new System.Drawing.Point(0, 220);
            this.btn_update_employee.Name = "btn_update_employee";
            this.btn_update_employee.Size = new System.Drawing.Size(143, 44);
            this.btn_update_employee.TabIndex = 10;
            this.btn_update_employee.Text = "Обновити дані";
            this.btn_update_employee.Click += new System.EventHandler(this.btn_update_employee_Click);
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(259, 235);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(669, 29);
            this.txt_gender.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(149, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 220);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_clear_job);
            this.metroTabPage2.Controls.Add(this.btn_del_job);
            this.metroTabPage2.Controls.Add(this.btn_update_job);
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.pictureBox2);
            this.metroTabPage2.Controls.Add(this.btn_add_job);
            this.metroTabPage2.Controls.Add(this.dataGridView2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(934, 378);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Посади";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // btn_clear_job
            // 
            this.btn_clear_job.Location = new System.Drawing.Point(3, 330);
            this.btn_clear_job.Name = "btn_clear_job";
            this.btn_clear_job.Size = new System.Drawing.Size(154, 39);
            this.btn_clear_job.TabIndex = 11;
            this.btn_clear_job.Text = "Очистити поля";
            this.btn_clear_job.Click += new System.EventHandler(this.btn_clear_job_Click);
            // 
            // btn_del_job
            // 
            this.btn_del_job.Location = new System.Drawing.Point(3, 285);
            this.btn_del_job.Name = "btn_del_job";
            this.btn_del_job.Size = new System.Drawing.Size(154, 39);
            this.btn_del_job.TabIndex = 10;
            this.btn_del_job.Text = "Видалити";
            this.btn_del_job.Click += new System.EventHandler(this.btn_del_job_Click);
            // 
            // btn_update_job
            // 
            this.btn_update_job.Location = new System.Drawing.Point(3, 215);
            this.btn_update_job.Name = "btn_update_job";
            this.btn_update_job.Size = new System.Drawing.Size(154, 39);
            this.btn_update_job.TabIndex = 9;
            this.btn_update_job.Text = "Обновити дані";
            this.btn_update_job.Click += new System.EventHandler(this.btn_update_job_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txt_jobname);
            this.groupBox1.Location = new System.Drawing.Point(163, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(22, 54);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 25);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Посада";
            // 
            // txt_jobname
            // 
            this.txt_jobname.Location = new System.Drawing.Point(106, 54);
            this.txt_jobname.Name = "txt_jobname";
            this.txt_jobname.Size = new System.Drawing.Size(656, 30);
            this.txt_jobname.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_add_job
            // 
            this.btn_add_job.Enabled = false;
            this.btn_add_job.Location = new System.Drawing.Point(3, 170);
            this.btn_add_job.Name = "btn_add_job";
            this.btn_add_job.Size = new System.Drawing.Size(153, 39);
            this.btn_add_job.TabIndex = 5;
            this.btn_add_job.Text = "Додати посаду";
            this.btn_add_job.Visible = false;
            this.btn_add_job.Click += new System.EventHandler(this.btn_add_job_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobnameDataGridViewTextBoxColumn,
            this.jobidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jobBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(163, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(768, 237);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // jobnameDataGridViewTextBoxColumn
            // 
            this.jobnameDataGridViewTextBoxColumn.DataPropertyName = "job_name";
            this.jobnameDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.jobnameDataGridViewTextBoxColumn.Name = "jobnameDataGridViewTextBoxColumn";
            this.jobnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobnameDataGridViewTextBoxColumn.Width = 720;
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "job_id";
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobidDataGridViewTextBoxColumn.Visible = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 497);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.Resizable = false;
            this.Text = "Працівники";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigendbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sigendbDataSet sigendbDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private sigendbDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private sigendbDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroButton btn_del_employee;
        private MetroFramework.Controls.MetroButton btn_update_employee;
        private MetroFramework.Controls.MetroButton btn_add_emp;
        private MetroFramework.Controls.MetroComboBox combo_job;
        private MetroFramework.Controls.MetroTextBox txt_adress;
        private MetroFramework.Controls.MetroTextBox txt_phone;
        private MetroFramework.Controls.MetroTextBox txt_gender;
        private MetroFramework.Controls.MetroTextBox txt_surname;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroButton btn_add_job;
        private MetroFramework.Controls.MetroTextBox txt_jobname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeejobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btn_clear_job;
        private MetroFramework.Controls.MetroButton btn_del_job;
        private MetroFramework.Controls.MetroButton btn_update_job;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btn_clear_employee;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}