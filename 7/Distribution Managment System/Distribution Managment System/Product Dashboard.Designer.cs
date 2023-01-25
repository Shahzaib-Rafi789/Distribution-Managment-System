namespace Distribution_Managment_System
{
    partial class Product_Dashboard
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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTtleBar = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numUDThreshold = new System.Windows.Forms.NumericUpDown();
            this.numUDCost = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmitt = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numUDSale = new System.Windows.Forms.NumericUpDown();
            this.cmbSupplier = new PresentationControls.CheckBoxComboBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCost)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSale)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gvProducts, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTtleBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.27451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.11765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 609);
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
            this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT,
            this.DELETE});
            this.gvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProducts.Location = new System.Drawing.Point(2, 340);
            this.gvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowHeadersWidth = 51;
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(1024, 267);
            this.gvProducts.TabIndex = 50;
            this.gvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick_1);
            // 
            // EDIT
            // 
            this.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "EDIT";
            this.EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            this.EDIT.FillWeight = 14.68429F;
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Width = 43;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "DELETE";
            this.DELETE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DELETE.FillWeight = 185.3158F;
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 60;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtSearch);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 281);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1024, 55);
            this.flowLayoutPanel2.TabIndex = 49;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(2, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MinimumSize = new System.Drawing.Size(2, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnSearch.Location = new System.Drawing.Point(382, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTtleBar
            // 
            this.lblTtleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTtleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTtleBar.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtleBar.ForeColor = System.Drawing.Color.Black;
            this.lblTtleBar.Location = new System.Drawing.Point(2, 0);
            this.lblTtleBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTtleBar.Name = "lblTtleBar";
            this.lblTtleBar.Size = new System.Drawing.Size(1024, 59);
            this.lblTtleBar.TabIndex = 48;
            this.lblTtleBar.Text = "Add a Product";
            this.lblTtleBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTtleBar.Click += new System.EventHandler(this.lblTtleBar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.numUDThreshold, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numUDCost, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblProductID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProduct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBrand, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSupplier, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblThreshold, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblSalePrice, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCostPrice, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numUDSale, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbSupplier, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBrand, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 61);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1024, 216);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // numUDThreshold
            // 
            this.numUDThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDThreshold.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.numUDThreshold.Location = new System.Drawing.Point(155, 164);
            this.numUDThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.numUDThreshold.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUDThreshold.Name = "numUDThreshold";
            this.numUDThreshold.Size = new System.Drawing.Size(354, 30);
            this.numUDThreshold.TabIndex = 3;
            // 
            // numUDCost
            // 
            this.numUDCost.DecimalPlaces = 2;
            this.numUDCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDCost.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.numUDCost.Location = new System.Drawing.Point(666, 2);
            this.numUDCost.Margin = new System.Windows.Forms.Padding(2);
            this.numUDCost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUDCost.Name = "numUDCost";
            this.numUDCost.Size = new System.Drawing.Size(356, 30);
            this.numUDCost.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmitt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(666, 164);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 48);
            this.flowLayoutPanel1.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnClear.Location = new System.Drawing.Point(2, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmitt
            // 
            this.btnSubmitt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnSubmitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitt.ForeColor = System.Drawing.Color.White;
            this.btnSubmitt.Location = new System.Drawing.Point(108, 2);
            this.btnSubmitt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitt.Name = "btnSubmitt";
            this.btnSubmitt.Size = new System.Drawing.Size(102, 37);
            this.btnSubmitt.TabIndex = 0;
            this.btnSubmitt.Text = "SAVE";
            this.btnSubmitt.UseVisualStyleBackColor = false;
            this.btnSubmitt.Click += new System.EventHandler(this.btnSubmitt_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BackColor = System.Drawing.Color.Transparent;
            this.lblProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.Black;
            this.lblProductID.Location = new System.Drawing.Point(2, 0);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(149, 54);
            this.lblProductID.TabIndex = 29;
            this.lblProductID.Text = "Product ID";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(2, 54);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(149, 54);
            this.lblProduct.TabIndex = 31;
            this.lblProduct.Text = "Product Name";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(2, 108);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(149, 54);
            this.lblBrand.TabIndex = 33;
            this.lblBrand.Text = "Brand";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSupplier.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblSupplier.Location = new System.Drawing.Point(513, 108);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(149, 54);
            this.lblSupplier.TabIndex = 41;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.BackColor = System.Drawing.Color.Transparent;
            this.lblThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreshold.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.ForeColor = System.Drawing.Color.Black;
            this.lblThreshold.Location = new System.Drawing.Point(2, 162);
            this.lblThreshold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(149, 54);
            this.lblThreshold.TabIndex = 35;
            this.lblThreshold.Text = "Threshold";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalePrice.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.Black;
            this.lblSalePrice.Location = new System.Drawing.Point(513, 54);
            this.lblSalePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(149, 54);
            this.lblSalePrice.TabIndex = 39;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(155, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 30);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblCostPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCostPrice.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.ForeColor = System.Drawing.Color.Black;
            this.lblCostPrice.Location = new System.Drawing.Point(513, 0);
            this.lblCostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(149, 54);
            this.lblCostPrice.TabIndex = 37;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(155, 2);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(354, 30);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // numUDSale
            // 
            this.numUDSale.DecimalPlaces = 2;
            this.numUDSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDSale.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.numUDSale.Location = new System.Drawing.Point(666, 56);
            this.numUDSale.Margin = new System.Windows.Forms.Padding(2);
            this.numUDSale.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUDSale.Name = "numUDSale";
            this.numUDSale.Size = new System.Drawing.Size(356, 30);
            this.numUDSale.TabIndex = 5;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbSupplier.CheckBoxProperties = checkBoxProperties1;
            this.cmbSupplier.DisplayMemberSingleItem = "";
            this.cmbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(666, 110);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(356, 29);
            this.cmbSupplier.TabIndex = 6;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.Black;
            this.txtBrand.Location = new System.Drawing.Point(155, 110);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(354, 30);
            this.txtBrand.TabIndex = 2;
            this.txtBrand.TabStop = false;
            // 
            // Product_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product_Dashboard";
            this.Text = "Product_Dashboard";
            this.Load += new System.EventHandler(this.Product_Dashboard_Load);
            this.Resize += new System.EventHandler(this.Product_Dashboard_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCost)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numUDThreshold;
        private System.Windows.Forms.NumericUpDown numUDCost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmitt;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown numUDSale;
        private PresentationControls.CheckBoxComboBox cmbSupplier;
        private System.Windows.Forms.Label lblTtleBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        private System.Windows.Forms.TextBox txtBrand;
    }
}