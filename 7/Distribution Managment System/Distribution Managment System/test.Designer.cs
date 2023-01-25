namespace Distribution_Managment_System
{
    partial class test
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.name_Location = new System.Windows.Forms.TextBox();
            this.lon = new System.Windows.Forms.TextBox();
            this.lat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.map_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 116);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1421, 338);
            this.webBrowser1.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 50);
            this.button1.TabIndex = 77;
            this.button1.Text = "Show Map";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Map Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Name:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.checkBox1.Location = new System.Drawing.Point(128, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 25);
            this.checkBox1.TabIndex = 74;
            this.checkBox1.Text = "Use Coordinate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // name_Location
            // 
            this.name_Location.Location = new System.Drawing.Point(128, 26);
            this.name_Location.Name = "name_Location";
            this.name_Location.Size = new System.Drawing.Size(121, 20);
            this.name_Location.TabIndex = 73;
            // 
            // lon
            // 
            this.lon.Location = new System.Drawing.Point(365, 60);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(100, 20);
            this.lon.TabIndex = 72;
            // 
            // lat
            // 
            this.lat.Location = new System.Drawing.Point(365, 29);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(100, 20);
            this.lat.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label4.Location = new System.Drawing.Point(261, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Longitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label3.Location = new System.Drawing.Point(261, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Latitude:";
            // 
            // map_type
            // 
            this.map_type.FormattingEnabled = true;
            this.map_type.Items.AddRange(new object[] {
            "Map",
            "Satellite",
            "Hybrid",
            "Terrain",
            "GoogleEarth"});
            this.map_type.Location = new System.Drawing.Point(128, 58);
            this.map_type.Name = "map_type";
            this.map_type.Size = new System.Drawing.Size(121, 21);
            this.map_type.TabIndex = 68;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 630);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.name_Location);
            this.Controls.Add(this.lon);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.map_type);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox name_Location;
        private System.Windows.Forms.TextBox lon;
        private System.Windows.Forms.TextBox lat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox map_type;
    }
}