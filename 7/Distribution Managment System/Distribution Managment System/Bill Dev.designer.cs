namespace Distribution_Managment_System
{
    partial class Form2
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
        ///
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblDMS = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblOrderNo = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblDate = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblShop = new DevExpress.XtraLayout.SimpleLabelItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblShop)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.lblDMS);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(527, 94, 812, 500);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(915, 616);
            this.layoutControl.TabIndex = 1;
            // 
            // lblDMS
            // 
            this.lblDMS.AllowHtmlString = true;
            this.lblDMS.Appearance.Font = new System.Drawing.Font("TeXGyreAdventor", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDMS.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblDMS.Appearance.Options.UseFont = true;
            this.lblDMS.Appearance.Options.UseForeColor = true;
            this.lblDMS.Appearance.Options.UseTextOptions = true;
            this.lblDMS.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblDMS.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblDMS.Location = new System.Drawing.Point(47, 0);
            this.lblDMS.Margin = new System.Windows.Forms.Padding(4);
            this.lblDMS.Name = "lblDMS";
            this.lblDMS.Padding = new System.Windows.Forms.Padding(0, 4, 15, 7);
            this.lblDMS.Size = new System.Drawing.Size(821, 46);
            this.lblDMS.StyleController = this.layoutControl;
            this.lblDMS.TabIndex = 4;
            this.lblDMS.Text = "DISTRIBUTION MANAGMENT SYSTEM";
            this.lblDMS.Click += new System.EventHandler(this.labelControl_Click);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl.Font = new System.Drawing.Font("TeXGyreAdventor", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl.Location = new System.Drawing.Point(47, 106);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(821, 510);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("TeXGyreAdventor", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.itemGrid,
            this.lblOrderNo,
            this.lblDate,
            this.lblShop});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(47, 47, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(915, 616);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.lblDMS;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(821, 46);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.Location = new System.Drawing.Point(0, 106);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(821, 510);
            this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.itemGrid.TextVisible = false;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AllowHotTrack = false;
            this.lblOrderNo.Location = new System.Drawing.Point(0, 86);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(821, 20);
            this.lblOrderNo.TextSize = new System.Drawing.Size(91, 16);
            // 
            // lblDate
            // 
            this.lblDate.AllowHotTrack = false;
            this.lblDate.Location = new System.Drawing.Point(0, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(821, 20);
            this.lblDate.TextSize = new System.Drawing.Size(91, 16);
            // 
            // lblShop
            // 
            this.lblShop.AllowHotTrack = false;
            this.lblShop.Location = new System.Drawing.Point(0, 46);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(821, 20);
            this.lblShop.TextSize = new System.Drawing.Size(91, 16);
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "Preview;Size32x32;GrayScaled";
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.Font = new System.Drawing.Font("TeXGyreAdventor", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 616);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 74);
            this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 74);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(915, 74);
            this.windowsUIButtonPanel.TabIndex = 5;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // Form2
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 690);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOrderNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblDMS;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private DevExpress.XtraLayout.SimpleLabelItem lblOrderNo;
        private DevExpress.XtraLayout.SimpleLabelItem lblDate;
        private DevExpress.XtraLayout.SimpleLabelItem lblShop;
    }
}