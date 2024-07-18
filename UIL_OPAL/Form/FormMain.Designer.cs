using Sunny.UI;
using UnilityCommand.FormatCellDataGridViewControl;
using UnilityCommand.SubControl;

namespace UIL_OPAL
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDuplicate2 = new System.Windows.Forms.Label();
            this.lbDuplicate1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.userCtrlInfoPC2 = new UnilityCommand.SubControl.UserCtrlInfoPC2();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPCAlive = new UnilityCommand.SubControl.CustomLabel2();
            this.lbTotalTray = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box1_glue_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box1_glue_dischargevolume_vision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insulator_bar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box1_glueoverflow_vison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box1_heated_air_curing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2_glue_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2_glue_dischargevolume_vision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPCBbar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2_glueoverflow_vision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2_heated_air_curing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2_heigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box3_glue_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lineChart = new CIM.LineChart();
            this.pieChart = new CIM.PieChart();
            this.lbPercentOK = new System.Windows.Forms.Label();
            this.lbPercentNG = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(149, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "OPAL BUC COVER HEAT WELDING SEMI-AUTO MC";
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(1772, 18);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(131, 53);
            this.btnClearData.TabIndex = 16;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.Gray;
            this.labelDateTime.Location = new System.Drawing.Point(13, 74);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(99, 24);
            this.labelDateTime.TabIndex = 17;
            this.labelDateTime.Text = "DateTime";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbDuplicate2);
            this.panel2.Controls.Add(this.lbDuplicate1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.btnClearData);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 513);
            this.panel2.TabIndex = 10;
            // 
            // lbDuplicate2
            // 
            this.lbDuplicate2.AutoSize = true;
            this.lbDuplicate2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbDuplicate2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuplicate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDuplicate2.Location = new System.Drawing.Point(847, 95);
            this.lbDuplicate2.Name = "lbDuplicate2";
            this.lbDuplicate2.Size = new System.Drawing.Size(0, 21);
            this.lbDuplicate2.TabIndex = 29;
            this.lbDuplicate2.Visible = false;
            // 
            // lbDuplicate1
            // 
            this.lbDuplicate1.AutoSize = true;
            this.lbDuplicate1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbDuplicate1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuplicate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDuplicate1.Location = new System.Drawing.Point(846, 65);
            this.lbDuplicate1.Name = "lbDuplicate1";
            this.lbDuplicate1.Size = new System.Drawing.Size(0, 21);
            this.lbDuplicate1.TabIndex = 28;
            this.lbDuplicate1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1479, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 53);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(1624, 18);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(131, 53);
            this.btnSetting.TabIndex = 26;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(3, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(18, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1885, 336);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lineChart);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(558, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1310, 310);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(11, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "In the last 7 days";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(5, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Defect Rate";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.userCtrlInfoPC2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(1568, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 310);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PC Info";
            this.groupBox5.Visible = false;
            // 
            // userCtrlInfoPC2
            // 
            this.userCtrlInfoPC2.BackColor = System.Drawing.Color.White;
            this.userCtrlInfoPC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCtrlInfoPC2.ListDrive = null;
            this.userCtrlInfoPC2.Location = new System.Drawing.Point(7, 42);
            this.userCtrlInfoPC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userCtrlInfoPC2.Name = "userCtrlInfoPC2";
            this.userCtrlInfoPC2.Size = new System.Drawing.Size(286, 261);
            this.userCtrlInfoPC2.TabIndex = 30;
            this.userCtrlInfoPC2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(-3, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Statistics";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lbPercentNG);
            this.groupBox3.Controls.Add(this.lbPercentOK);
            this.groupBox3.Controls.Add(this.pieChart);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbPCAlive);
            this.groupBox3.Controls.Add(this.lbTotalTray);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbltotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(536, 310);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(9, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "PC";
            // 
            // lbPCAlive
            // 
            this.lbPCAlive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPCAlive.CheckBoxColor = System.Drawing.Color.OrangeRed;
            this.lbPCAlive.CheckBoxSize = 25;
            this.lbPCAlive.Checked = true;
            this.lbPCAlive.Color = System.Drawing.Color.White;
            this.lbPCAlive.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPCAlive.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCAlive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(84)))));
            this.lbPCAlive.IsCircle = true;
            this.lbPCAlive.IsConnect = false;
            this.lbPCAlive.Location = new System.Drawing.Point(49, 247);
            this.lbPCAlive.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbPCAlive.Name = "lbPCAlive";
            this.lbPCAlive.Radius = 50;
            this.lbPCAlive.ReadOnly = true;
            this.lbPCAlive.Size = new System.Drawing.Size(90, 27);
            this.lbPCAlive.TabIndex = 29;
            this.lbPCAlive.Text = " Alive";
            // 
            // lbTotalTray
            // 
            this.lbTotalTray.AutoSize = true;
            this.lbTotalTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lbTotalTray.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTotalTray.Location = new System.Drawing.Point(85, 172);
            this.lbTotalTray.Name = "lbTotalTray";
            this.lbTotalTray.Size = new System.Drawing.Size(39, 29);
            this.lbTotalTray.TabIndex = 28;
            this.lbTotalTray.Text = "67";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(11, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total tray:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(237)))));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(9, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(84)))));
            this.lbltotal.Location = new System.Drawing.Point(7, 90);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(158, 37);
            this.lbltotal.TabIndex = 25;
            this.lbltotal.Text = "2,420 EA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(13, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "In the last 7 days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Defect Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(19, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "PC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(20, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total tray:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(237)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(18, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.11459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.88542F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 548);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 492);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.QR,
            this.box1_glue_amount,
            this.box1_glue_dischargevolume_vision,
            this.insulator_bar_code,
            this.Result,
            this.box1_glueoverflow_vison,
            this.box1_heated_air_curing,
            this.box2_glue_amount,
            this.box2_glue_dischargevolume_vision,
            this.FPCBbar_code,
            this.box2_glueoverflow_vision,
            this.box2_heated_air_curing,
            this.box2_heigh,
            this.box3_glue_amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1608, 488);
            this.dataGridView1.TabIndex = 4;
            // 
            // index
            // 
            this.index.HeaderText = "ID";
            this.index.MaxInputLength = 1000000;
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.index.Width = 90;
            // 
            // QR
            // 
            this.QR.HeaderText = "BUC Cover QR Code";
            this.QR.MinimumWidth = 6;
            this.QR.Name = "QR";
            this.QR.Width = 250;
            // 
            // box1_glue_amount
            // 
            this.box1_glue_amount.HeaderText = "Backet Barcode";
            this.box1_glue_amount.MinimumWidth = 6;
            this.box1_glue_amount.Name = "box1_glue_amount";
            this.box1_glue_amount.Width = 125;
            // 
            // box1_glue_dischargevolume_vision
            // 
            this.box1_glue_dischargevolume_vision.HeaderText = "Crimp Distance";
            this.box1_glue_dischargevolume_vision.MinimumWidth = 6;
            this.box1_glue_dischargevolume_vision.Name = "box1_glue_dischargevolume_vision";
            // 
            // insulator_bar_code
            // 
            this.insulator_bar_code.HeaderText = "Pressure Time";
            this.insulator_bar_code.MinimumWidth = 6;
            this.insulator_bar_code.Name = "insulator_bar_code";
            this.insulator_bar_code.Width = 90;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // box1_glueoverflow_vison
            // 
            this.box1_glueoverflow_vison.HeaderText = "Tool Temperature 1";
            this.box1_glueoverflow_vison.MinimumWidth = 6;
            this.box1_glueoverflow_vison.Name = "box1_glueoverflow_vison";
            this.box1_glueoverflow_vison.Width = 125;
            // 
            // box1_heated_air_curing
            // 
            this.box1_heated_air_curing.HeaderText = "Tool Temperature 2";
            this.box1_heated_air_curing.MinimumWidth = 6;
            this.box1_heated_air_curing.Name = "box1_heated_air_curing";
            this.box1_heated_air_curing.Width = 125;
            // 
            // box2_glue_amount
            // 
            this.box2_glue_amount.HeaderText = "Tool Temperature 3";
            this.box2_glue_amount.MinimumWidth = 6;
            this.box2_glue_amount.Name = "box2_glue_amount";
            this.box2_glue_amount.Width = 125;
            // 
            // box2_glue_dischargevolume_vision
            // 
            this.box2_glue_dischargevolume_vision.HeaderText = " Tool Temperature 4";
            this.box2_glue_dischargevolume_vision.MinimumWidth = 6;
            this.box2_glue_dischargevolume_vision.Name = "box2_glue_dischargevolume_vision";
            this.box2_glue_dischargevolume_vision.Width = 125;
            // 
            // FPCBbar_code
            // 
            this.FPCBbar_code.HeaderText = "Upper Point(X,Y,Z)";
            this.FPCBbar_code.MinimumWidth = 6;
            this.FPCBbar_code.Name = "FPCBbar_code";
            this.FPCBbar_code.Width = 150;
            // 
            // box2_glueoverflow_vision
            // 
            this.box2_glueoverflow_vision.HeaderText = "Left Point(X,Y,Z)";
            this.box2_glueoverflow_vision.MinimumWidth = 6;
            this.box2_glueoverflow_vision.Name = "box2_glueoverflow_vision";
            this.box2_glueoverflow_vision.Width = 150;
            // 
            // box2_heated_air_curing
            // 
            this.box2_heated_air_curing.HeaderText = "Right Point(X,Y,Z)";
            this.box2_heated_air_curing.MinimumWidth = 6;
            this.box2_heated_air_curing.Name = "box2_heated_air_curing";
            this.box2_heated_air_curing.Width = 150;
            // 
            // box2_heigh
            // 
            this.box2_heigh.HeaderText = "Lower Point (X,Y)";
            this.box2_heigh.MinimumWidth = 6;
            this.box2_heigh.Name = "box2_heigh";
            this.box2_heigh.Width = 125;
            // 
            // box3_glue_amount
            // 
            this.box3_glue_amount.HeaderText = " Time";
            this.box3_glue_amount.MinimumWidth = 6;
            this.box3_glue_amount.Name = "box3_glue_amount";
            this.box3_glue_amount.Width = 170;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1617, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 486);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::UIL_OPAL.Properties.Resources.MSlogo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 407);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(4, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(285, 417);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lineChart
            // 
            this.lineChart.Days = null;
            this.lineChart.Location = new System.Drawing.Point(28, 66);
            this.lineChart.Mc1data = null;
            this.lineChart.Mc2data = null;
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(945, 226);
            this.lineChart.TabIndex = 26;
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(181, 66);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(349, 180);
            this.pieChart.TabIndex = 31;
            // 
            // lbPercentOK
            // 
            this.lbPercentOK.AutoSize = true;
            this.lbPercentOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPercentOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPercentOK.Location = new System.Drawing.Point(276, 282);
            this.lbPercentOK.Name = "lbPercentOK";
            this.lbPercentOK.Size = new System.Drawing.Size(68, 20);
            this.lbPercentOK.TabIndex = 33;
            this.lbPercentOK.Text = "OK: 0%";
            // 
            // lbPercentNG
            // 
            this.lbPercentNG.AutoSize = true;
            this.lbPercentNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPercentNG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPercentNG.Location = new System.Drawing.Point(426, 282);
            this.lbPercentNG.Name = "lbPercentNG";
            this.lbPercentNG.Size = new System.Drawing.Size(70, 20);
            this.lbPercentNG.TabIndex = 34;
            this.lbPercentNG.Text = "NG: 0%";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormMain";
            this.ShowFullScreen = true;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleDisabled = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1405, 596);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn QR;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1_glue_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1_glue_dischargevolume_vision;
        private System.Windows.Forms.DataGridViewTextBoxColumn insulator_bar_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1_glueoverflow_vison;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1_heated_air_curing;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2_glue_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2_glue_dischargevolume_vision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPCBbar_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2_glueoverflow_vision;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2_heated_air_curing;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2_heigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn box3_glue_amount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbDuplicate2;
        private System.Windows.Forms.Label lbDuplicate1;
        private UserCtrlInfoPC2 userCtrlInfoPC2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private CustomLabel2 lbPCAlive;
        private System.Windows.Forms.Label lbTotalTray;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotal;
        private CIM.LineChart lineChart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CIM.PieChart pieChart;
        private System.Windows.Forms.Label lbPercentNG;
        private System.Windows.Forms.Label lbPercentOK;
    }
}

