namespace Distribution_Managment_System
{
    partial class Map
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
            this.G = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.Polygon = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.bb = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Button();
            this.btnGeoCode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.G, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // G
            // 
            this.G.Bearing = 0F;
            this.G.CanDragMap = true;
            this.G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G.EmptyTileColor = System.Drawing.Color.Navy;
            this.G.GrayScaleMode = false;
            this.G.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.G.LevelsKeepInMemory = 5;
            this.G.Location = new System.Drawing.Point(0, 0);
            this.G.Margin = new System.Windows.Forms.Padding(0);
            this.G.MarkersEnabled = true;
            this.G.MaxZoom = 2;
            this.G.MinZoom = 2;
            this.G.MouseWheelZoomEnabled = true;
            this.G.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.G.Name = "G";
            this.G.NegativeMode = false;
            this.G.PolygonsEnabled = true;
            this.G.RetryLoadTile = 0;
            this.G.RoutesEnabled = true;
            this.G.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.G.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.G.ShowTileGridLines = false;
            this.G.Size = new System.Drawing.Size(926, 411);
            this.G.TabIndex = 0;
            this.G.Zoom = 0D;
            this.G.Load += new System.EventHandler(this.gMapControl1_Load);
            this.G.MouseClick += new System.Windows.Forms.MouseEventHandler(this.G_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeoCode);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.t4);
            this.panel1.Controls.Add(this.t3);
            this.panel1.Controls.Add(this.Polygon);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.bb);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.t2);
            this.panel1.Controls.Add(this.t1);
            this.panel1.Controls.Add(this.b);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 67);
            this.panel1.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(-3, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(428, 67);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.Text = "";
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(449, 44);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 20);
            this.t4.TabIndex = 9;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(449, 6);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 20);
            this.t3.TabIndex = 8;
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(636, 26);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(75, 23);
            this.Polygon.TabIndex = 7;
            this.Polygon.Text = "Polygon";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(636, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(876, 31);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "label1";
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(555, 47);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(75, 23);
            this.bb.TabIndex = 4;
            this.bb.Text = "route";
            this.bb.UseVisualStyleBackColor = true;
            this.bb.Click += new System.EventHandler(this.bb_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(555, 26);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 3;
            this.b2.Text = "clr";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(749, 38);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 2;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(749, 6);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 1;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(555, 3);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 0;
            this.b.Text = "Load";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // btnGeoCode
            // 
            this.btnGeoCode.Location = new System.Drawing.Point(636, 47);
            this.btnGeoCode.Name = "btnGeoCode";
            this.btnGeoCode.Size = new System.Drawing.Size(75, 23);
            this.btnGeoCode.TabIndex = 11;
            this.btnGeoCode.Text = "GeoCode";
            this.btnGeoCode.UseVisualStyleBackColor = true;
            this.btnGeoCode.Click += new System.EventHandler(this.btnGeoCode_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GMap.NET.WindowsForms.GMapControl G;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bb;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Button btnGeoCode;
    }
}