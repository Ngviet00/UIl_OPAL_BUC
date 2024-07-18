namespace UIL_OPAL
{
    partial class FormSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBarcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result Search";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.AllowUserToResizeColumns = false;
            this.dataGridViewSearch.AllowUserToResizeRows = false;
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 160);
            this.dataGridViewSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearch.RowHeadersVisible = false;
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1497, 610);
            this.dataGridViewSearch.TabIndex = 4;
            // 
            // index
            // 
            this.index.HeaderText = "ID";
            this.index.MaxInputLength = 1000000;
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.index.Width = 50;
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
            this.Result.Width = 50;
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
            this.FPCBbar_code.Width = 170;
            // 
            // box2_glueoverflow_vision
            // 
            this.box2_glueoverflow_vision.HeaderText = "Left Point(X,Y,Z)";
            this.box2_glueoverflow_vision.MinimumWidth = 6;
            this.box2_glueoverflow_vision.Name = "box2_glueoverflow_vision";
            this.box2_glueoverflow_vision.Width = 170;
            // 
            // box2_heated_air_curing
            // 
            this.box2_heated_air_curing.HeaderText = "Right Point(X,Y,Z)";
            this.box2_heated_air_curing.MinimumWidth = 6;
            this.box2_heated_air_curing.Name = "box2_heated_air_curing";
            this.box2_heated_air_curing.Width = 170;
            // 
            // box2_heigh
            // 
            this.box2_heigh.HeaderText = "Lower Point (X,Y)";
            this.box2_heigh.MinimumWidth = 6;
            this.box2_heigh.Name = "box2_heigh";
            this.box2_heigh.Width = 150;
            // 
            // box3_glue_amount
            // 
            this.box3_glue_amount.HeaderText = " Time";
            this.box3_glue_amount.MinimumWidth = 6;
            this.box3_glue_amount.Name = "box3_glue_amount";
            this.box3_glue_amount.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.dataGridViewSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearchBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 770);
            this.panel1.TabIndex = 9;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(841, 66);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(562, 50);
            this.txtBarcode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "QR_Code";
            // 
            // btnSearchBarcode
            // 
            this.btnSearchBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBarcode.Location = new System.Drawing.Point(1426, 64);
            this.btnSearchBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchBarcode.Name = "btnSearchBarcode";
            this.btnSearchBarcode.Size = new System.Drawing.Size(140, 53);
            this.btnSearchBarcode.TabIndex = 6;
            this.btnSearchBarcode.Text = "Search";
            this.btnSearchBarcode.UseVisualStyleBackColor = true;
            this.btnSearchBarcode.Click += new System.EventHandler(this.btnSearchBarcode_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 849);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
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
    }
}