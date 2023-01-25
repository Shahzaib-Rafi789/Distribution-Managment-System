namespace Distribution_Managment_System
{
    partial class ViewBill
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLayControls = new System.Windows.Forms.TableLayoutPanel();
            this.region_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle_id_lbl = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmitt = new System.Windows.Forms.Button();
            this.datPStart = new System.Windows.Forms.DateTimePicker();
            this.datPEnd = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbLayControls.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gvProducts, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gvProducts
            // 
            this.gvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProducts.Location = new System.Drawing.Point(3, 413);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowHeadersWidth = 51;
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(1365, 334);
            this.gvProducts.TabIndex = 51;
            this.gvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLayControls, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1365, 334);
            this.tableLayoutPanel2.TabIndex = 52;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 41);
            this.panel1.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1359, 41);
            this.label6.TabIndex = 111;
            this.label6.Text = "PDF of Orders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLayControls
            // 
            this.tbLayControls.ColumnCount = 4;
            this.tbLayControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96076F));
            this.tbLayControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.40189F));
            this.tbLayControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.6766F));
            this.tbLayControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96076F));
            this.tbLayControls.Controls.Add(this.region_lbl, 1, 3);
            this.tbLayControls.Controls.Add(this.label1, 1, 2);
            this.tbLayControls.Controls.Add(this.vehicle_id_lbl, 1, 1);
            this.tbLayControls.Controls.Add(this.cmbShop, 2, 1);
            this.tbLayControls.Controls.Add(this.pnlButtons, 2, 4);
            this.tbLayControls.Controls.Add(this.datPStart, 2, 2);
            this.tbLayControls.Controls.Add(this.datPEnd, 2, 3);
            this.tbLayControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayControls.Location = new System.Drawing.Point(3, 50);
            this.tbLayControls.Name = "tbLayControls";
            this.tbLayControls.RowCount = 5;
            this.tbLayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbLayControls.Size = new System.Drawing.Size(1359, 281);
            this.tbLayControls.TabIndex = 0;
            // 
            // region_lbl
            // 
            this.region_lbl.AutoSize = true;
            this.region_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.region_lbl.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.region_lbl.Location = new System.Drawing.Point(180, 168);
            this.region_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.region_lbl.Name = "region_lbl";
            this.region_lbl.Size = new System.Drawing.Size(142, 56);
            this.region_lbl.TabIndex = 117;
            this.region_lbl.Text = "End Date";
            this.region_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label1.Location = new System.Drawing.Point(180, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 56);
            this.label1.TabIndex = 118;
            this.label1.Text = "Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vehicle_id_lbl
            // 
            this.vehicle_id_lbl.AutoSize = true;
            this.vehicle_id_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.vehicle_id_lbl.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.vehicle_id_lbl.Location = new System.Drawing.Point(180, 56);
            this.vehicle_id_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicle_id_lbl.Name = "vehicle_id_lbl";
            this.vehicle_id_lbl.Size = new System.Drawing.Size(175, 56);
            this.vehicle_id_lbl.TabIndex = 116;
            this.vehicle_id_lbl.Text = "Shop Name";
            this.vehicle_id_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbShop
            // 
            this.cmbShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbShop.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(619, 59);
            this.cmbShop.MaximumSize = new System.Drawing.Size(570, 0);
            this.cmbShop.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(560, 35);
            this.cmbShop.TabIndex = 120;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnSubmitt);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(619, 227);
            this.pnlButtons.MaximumSize = new System.Drawing.Size(570, 45);
            this.pnlButtons.MinimumSize = new System.Drawing.Size(250, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(560, 45);
            this.pnlButtons.TabIndex = 121;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(81)))));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmitt
            // 
            this.btnSubmitt.AutoSize = true;
            this.btnSubmitt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnSubmitt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitt.ForeColor = System.Drawing.Color.White;
            this.btnSubmitt.Location = new System.Drawing.Point(424, 0);
            this.btnSubmitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitt.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnSubmitt.Name = "btnSubmitt";
            this.btnSubmitt.Size = new System.Drawing.Size(136, 40);
            this.btnSubmitt.TabIndex = 1;
            this.btnSubmitt.Text = "GENERATE";
            this.btnSubmitt.UseVisualStyleBackColor = false;
            this.btnSubmitt.Click += new System.EventHandler(this.btnSubmitt_Click);
            // 
            // datPStart
            // 
            this.datPStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datPStart.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.datPStart.Location = new System.Drawing.Point(619, 115);
            this.datPStart.MaximumSize = new System.Drawing.Size(570, 36);
            this.datPStart.MinimumSize = new System.Drawing.Size(250, 4);
            this.datPStart.Name = "datPStart";
            this.datPStart.Size = new System.Drawing.Size(560, 36);
            this.datPStart.TabIndex = 122;
            // 
            // datPEnd
            // 
            this.datPEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datPEnd.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.datPEnd.Location = new System.Drawing.Point(619, 171);
            this.datPEnd.MaximumSize = new System.Drawing.Size(570, 36);
            this.datPEnd.MinimumSize = new System.Drawing.Size(250, 4);
            this.datPEnd.Name = "datPEnd";
            this.datPEnd.Size = new System.Drawing.Size(560, 36);
            this.datPEnd.TabIndex = 123;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 342);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 53);
            this.flowLayoutPanel1.TabIndex = 121;
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 630);
            this.Name = "ViewBill";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbLayControls.ResumeLayout(false);
            this.tbLayControls.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tbLayControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label region_lbl;
        private System.Windows.Forms.Label vehicle_id_lbl;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSubmitt;
        private System.Windows.Forms.DateTimePicker datPStart;
        private System.Windows.Forms.DateTimePicker datPEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}