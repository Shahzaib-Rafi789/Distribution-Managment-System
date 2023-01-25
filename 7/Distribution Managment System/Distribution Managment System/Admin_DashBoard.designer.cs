namespace Distribution_Managment_System
{
    partial class Admin_DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_DashBoard));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTtleBar = new System.Windows.Forms.Label();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnchagePassword = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDMS = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(188, 81);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(840, 0);
            this.MainPanel.TabIndex = 6;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.pnlTitleBar.Controls.Add(this.lblTtleBar);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(188, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(840, 81);
            this.pnlTitleBar.TabIndex = 5;
            // 
            // lblTtleBar
            // 
            this.lblTtleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTtleBar.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtleBar.ForeColor = System.Drawing.Color.White;
            this.lblTtleBar.Location = new System.Drawing.Point(0, 0);
            this.lblTtleBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTtleBar.Name = "lblTtleBar";
            this.lblTtleBar.Size = new System.Drawing.Size(840, 81);
            this.lblTtleBar.TabIndex = 0;
            this.lblTtleBar.Text = "USER DASHBOARD";
            this.lblTtleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkArea.Location = new System.Drawing.Point(188, 81);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(840, 528);
            this.pnlWorkArea.TabIndex = 7;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.BackgroundImage = global::Distribution_Managment_System.Properties.Resources.Dashboard_back;
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnchagePassword);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnManageUser);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(188, 609);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 293);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(188, 56);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // btnchagePassword
            // 
            this.btnchagePassword.AutoSize = true;
            this.btnchagePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnchagePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnchagePassword.FlatAppearance.BorderSize = 0;
            this.btnchagePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchagePassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchagePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnchagePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnchagePassword.Image")));
            this.btnchagePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchagePassword.Location = new System.Drawing.Point(0, 237);
            this.btnchagePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnchagePassword.Name = "btnchagePassword";
            this.btnchagePassword.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnchagePassword.Size = new System.Drawing.Size(188, 56);
            this.btnchagePassword.TabIndex = 14;
            this.btnchagePassword.Text = " CHAGE PASSWORD";
            this.btnchagePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchagePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchagePassword.UseVisualStyleBackColor = false;
            this.btnchagePassword.Click += new System.EventHandler(this.btnchagePassword_Click);
            this.btnchagePassword.MouseEnter += new System.EventHandler(this.btnchagePassword_MouseEnter);
            this.btnchagePassword.MouseLeave += new System.EventHandler(this.btnchagePassword_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = true;
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Image = global::Distribution_Managment_System.Properties.Resources.Report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 181);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(188, 56);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
            // 
            // btnManageUser
            // 
            this.btnManageUser.AutoSize = true;
            this.btnManageUser.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageUser.Image = global::Distribution_Managment_System.Properties.Resources.User1;
            this.btnManageUser.Location = new System.Drawing.Point(0, 125);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnManageUser.Size = new System.Drawing.Size(188, 56);
            this.btnManageUser.TabIndex = 4;
            this.btnManageUser.Text = "USER DASHBOARD";
            this.btnManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            this.btnManageUser.MouseEnter += new System.EventHandler(this.btnManageUser_MouseEnter);
            this.btnManageUser.MouseLeave += new System.EventHandler(this.btnManageUser_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogo.Controls.Add(this.lblDMS);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 125);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblDMS
            // 
            this.lblDMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDMS.AutoSize = true;
            this.lblDMS.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.lblDMS.ForeColor = System.Drawing.Color.White;
            this.lblDMS.Location = new System.Drawing.Point(2, 23);
            this.lblDMS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDMS.Name = "lblDMS";
            this.lblDMS.Size = new System.Drawing.Size(169, 77);
            this.lblDMS.TabIndex = 1;
            this.lblDMS.Text = "DMS";
            // 
            // Admin_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Admin_DashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnchagePassword;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDMS;
        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.Label lblTtleBar;
    }
}

