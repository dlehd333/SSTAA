
namespace SSTAA.WinForm
{
    partial class SelectTownForm
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
            DevExpress.XtraMap.GeoMapCoordinateSystem geoMapCoordinateSystem1 = new DevExpress.XtraMap.GeoMapCoordinateSystem();
            this.lblDisplayStation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnResult = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.TempMapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayStation
            // 
            this.lblDisplayStation.Appearance.BackColor = System.Drawing.Color.White;
            this.lblDisplayStation.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStation.Appearance.Options.UseBackColor = true;
            this.lblDisplayStation.Appearance.Options.UseFont = true;
            this.lblDisplayStation.Appearance.Options.UseTextOptions = true;
            this.lblDisplayStation.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tablePanel1.SetColumn(this.lblDisplayStation, 9);
            this.tablePanel1.SetColumnSpan(this.lblDisplayStation, 3);
            this.lblDisplayStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayStation.Location = new System.Drawing.Point(760, 86);
            this.lblDisplayStation.Name = "lblDisplayStation";
            this.tablePanel1.SetRow(this.lblDisplayStation, 2);
            this.tablePanel1.SetRowSpan(this.lblDisplayStation, 7);
            this.lblDisplayStation.Size = new System.Drawing.Size(239, 477);
            this.lblDisplayStation.TabIndex = 1;
            this.lblDisplayStation.Text = "해당구 역 현황";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.labelControl2, 3);
            this.tablePanel1.SetColumnSpan(this.labelControl2, 4);
            this.labelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.labelControl2.Location = new System.Drawing.Point(219, 21);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(300, 40);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "원하는 구를 선택하세요";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.labelControl3, 9);
            this.labelControl3.Location = new System.Drawing.Point(760, 591);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 9);
            this.labelControl3.Size = new System.Drawing.Size(41, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "업종 : ";
            // 
            // cbxGu
            // 
            this.tablePanel1.SetColumn(this.cbxGu, 7);
            this.cbxGu.Location = new System.Drawing.Point(612, 36);
            this.cbxGu.Name = "cbxGu";
            this.cbxGu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.cbxGu, 1);
            this.cbxGu.Size = new System.Drawing.Size(92, 24);
            this.cbxGu.TabIndex = 5;
            // 
            // cbxField
            // 
            this.tablePanel1.SetColumn(this.cbxField, 10);
            this.cbxField.Location = new System.Drawing.Point(809, 588);
            this.cbxField.Name = "cbxField";
            this.cbxField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.cbxField, 9);
            this.cbxField.Size = new System.Drawing.Size(92, 24);
            this.cbxField.TabIndex = 6;
            this.cbxField.SelectedIndexChanged += new System.EventHandler(this.cbxField_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.tablePanel1.SetColumn(this.btnResult, 11);
            this.btnResult.Location = new System.Drawing.Point(907, 585);
            this.btnResult.Name = "btnResult";
            this.tablePanel1.SetRow(this.btnResult, 9);
            this.btnResult.Size = new System.Drawing.Size(92, 30);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "결과보기";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(this.TempMapControl);
            this.tablePanel1.Controls.Add(this.btnResult);
            this.tablePanel1.Controls.Add(this.cbxField);
            this.tablePanel1.Controls.Add(this.cbxGu);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.lblDisplayStation);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Size = new System.Drawing.Size(1022, 720);
            this.tablePanel1.TabIndex = 0;
            // 
            // TempMapControl
            // 
            this.TempMapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(37.5D, 127D);
            this.tablePanel1.SetColumn(this.TempMapControl, 1);
            this.tablePanel1.SetColumnSpan(this.TempMapControl, 7);
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems;
            this.TempMapControl.CoordinateSystem = geoMapCoordinateSystem1;
            this.TempMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TempMapControl.Layers.Add(this.imageLayer1);
            this.TempMapControl.Location = new System.Drawing.Point(23, 86);
            this.TempMapControl.Name = "TempMapControl";
            this.tablePanel1.SetRow(this.TempMapControl, 2);
            this.tablePanel1.SetRowSpan(this.TempMapControl, 8);
            this.TempMapControl.Size = new System.Drawing.Size(681, 546);
            this.TempMapControl.TabIndex = 8;
            this.TempMapControl.ZoomLevel = 11D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AldT8DQXZMZIN37VvXh-4jIb4GaOdsG1ui_Y6S8dAdueZ4s94BmJwkarIOg8R17K";
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 10);
            this.textEdit1.Location = new System.Drawing.Point(809, 36);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel1.SetRow(this.textEdit1, 1);
            this.textEdit1.Size = new System.Drawing.Size(92, 24);
            this.textEdit1.TabIndex = 9;
            // 
            // SelectTownForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 720);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTownForm";
            this.Text = "SelectTownForm";
            ((System.ComponentModel.ISupportInitialize)(this.cbxGu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDisplayStation;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraMap.MapControl TempMapControl;
        private DevExpress.XtraEditors.SimpleButton btnResult;
        private DevExpress.XtraEditors.ComboBoxEdit cbxField;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}