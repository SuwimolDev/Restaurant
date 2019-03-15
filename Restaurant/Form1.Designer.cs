namespace Restaurant
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Tab1 = new System.Windows.Forms.DataGridView();
            this.rd_Total = new System.Windows.Forms.RadioButton();
            this.rd_Pay = new System.Windows.Forms.RadioButton();
            this.rd_Notpay = new System.Windows.Forms.RadioButton();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numeric_Table = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Change = new System.Windows.Forms.TextBox();
            this.txt_Receive = new System.Windows.Forms.TextBox();
            this.txt_SumPrice = new System.Windows.Forms.TextBox();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Rigth = new System.Windows.Forms.Button();
            this.txt_Order = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Menu = new System.Windows.Forms.DataGridView();
            this.dgv_Detailfood = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Date2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.CheckMenu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Menu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDetail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tab1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detailfood)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_Tab1);
            this.tabPage1.Controls.Add(this.rd_Total);
            this.tabPage1.Controls.Add(this.rd_Pay);
            this.tabPage1.Controls.Add(this.rd_Notpay);
            this.tabPage1.Controls.Add(this.dtp_Date);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "รายการลูกค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "วันที่";
            // 
            // dgv_Tab1
            // 
            this.dgv_Tab1.AllowUserToAddRows = false;
            this.dgv_Tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.table,
            this.Time,
            this.Price,
            this.Status});
            this.dgv_Tab1.Location = new System.Drawing.Point(60, 116);
            this.dgv_Tab1.Name = "dgv_Tab1";
            this.dgv_Tab1.ReadOnly = true;
            this.dgv_Tab1.RowTemplate.Height = 24;
            this.dgv_Tab1.Size = new System.Drawing.Size(1021, 515);
            this.dgv_Tab1.TabIndex = 4;
            this.dgv_Tab1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tab1_CellClick);
            this.dgv_Tab1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Tab1_CellFormatting);
            // 
            // rd_Total
            // 
            this.rd_Total.AutoSize = true;
            this.rd_Total.Location = new System.Drawing.Point(545, 47);
            this.rd_Total.Name = "rd_Total";
            this.rd_Total.Size = new System.Drawing.Size(68, 21);
            this.rd_Total.TabIndex = 3;
            this.rd_Total.TabStop = true;
            this.rd_Total.Text = "ทั้งหมด";
            this.rd_Total.UseVisualStyleBackColor = true;
            this.rd_Total.CheckedChanged += new System.EventHandler(this.rd_Total_CheckedChanged);
            // 
            // rd_Pay
            // 
            this.rd_Pay.AutoSize = true;
            this.rd_Pay.Location = new System.Drawing.Point(435, 47);
            this.rd_Pay.Name = "rd_Pay";
            this.rd_Pay.Size = new System.Drawing.Size(71, 21);
            this.rd_Pay.TabIndex = 2;
            this.rd_Pay.TabStop = true;
            this.rd_Pay.Text = "จ่ายแล้ว";
            this.rd_Pay.UseVisualStyleBackColor = true;
            this.rd_Pay.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_Notpay
            // 
            this.rd_Notpay.AutoSize = true;
            this.rd_Notpay.Location = new System.Drawing.Point(336, 47);
            this.rd_Notpay.Name = "rd_Notpay";
            this.rd_Notpay.Size = new System.Drawing.Size(77, 21);
            this.rd_Notpay.TabIndex = 1;
            this.rd_Notpay.TabStop = true;
            this.rd_Notpay.Text = "ยังไม่จ่าย";
            this.rd_Notpay.UseVisualStyleBackColor = true;
            this.rd_Notpay.CheckedChanged += new System.EventHandler(this.rd_Notpay_CheckedChanged);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(108, 44);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 22);
            this.dtp_Date.TabIndex = 0;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.lbl_status);
            this.tabPage2.Controls.Add(this.btn_Edit);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dtp_Time);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.numeric_Table);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_Change);
            this.tabPage2.Controls.Add(this.txt_Receive);
            this.tabPage2.Controls.Add(this.txt_SumPrice);
            this.tabPage2.Controls.Add(this.btn_Left);
            this.tabPage2.Controls.Add(this.btn_Rigth);
            this.tabPage2.Controls.Add(this.txt_Order);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgv_Menu);
            this.tabPage2.Controls.Add(this.dgv_Detailfood);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtp_Date2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สั่งอาหาร";
            // 
            // numeric_Table
            // 
            this.numeric_Table.Location = new System.Drawing.Point(74, 61);
            this.numeric_Table.Name = "numeric_Table";
            this.numeric_Table.Size = new System.Drawing.Size(120, 22);
            this.numeric_Table.TabIndex = 20;
            this.numeric_Table.ValueChanged += new System.EventHandler(this.numeric_Table_ValueChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(1046, 574);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 45);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "บันทึก";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1087, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "บาท";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1087, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "บาท";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1087, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ทอน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(915, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "รับเงิน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(915, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "รวม";
            // 
            // txt_Change
            // 
            this.txt_Change.Enabled = false;
            this.txt_Change.Location = new System.Drawing.Point(977, 473);
            this.txt_Change.Name = "txt_Change";
            this.txt_Change.Size = new System.Drawing.Size(94, 22);
            this.txt_Change.TabIndex = 12;
            // 
            // txt_Receive
            // 
            this.txt_Receive.Location = new System.Drawing.Point(977, 412);
            this.txt_Receive.Name = "txt_Receive";
            this.txt_Receive.Size = new System.Drawing.Size(94, 22);
            this.txt_Receive.TabIndex = 11;
            this.txt_Receive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Receive_KeyPress);
            this.txt_Receive.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Receive_KeyUp);
            // 
            // txt_SumPrice
            // 
            this.txt_SumPrice.Enabled = false;
            this.txt_SumPrice.Location = new System.Drawing.Point(977, 348);
            this.txt_SumPrice.Name = "txt_SumPrice";
            this.txt_SumPrice.Size = new System.Drawing.Size(94, 22);
            this.txt_SumPrice.TabIndex = 10;
            // 
            // btn_Left
            // 
            this.btn_Left.BackColor = System.Drawing.Color.White;
            this.btn_Left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Left.Image = global::Restaurant.Properties.Resources.arrows_147746_960_7201;
            this.btn_Left.Location = new System.Drawing.Point(411, 394);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(66, 31);
            this.btn_Left.TabIndex = 9;
            this.btn_Left.UseVisualStyleBackColor = false;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Rigth
            // 
            this.btn_Rigth.BackColor = System.Drawing.Color.White;
            this.btn_Rigth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Rigth.Image = global::Restaurant.Properties.Resources.arrows_147744_960_7201;
            this.btn_Rigth.Location = new System.Drawing.Point(411, 295);
            this.btn_Rigth.Name = "btn_Rigth";
            this.btn_Rigth.Size = new System.Drawing.Size(66, 31);
            this.btn_Rigth.TabIndex = 8;
            this.btn_Rigth.UseVisualStyleBackColor = false;
            this.btn_Rigth.Click += new System.EventHandler(this.btn_Rigth_Click);
            // 
            // txt_Order
            // 
            this.txt_Order.Enabled = false;
            this.txt_Order.Location = new System.Drawing.Point(74, 16);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Size = new System.Drawing.Size(120, 22);
            this.txt_Order.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order";
            // 
            // dgv_Menu
            // 
            this.dgv_Menu.AllowUserToAddRows = false;
            this.dgv_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckMenu,
            this.Menu1,
            this.Menu,
            this.PriceMenu});
            this.dgv_Menu.Location = new System.Drawing.Point(8, 137);
            this.dgv_Menu.Name = "dgv_Menu";
            this.dgv_Menu.RowTemplate.Height = 24;
            this.dgv_Menu.Size = new System.Drawing.Size(395, 464);
            this.dgv_Menu.TabIndex = 5;
            // 
            // dgv_Detailfood
            // 
            this.dgv_Detailfood.AllowUserToAddRows = false;
            this.dgv_Detailfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detailfood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckDetail,
            this.MenuId1,
            this.MenuFood,
            this.Price1,
            this.Qty});
            this.dgv_Detailfood.Location = new System.Drawing.Point(483, 137);
            this.dgv_Detailfood.Name = "dgv_Detailfood";
            this.dgv_Detailfood.RowTemplate.Height = 24;
            this.dgv_Detailfood.Size = new System.Drawing.Size(411, 464);
            this.dgv_Detailfood.TabIndex = 4;
            this.dgv_Detailfood.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detailfood_CellDoubleClick);
            this.dgv_Detailfood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detailfood_CellValueChanged);
            this.dgv_Detailfood.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_Detailfood_CurrentCellDirtyStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "โต๊ะ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "วันที่สั่ง";
            // 
            // dtp_Date2
            // 
            this.dtp_Date2.Enabled = false;
            this.dtp_Date2.Location = new System.Drawing.Point(935, 17);
            this.dtp_Date2.Name = "dtp_Date2";
            this.dtp_Date2.Size = new System.Drawing.Size(200, 22);
            this.dtp_Date2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(890, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "เวลา";
            // 
            // dtp_Time
            // 
            this.dtp_Time.Enabled = false;
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(935, 51);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(200, 22);
            this.dtp_Time.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(135, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "เมนูอาหาร";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(604, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "รายการอาหารที่สั่ง";
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            // 
            // table
            // 
            this.table.HeaderText = "โต๊ะ";
            this.table.Name = "table";
            // 
            // Time
            // 
            this.Time.HeaderText = "เวลา";
            this.Time.Name = "Time";
            // 
            // Price
            // 
            this.Price.HeaderText = "ราคา";
            this.Price.Name = "Price";
            // 
            // Status
            // 
            this.Status.HeaderText = "สถานะ";
            this.Status.Name = "Status";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(935, 574);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(93, 45);
            this.btn_Edit.TabIndex = 25;
            this.btn_Edit.Text = "เพิ่ม";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(215, 65);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 17);
            this.lbl_status.TabIndex = 26;
            // 
            // CheckMenu
            // 
            this.CheckMenu.HeaderText = "";
            this.CheckMenu.Name = "CheckMenu";
            this.CheckMenu.Width = 50;
            // 
            // Menu1
            // 
            this.Menu1.HeaderText = "MenuId";
            this.Menu1.Name = "Menu1";
            this.Menu1.Visible = false;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "เมนู";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            this.Menu.Width = 150;
            // 
            // PriceMenu
            // 
            this.PriceMenu.HeaderText = "ราคา";
            this.PriceMenu.Name = "PriceMenu";
            this.PriceMenu.ReadOnly = true;
            this.PriceMenu.Width = 70;
            // 
            // CheckDetail
            // 
            this.CheckDetail.HeaderText = "";
            this.CheckDetail.Name = "CheckDetail";
            this.CheckDetail.Width = 50;
            // 
            // MenuId1
            // 
            this.MenuId1.HeaderText = "id";
            this.MenuId1.Name = "MenuId1";
            this.MenuId1.Visible = false;
            // 
            // MenuFood
            // 
            this.MenuFood.HeaderText = "รายการอาหาร";
            this.MenuFood.Name = "MenuFood";
            this.MenuFood.ReadOnly = true;
            this.MenuFood.Width = 150;
            // 
            // Price1
            // 
            this.Price1.HeaderText = "ราคา";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            this.Price1.Width = 50;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "จำนวน";
            this.Qty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Qty.MaxDropDownItems = 10;
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ร้านลาบ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tab1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detailfood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rd_Total;
        private System.Windows.Forms.RadioButton rd_Pay;
        private System.Windows.Forms.RadioButton rd_Notpay;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Tab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Date2;
        private System.Windows.Forms.DataGridView dgv_Menu;
        private System.Windows.Forms.DataGridView dgv_Detailfood;
        private System.Windows.Forms.TextBox txt_Order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Rigth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Change;
        private System.Windows.Forms.TextBox txt_Receive;
        private System.Windows.Forms.TextBox txt_SumPrice;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown numeric_Table;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceMenu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Qty;
    }
}

