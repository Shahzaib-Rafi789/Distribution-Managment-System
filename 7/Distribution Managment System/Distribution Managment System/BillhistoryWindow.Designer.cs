namespace Distribution_Managment_System
{
    partial class BillhistoryWindow
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vehicle_id_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.region_lbl = new System.Windows.Forms.Label();
            this.vehicle_id_combox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(90, 515);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MinimumSize = new System.Drawing.Size(2, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 30);
            this.txtSearch.TabIndex = 115;
            this.txtSearch.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(571, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 109;
            this.label6.Text = "Order PDF";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.vehicle_id_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.region_lbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.vehicle_id_combox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(482, 301);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(478, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 165);
            this.tableLayoutPanel1.TabIndex = 117;
            // 
            // vehicle_id_lbl
            // 
            this.vehicle_id_lbl.AutoSize = true;
            this.vehicle_id_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle_id_lbl.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.vehicle_id_lbl.Location = new System.Drawing.Point(3, 0);
            this.vehicle_id_lbl.Name = "vehicle_id_lbl";
            this.vehicle_id_lbl.Size = new System.Drawing.Size(233, 41);
            this.vehicle_id_lbl.TabIndex = 106;
            this.vehicle_id_lbl.Text = "Shop Name";
            this.vehicle_id_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 41);
            this.label1.TabIndex = 111;
            this.label1.Text = "Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // region_lbl
            // 
            this.region_lbl.AutoSize = true;
            this.region_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.region_lbl.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.region_lbl.Location = new System.Drawing.Point(3, 82);
            this.region_lbl.Name = "region_lbl";
            this.region_lbl.Size = new System.Drawing.Size(233, 41);
            this.region_lbl.TabIndex = 107;
            this.region_lbl.Text = "End Date";
            this.region_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vehicle_id_combox
            // 
            this.vehicle_id_combox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle_id_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicle_id_combox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicle_id_combox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.vehicle_id_combox.ForeColor = System.Drawing.Color.Gray;
            this.vehicle_id_combox.FormattingEnabled = true;
            this.vehicle_id_combox.Items.AddRange(new object[] {
            "Type 1",
            "Type 2",
            "Type 3"});
            this.vehicle_id_combox.Location = new System.Drawing.Point(242, 3);
            this.vehicle_id_combox.Name = "vehicle_id_combox";
            this.vehicle_id_combox.Size = new System.Drawing.Size(233, 29);
            this.vehicle_id_combox.TabIndex = 108;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.dateTimePicker2.Location = new System.Drawing.Point(241, 84);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker2.TabIndex = 114;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker1.TabIndex = 113;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(241, 125);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(235, 38);
            this.panelControl1.TabIndex = 115;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-23, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MaximumSize = new System.Drawing.Size(128, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 110;
            this.button1.Text = "FILTER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.MaximumSize = new System.Drawing.Size(128, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 112;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BillhistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Name = "BillhistoryWindow";
            this.Text = "BillhistoryWindow";
            this.Load += new System.EventHandler(this.BillhistoryWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label vehicle_id_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label region_lbl;
        private System.Windows.Forms.ComboBox vehicle_id_combox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}