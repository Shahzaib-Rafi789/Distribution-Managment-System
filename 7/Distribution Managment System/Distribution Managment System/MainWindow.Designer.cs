namespace Distribution_Managment_System
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProductDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTtleBar = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnSupplier);
            this.pnlMenu.Controls.Add(this.btnOrder);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnProductDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(188, 609);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 335);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(188, 56);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "  EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.AutoSize = true;
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 286);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(188, 49);
            this.btnSupplier.TabIndex = 9;
            this.btnSupplier.Text = "SUPPLIER DAHBOARD";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSize = true;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 230);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(188, 56);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "ORDER ITEM";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.AutoSize = true;
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 181);
            this.btnStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(188, 49);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "ADD STOCK";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnProductDashboard
            // 
            this.btnProductDashboard.AutoSize = true;
            this.btnProductDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.btnProductDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductDashboard.FlatAppearance.BorderSize = 0;
            this.btnProductDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductDashboard.Image = global::Distribution_Managment_System.Properties.Resources.products__2_;
            this.btnProductDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductDashboard.Location = new System.Drawing.Point(0, 125);
            this.btnProductDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDashboard.Name = "btnProductDashboard";
            this.btnProductDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnProductDashboard.Size = new System.Drawing.Size(188, 56);
            this.btnProductDashboard.TabIndex = 0;
            this.btnProductDashboard.Text = "PRODUCT DASHBOARD";
            this.btnProductDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductDashboard.UseVisualStyleBackColor = false;
            this.btnProductDashboard.Click += new System.EventHandler(this.btnUserDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lblName);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 125);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 107);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "NAME";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Distribution_Managment_System.Properties.Resources.DMS_Logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 125);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTtleBar
            // 
            this.lblTtleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTtleBar.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.lblTtleBar.ForeColor = System.Drawing.Color.White;
            this.lblTtleBar.Location = new System.Drawing.Point(0, 0);
            this.lblTtleBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTtleBar.Name = "lblTtleBar";
            this.lblTtleBar.Size = new System.Drawing.Size(840, 81);
            this.lblTtleBar.TabIndex = 0;
            this.lblTtleBar.Text = "Title";
            this.lblTtleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.pnlTitleBar.Controls.Add(this.lblTtleBar);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(188, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(840, 81);
            this.pnlTitleBar.TabIndex = 5;
            // 
            // pnlWindow
            // 
            this.pnlWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWindow.Location = new System.Drawing.Point(188, 81);
            this.pnlWindow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(840, 528);
            this.pnlWindow.TabIndex = 6;
            this.pnlWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWindow_Paint_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnlWindow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWinow";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainWinow_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProductDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTtleBar;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlWindow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}