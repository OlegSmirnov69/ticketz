namespace Kursova
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.concert_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertperformeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertplaceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concerttcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concerttpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sigendbDataSet = new Kursova.sigendbDataSet();
            this.concertTableAdapter = new Kursova.sigendbDataSetTableAdapters.concertTableAdapter();
            this.ComboBoxperformer = new MetroFramework.Controls.MetroComboBox();
            this.performerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxplace = new MetroFramework.Controls.MetroComboBox();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxEmployee = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxcount = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxprice = new MetroFramework.Controls.MetroTextBox();
            this.performerTableAdapter = new Kursova.sigendbDataSetTableAdapters.performerTableAdapter();
            this.placeTableAdapter = new Kursova.sigendbDataSetTableAdapters.placeTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Kursova.sigendbDataSetTableAdapters.employeeTableAdapter();
            this.TextBoxconcert_title = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxplace_hall = new MetroFramework.Controls.MetroComboBox();
            this.hallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallTableAdapter = new Kursova.sigendbDataSetTableAdapters.hallTableAdapter();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.combo_htype = new MetroFramework.Controls.MetroComboBox();
            this.htypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_htype = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.lbl_ttime = new MetroFramework.Controls.MetroTextBox();
            this.lbl_tdate = new MetroFramework.Controls.MetroTextBox();
            this.lbl_name = new MetroFramework.Controls.MetroTextBox();
            this.lbl_surname = new MetroFramework.Controls.MetroTextBox();
            this.lbl_description = new System.Windows.Forms.RichTextBox();
            this.lbl_grade = new MetroFramework.Controls.MetroTextBox();
            this.lbl_adress = new MetroFramework.Controls.MetroTextBox();
            this.lbl_album = new MetroFramework.Controls.MetroTextBox();
            this.lbl_price = new MetroFramework.Controls.MetroTextBox();
            this.lbl_count = new MetroFramework.Controls.MetroTextBox();
            this.lbl_date = new MetroFramework.Controls.MetroTextBox();
            this.lbl_hall = new MetroFramework.Controls.MetroTextBox();
            this.lbl_performer = new MetroFramework.Controls.MetroTextBox();
            this.lbl_place = new MetroFramework.Controls.MetroTextBox();
            this.lbl_title = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketconcertidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickettimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketemployeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickethallidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_refresh = new MetroFramework.Controls.MetroButton();
            this.ticketTableAdapter = new Kursova.sigendbDataSetTableAdapters.ticketTableAdapter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.htypeTableAdapter = new Kursova.sigendbDataSetTableAdapters.htypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigendbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htypeBindingSource)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
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
            this.concert_title,
            this.concertidDataGridViewTextBoxColumn,
            this.concertperformeridDataGridViewTextBoxColumn,
            this.concertdateDataGridViewTextBoxColumn,
            this.concertplaceidDataGridViewTextBoxColumn,
            this.concerttcountDataGridViewTextBoxColumn,
            this.concerttpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.concertBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(852, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // concert_title
            // 
            this.concert_title.DataPropertyName = "concert_title";
            this.concert_title.HeaderText = "Заголовок";
            this.concert_title.Name = "concert_title";
            this.concert_title.ReadOnly = true;
            this.concert_title.Width = 550;
            // 
            // concertidDataGridViewTextBoxColumn
            // 
            this.concertidDataGridViewTextBoxColumn.DataPropertyName = "concert_id";
            this.concertidDataGridViewTextBoxColumn.HeaderText = "concert_id";
            this.concertidDataGridViewTextBoxColumn.Name = "concertidDataGridViewTextBoxColumn";
            this.concertidDataGridViewTextBoxColumn.ReadOnly = true;
            this.concertidDataGridViewTextBoxColumn.Visible = false;
            // 
            // concertperformeridDataGridViewTextBoxColumn
            // 
            this.concertperformeridDataGridViewTextBoxColumn.DataPropertyName = "concert_performer_id";
            this.concertperformeridDataGridViewTextBoxColumn.HeaderText = "concert_performer_id";
            this.concertperformeridDataGridViewTextBoxColumn.Name = "concertperformeridDataGridViewTextBoxColumn";
            this.concertperformeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.concertperformeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // concertdateDataGridViewTextBoxColumn
            // 
            this.concertdateDataGridViewTextBoxColumn.DataPropertyName = "concert_date";
            this.concertdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.concertdateDataGridViewTextBoxColumn.Name = "concertdateDataGridViewTextBoxColumn";
            this.concertdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concertplaceidDataGridViewTextBoxColumn
            // 
            this.concertplaceidDataGridViewTextBoxColumn.DataPropertyName = "concert_place_id";
            this.concertplaceidDataGridViewTextBoxColumn.HeaderText = "concert_place_id";
            this.concertplaceidDataGridViewTextBoxColumn.Name = "concertplaceidDataGridViewTextBoxColumn";
            this.concertplaceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.concertplaceidDataGridViewTextBoxColumn.Visible = false;
            // 
            // concerttcountDataGridViewTextBoxColumn
            // 
            this.concerttcountDataGridViewTextBoxColumn.DataPropertyName = "concert_tcount";
            this.concerttcountDataGridViewTextBoxColumn.HeaderText = "К-сть квитків";
            this.concerttcountDataGridViewTextBoxColumn.Name = "concerttcountDataGridViewTextBoxColumn";
            this.concerttcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concerttpriceDataGridViewTextBoxColumn
            // 
            this.concerttpriceDataGridViewTextBoxColumn.DataPropertyName = "concert_tprice";
            this.concerttpriceDataGridViewTextBoxColumn.HeaderText = "Ціна за квиток";
            this.concerttpriceDataGridViewTextBoxColumn.Name = "concerttpriceDataGridViewTextBoxColumn";
            this.concerttpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concertBindingSource
            // 
            this.concertBindingSource.DataMember = "concert";
            this.concertBindingSource.DataSource = this.sigendbDataSet;
            // 
            // sigendbDataSet
            // 
            this.sigendbDataSet.DataSetName = "sigendbDataSet";
            this.sigendbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concertTableAdapter
            // 
            this.concertTableAdapter.ClearBeforeFill = true;
            // 
            // ComboBoxperformer
            // 
            this.ComboBoxperformer.DataSource = this.performerBindingSource;
            this.ComboBoxperformer.DisplayMember = "performer_name";
            this.ComboBoxperformer.Enabled = false;
            this.ComboBoxperformer.FormattingEnabled = true;
            this.ComboBoxperformer.ItemHeight = 23;
            this.ComboBoxperformer.Location = new System.Drawing.Point(154, 256);
            this.ComboBoxperformer.Name = "ComboBoxperformer";
            this.ComboBoxperformer.Size = new System.Drawing.Size(282, 29);
            this.ComboBoxperformer.TabIndex = 6;
            this.ComboBoxperformer.ValueMember = "performer_id";
            this.ComboBoxperformer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxperformer_SelectedIndexChanged);
            // 
            // performerBindingSource
            // 
            this.performerBindingSource.DataMember = "performer";
            this.performerBindingSource.DataSource = this.sigendbDataSet;
            // 
            // ComboBoxplace
            // 
            this.ComboBoxplace.DataSource = this.placeBindingSource;
            this.ComboBoxplace.DisplayMember = "place_name";
            this.ComboBoxplace.Enabled = false;
            this.ComboBoxplace.FormattingEnabled = true;
            this.ComboBoxplace.ItemHeight = 23;
            this.ComboBoxplace.Location = new System.Drawing.Point(154, 290);
            this.ComboBoxplace.Name = "ComboBoxplace";
            this.ComboBoxplace.Size = new System.Drawing.Size(282, 29);
            this.ComboBoxplace.TabIndex = 7;
            this.ComboBoxplace.ValueMember = "place_id";
            this.ComboBoxplace.SelectedIndexChanged += new System.EventHandler(this.ComboBoxplace_SelectedIndexChanged);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "place";
            this.placeBindingSource.DataSource = this.sigendbDataSet;
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.ItemHeight = 23;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(154, 358);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(282, 29);
            this.ComboBoxEmployee.TabIndex = 8;
            // 
            // TextBoxcount
            // 
            this.TextBoxcount.Enabled = false;
            this.TextBoxcount.Location = new System.Drawing.Point(442, 310);
            this.TextBoxcount.Name = "TextBoxcount";
            this.TextBoxcount.ReadOnly = true;
            this.TextBoxcount.Size = new System.Drawing.Size(121, 23);
            this.TextBoxcount.TabIndex = 9;
            this.TextBoxcount.Visible = false;
            // 
            // TextBoxprice
            // 
            this.TextBoxprice.Location = new System.Drawing.Point(590, 237);
            this.TextBoxprice.Name = "TextBoxprice";
            this.TextBoxprice.ReadOnly = true;
            this.TextBoxprice.Size = new System.Drawing.Size(262, 23);
            this.TextBoxprice.TabIndex = 10;
            // 
            // performerTableAdapter
            // 
            this.performerTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
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
            // TextBoxconcert_title
            // 
            this.TextBoxconcert_title.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxconcert_title.Location = new System.Drawing.Point(0, 209);
            this.TextBoxconcert_title.Name = "TextBoxconcert_title";
            this.TextBoxconcert_title.ReadOnly = true;
            this.TextBoxconcert_title.Size = new System.Drawing.Size(436, 30);
            this.TextBoxconcert_title.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDown1.Location = new System.Drawing.Point(590, 209);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(262, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ComboBoxplace_hall
            // 
            this.ComboBoxplace_hall.DataSource = this.hallBindingSource;
            this.ComboBoxplace_hall.DisplayMember = "hall_name";
            this.ComboBoxplace_hall.FormattingEnabled = true;
            this.ComboBoxplace_hall.ItemHeight = 23;
            this.ComboBoxplace_hall.Location = new System.Drawing.Point(153, 324);
            this.ComboBoxplace_hall.Name = "ComboBoxplace_hall";
            this.ComboBoxplace_hall.Size = new System.Drawing.Size(179, 29);
            this.ComboBoxplace_hall.TabIndex = 14;
            this.ComboBoxplace_hall.ValueMember = "hall_id";
            this.ComboBoxplace_hall.SelectedIndexChanged += new System.EventHandler(this.ComboBoxplace_hall_SelectedIndexChanged);
            // 
            // hallBindingSource
            // 
            this.hallBindingSource.DataMember = "hall";
            this.hallBindingSource.DataSource = this.sigendbDataSet;
            // 
            // hallTableAdapter
            // 
            this.hallTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTabControl1.Location = new System.Drawing.Point(180, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(880, 429);
            this.metroTabControl1.TabIndex = 16;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTile4);
            this.metroTabPage2.Controls.Add(this.combo_htype);
            this.metroTabPage2.Controls.Add(this.txt_htype);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.ComboBoxplace_hall);
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.Controls.Add(this.numericUpDown1);
            this.metroTabPage2.Controls.Add(this.TextBoxprice);
            this.metroTabPage2.Controls.Add(this.TextBoxconcert_title);
            this.metroTabPage2.Controls.Add(this.ComboBoxperformer);
            this.metroTabPage2.Controls.Add(this.ComboBoxplace);
            this.metroTabPage2.Controls.Add(this.ComboBoxEmployee);
            this.metroTabPage2.Controls.Add(this.TextBoxcount);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(872, 390);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Продаж квитків";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(590, 266);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(262, 121);
            this.metroTile4.TabIndex = 25;
            this.metroTile4.Text = "Продаж";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // combo_htype
            // 
            this.combo_htype.DataSource = this.htypeBindingSource;
            this.combo_htype.DisplayMember = "htype_id";
            this.combo_htype.Enabled = false;
            this.combo_htype.FormattingEnabled = true;
            this.combo_htype.ItemHeight = 23;
            this.combo_htype.Location = new System.Drawing.Point(442, 339);
            this.combo_htype.Name = "combo_htype";
            this.combo_htype.Size = new System.Drawing.Size(121, 29);
            this.combo_htype.TabIndex = 24;
            this.combo_htype.ValueMember = "htype_id";
            this.combo_htype.Visible = false;
            // 
            // htypeBindingSource
            // 
            this.htypeBindingSource.DataMember = "htype";
            this.htypeBindingSource.DataSource = this.sigendbDataSet;
            // 
            // txt_htype
            // 
            this.txt_htype.Location = new System.Drawing.Point(338, 324);
            this.txt_htype.Name = "txt_htype";
            this.txt_htype.ReadOnly = true;
            this.txt_htype.Size = new System.Drawing.Size(98, 29);
            this.txt_htype.TabIndex = 23;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(460, 241);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(43, 19);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "ЦІНА:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(460, 212);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(127, 19);
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "КІЛЬКІСТЬ КВИТКІВ:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 358);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(85, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "ПРАЦІВНИК:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(1, 327);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(129, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "ЗАЛ/ЗОНА/СЦЕНА:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(1, 292);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(142, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "МІСЦЕ ПРОВЕДЕННЯ:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1, 257);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "ВИКОНАВЕЦЬ:";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile3);
            this.metroTabPage1.Controls.Add(this.lbl_ttime);
            this.metroTabPage1.Controls.Add(this.lbl_tdate);
            this.metroTabPage1.Controls.Add(this.lbl_name);
            this.metroTabPage1.Controls.Add(this.lbl_surname);
            this.metroTabPage1.Controls.Add(this.lbl_description);
            this.metroTabPage1.Controls.Add(this.lbl_grade);
            this.metroTabPage1.Controls.Add(this.lbl_adress);
            this.metroTabPage1.Controls.Add(this.lbl_album);
            this.metroTabPage1.Controls.Add(this.lbl_price);
            this.metroTabPage1.Controls.Add(this.lbl_count);
            this.metroTabPage1.Controls.Add(this.lbl_date);
            this.metroTabPage1.Controls.Add(this.lbl_hall);
            this.metroTabPage1.Controls.Add(this.lbl_performer);
            this.metroTabPage1.Controls.Add(this.lbl_place);
            this.metroTabPage1.Controls.Add(this.lbl_title);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.dataGridView2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(872, 390);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Перегляд/Друк квитків";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(666, 176);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(175, 211);
            this.metroTile3.TabIndex = 47;
            this.metroTile3.Text = "Друкувати";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // lbl_ttime
            // 
            this.lbl_ttime.Location = new System.Drawing.Point(427, 259);
            this.lbl_ttime.Name = "lbl_ttime";
            this.lbl_ttime.ReadOnly = true;
            this.lbl_ttime.Size = new System.Drawing.Size(219, 23);
            this.lbl_ttime.TabIndex = 46;
            // 
            // lbl_tdate
            // 
            this.lbl_tdate.Location = new System.Drawing.Point(427, 230);
            this.lbl_tdate.Name = "lbl_tdate";
            this.lbl_tdate.ReadOnly = true;
            this.lbl_tdate.Size = new System.Drawing.Size(219, 23);
            this.lbl_tdate.TabIndex = 45;
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(237, 365);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.ReadOnly = true;
            this.lbl_name.Size = new System.Drawing.Size(117, 23);
            this.lbl_name.TabIndex = 44;
            // 
            // lbl_surname
            // 
            this.lbl_surname.Location = new System.Drawing.Point(237, 340);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.ReadOnly = true;
            this.lbl_surname.Size = new System.Drawing.Size(117, 23);
            this.lbl_surname.TabIndex = 43;
            // 
            // lbl_description
            // 
            this.lbl_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_description.Location = new System.Drawing.Point(362, 288);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.ReadOnly = true;
            this.lbl_description.Size = new System.Drawing.Size(284, 100);
            this.lbl_description.TabIndex = 42;
            this.lbl_description.Text = "";
            // 
            // lbl_grade
            // 
            this.lbl_grade.Location = new System.Drawing.Point(427, 201);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.ReadOnly = true;
            this.lbl_grade.Size = new System.Drawing.Size(219, 23);
            this.lbl_grade.TabIndex = 41;
            // 
            // lbl_adress
            // 
            this.lbl_adress.Location = new System.Drawing.Point(6, 259);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.ReadOnly = true;
            this.lbl_adress.Size = new System.Drawing.Size(348, 23);
            this.lbl_adress.TabIndex = 40;
            // 
            // lbl_album
            // 
            this.lbl_album.Location = new System.Drawing.Point(427, 172);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.ReadOnly = true;
            this.lbl_album.Size = new System.Drawing.Size(219, 23);
            this.lbl_album.TabIndex = 39;
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(131, 365);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.ReadOnly = true;
            this.lbl_price.Size = new System.Drawing.Size(100, 23);
            this.lbl_price.TabIndex = 38;
            // 
            // lbl_count
            // 
            this.lbl_count.Location = new System.Drawing.Point(131, 340);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.ReadOnly = true;
            this.lbl_count.Size = new System.Drawing.Size(100, 23);
            this.lbl_count.TabIndex = 37;
            // 
            // lbl_date
            // 
            this.lbl_date.Location = new System.Drawing.Point(131, 314);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.ReadOnly = true;
            this.lbl_date.Size = new System.Drawing.Size(100, 23);
            this.lbl_date.TabIndex = 36;
            // 
            // lbl_hall
            // 
            this.lbl_hall.Location = new System.Drawing.Point(6, 288);
            this.lbl_hall.Name = "lbl_hall";
            this.lbl_hall.ReadOnly = true;
            this.lbl_hall.Size = new System.Drawing.Size(348, 23);
            this.lbl_hall.TabIndex = 35;
            // 
            // lbl_performer
            // 
            this.lbl_performer.Location = new System.Drawing.Point(85, 201);
            this.lbl_performer.Name = "lbl_performer";
            this.lbl_performer.ReadOnly = true;
            this.lbl_performer.Size = new System.Drawing.Size(269, 23);
            this.lbl_performer.TabIndex = 34;
            // 
            // lbl_place
            // 
            this.lbl_place.Location = new System.Drawing.Point(6, 230);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.ReadOnly = true;
            this.lbl_place.Size = new System.Drawing.Size(348, 23);
            this.lbl_place.TabIndex = 33;
            // 
            // lbl_title
            // 
            this.lbl_title.Location = new System.Drawing.Point(6, 172);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.ReadOnly = true;
            this.lbl_title.Size = new System.Drawing.Size(348, 23);
            this.lbl_title.TabIndex = 32;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(237, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Видав:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 365);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "Ціна:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 340);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "К-сть квитків:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 314);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Дата проведення:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(366, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Оцінка:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(362, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Альбом:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Виконавець: ";
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
            this.ticketidDataGridViewTextBoxColumn,
            this.ticketconcertidDataGridViewTextBoxColumn,
            this.ticketdateDataGridViewTextBoxColumn,
            this.tickettimeDataGridViewTextBoxColumn,
            this.ticketpriceDataGridViewTextBoxColumn,
            this.ticketcountDataGridViewTextBoxColumn,
            this.ticketemployeeidDataGridViewTextBoxColumn,
            this.tickethallidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ticketBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(4, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(837, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            this.ticketidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketidDataGridViewTextBoxColumn.Width = 200;
            // 
            // ticketconcertidDataGridViewTextBoxColumn
            // 
            this.ticketconcertidDataGridViewTextBoxColumn.DataPropertyName = "ticket_concert_id";
            this.ticketconcertidDataGridViewTextBoxColumn.HeaderText = "ticket_concert_id";
            this.ticketconcertidDataGridViewTextBoxColumn.Name = "ticketconcertidDataGridViewTextBoxColumn";
            this.ticketconcertidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketconcertidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketdateDataGridViewTextBoxColumn
            // 
            this.ticketdateDataGridViewTextBoxColumn.DataPropertyName = "ticket_date";
            this.ticketdateDataGridViewTextBoxColumn.HeaderText = "Дата видачі";
            this.ticketdateDataGridViewTextBoxColumn.Name = "ticketdateDataGridViewTextBoxColumn";
            this.ticketdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // tickettimeDataGridViewTextBoxColumn
            // 
            this.tickettimeDataGridViewTextBoxColumn.DataPropertyName = "ticket_time";
            this.tickettimeDataGridViewTextBoxColumn.HeaderText = "Час видачі";
            this.tickettimeDataGridViewTextBoxColumn.Name = "tickettimeDataGridViewTextBoxColumn";
            this.tickettimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tickettimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // ticketpriceDataGridViewTextBoxColumn
            // 
            this.ticketpriceDataGridViewTextBoxColumn.DataPropertyName = "ticket_price";
            this.ticketpriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketpriceDataGridViewTextBoxColumn.Name = "ticketpriceDataGridViewTextBoxColumn";
            this.ticketpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketcountDataGridViewTextBoxColumn
            // 
            this.ticketcountDataGridViewTextBoxColumn.DataPropertyName = "ticket_count";
            this.ticketcountDataGridViewTextBoxColumn.HeaderText = "Кількість місць";
            this.ticketcountDataGridViewTextBoxColumn.Name = "ticketcountDataGridViewTextBoxColumn";
            this.ticketcountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketemployeeidDataGridViewTextBoxColumn
            // 
            this.ticketemployeeidDataGridViewTextBoxColumn.DataPropertyName = "ticket_employee_id";
            this.ticketemployeeidDataGridViewTextBoxColumn.HeaderText = "ticket_employee_id";
            this.ticketemployeeidDataGridViewTextBoxColumn.Name = "ticketemployeeidDataGridViewTextBoxColumn";
            this.ticketemployeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketemployeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tickethallidDataGridViewTextBoxColumn
            // 
            this.tickethallidDataGridViewTextBoxColumn.DataPropertyName = "ticket_hall_id";
            this.tickethallidDataGridViewTextBoxColumn.HeaderText = "ticket_hall_id";
            this.tickethallidDataGridViewTextBoxColumn.Name = "tickethallidDataGridViewTextBoxColumn";
            this.tickethallidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tickethallidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.sigendbDataSet;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(886, 30);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(150, 30);
            this.btn_refresh.TabIndex = 21;
            this.btn_refresh.Text = "Оновити таблицю";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.metroPanel1.Controls.Add(this.pictureBox8);
            this.metroPanel1.Controls.Add(this.metroTile8);
            this.metroPanel1.Controls.Add(this.metroTile7);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroTile5);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(167, 509);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1, -5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(167, 87);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // metroTile8
            // 
            this.metroTile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.metroTile8.CustomBackground = true;
            this.metroTile8.Location = new System.Drawing.Point(0, 460);
            this.metroTile8.Margin = new System.Windows.Forms.Padding(1);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(168, 40);
            this.metroTile8.TabIndex = 9;
            this.metroTile8.Text = "Вихід";
            this.metroTile8.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile8.TileImage")));
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.metroTile7.CustomBackground = true;
            this.metroTile7.Location = new System.Drawing.Point(0, 418);
            this.metroTile7.Margin = new System.Windows.Forms.Padding(1);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(168, 40);
            this.metroTile7.TabIndex = 8;
            this.metroTile7.Text = "Сервіс";
            this.metroTile7.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile7.TileImage")));
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(1, 86);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(168, 40);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "На головну";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.metroTile5.CustomBackground = true;
            this.metroTile5.Location = new System.Drawing.Point(1, 170);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(1);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(168, 40);
            this.metroTile5.TabIndex = 6;
            this.metroTile5.Text = "Квитки";
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.metroTile2.CustomBackground = true;
            this.metroTile2.Location = new System.Drawing.Point(1, 128);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(1);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(168, 40);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Концерти";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // htypeTableAdapter
            // 
            this.htypeTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 509);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btn_refresh);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "                       Продаж квитків";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigendbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htypeBindingSource)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sigendbDataSet sigendbDataSet;
        private System.Windows.Forms.BindingSource concertBindingSource;
        private sigendbDataSetTableAdapters.concertTableAdapter concertTableAdapter;
        private MetroFramework.Controls.MetroComboBox ComboBoxplace;
        private MetroFramework.Controls.MetroComboBox ComboBoxEmployee;
        private MetroFramework.Controls.MetroTextBox TextBoxcount;
        private MetroFramework.Controls.MetroTextBox TextBoxprice;
        private System.Windows.Forms.BindingSource performerBindingSource;
        private sigendbDataSetTableAdapters.performerTableAdapter performerTableAdapter;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private sigendbDataSetTableAdapters.placeTableAdapter placeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private sigendbDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private MetroFramework.Controls.MetroTextBox TextBoxconcert_title;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroComboBox ComboBoxplace_hall;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private sigendbDataSetTableAdapters.hallTableAdapter hallTableAdapter;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private sigendbDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton btn_refresh;
        private MetroFramework.Controls.MetroTextBox txt_htype;
        private MetroFramework.Controls.MetroComboBox ComboBoxperformer;
        private MetroFramework.Controls.MetroComboBox combo_htype;
        private System.Windows.Forms.BindingSource htypeBindingSource;
        private sigendbDataSetTableAdapters.htypeTableAdapter htypeTableAdapter;
        private MetroFramework.Controls.MetroTextBox lbl_performer;
        private MetroFramework.Controls.MetroTextBox lbl_place;
        private MetroFramework.Controls.MetroTextBox lbl_title;
        private MetroFramework.Controls.MetroTextBox lbl_price;
        private MetroFramework.Controls.MetroTextBox lbl_count;
        private MetroFramework.Controls.MetroTextBox lbl_date;
        private MetroFramework.Controls.MetroTextBox lbl_hall;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox lbl_ttime;
        private MetroFramework.Controls.MetroTextBox lbl_tdate;
        private MetroFramework.Controls.MetroTextBox lbl_name;
        private MetroFramework.Controls.MetroTextBox lbl_surname;
        private System.Windows.Forms.RichTextBox lbl_description;
        private MetroFramework.Controls.MetroTextBox lbl_grade;
        private MetroFramework.Controls.MetroTextBox lbl_adress;
        private MetroFramework.Controls.MetroTextBox lbl_album;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.DataGridViewTextBoxColumn concert_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertperformeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertplaceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concerttcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concerttpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketconcertidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketemployeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickethallidDataGridViewTextBoxColumn;
    }
}