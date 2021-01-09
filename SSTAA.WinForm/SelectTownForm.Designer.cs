
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
            this.lblDisplayStation = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnResult = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cbxField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayStation
            // 
            this.lblDisplayStation.Appearance.BackColor = System.Drawing.Color.White;
            this.lblDisplayStation.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStation.Appearance.Options.UseBackColor = true;
            this.lblDisplayStation.Appearance.Options.UseFont = true;
            this.lblDisplayStation.Appearance.Options.UseTextOptions = true;
            this.lblDisplayStation.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDisplayStation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetColumn(this.lblDisplayStation, 9);
            this.tablePanel1.SetColumnSpan(this.lblDisplayStation, 3);
            this.lblDisplayStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayStation.Location = new System.Drawing.Point(639, 72);
            this.lblDisplayStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDisplayStation.Name = "lblDisplayStation";
            this.lblDisplayStation.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel1.SetRow(this.lblDisplayStation, 2);
            this.tablePanel1.SetRowSpan(this.lblDisplayStation, 7);
            this.lblDisplayStation.Size = new System.Drawing.Size(235, 402);
            this.lblDisplayStation.TabIndex = 1;
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
            this.labelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.labelControl2.Location = new System.Drawing.Point(192, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(300, 40);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "원하는 구를 선택하세요";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl3, 9);
            this.labelControl3.Location = new System.Drawing.Point(639, 487);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 9);
            this.labelControl3.Size = new System.Drawing.Size(54, 32);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "업종 : ";
            // 
            // cbxField
            // 
            this.tablePanel1.SetColumn(this.cbxField, 10);
            this.cbxField.Location = new System.Drawing.Point(708, 495);
            this.cbxField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxField.Name = "cbxField";
            this.cbxField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.cbxField, 9);
            this.cbxField.Size = new System.Drawing.Size(80, 20);
            this.cbxField.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnResult, 11);
            this.btnResult.Location = new System.Drawing.Point(794, 493);
            this.btnResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResult.Name = "btnResult";
            this.tablePanel1.SetRow(this.btnResult, 9);
            this.btnResult.Size = new System.Drawing.Size(80, 23);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "결과보기";
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
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
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Controls.Add(this.mapControl1);
            this.tablePanel1.Controls.Add(this.btnResult);
            this.tablePanel1.Controls.Add(this.cbxField);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.lblDisplayStation);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tablePanel1.Size = new System.Drawing.Size(894, 607);
            this.tablePanel1.TabIndex = 0;
            // 
            // mapControl1
            // 
            this.tablePanel1.SetColumn(this.mapControl1, 1);
            this.tablePanel1.SetColumnSpan(this.mapControl1, 7);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.EnableScrolling = false;
            this.mapControl1.EnableZooming = false;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(20, 73);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.tablePanel1.SetRow(this.mapControl1, 2);
            this.tablePanel1.SetRowSpan(this.mapControl1, 8);
            this.mapControl1.Size = new System.Drawing.Size(596, 458);
            this.mapControl1.TabIndex = 8;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "Ajpgpwdlqkf9o_r7GaID0kgX3FEOrhBQYLBVC62hdzkfP0Ekn-Mv8NrNJW8q9bzC";
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer1.ItemStyle.TextColor = System.Drawing.Color.Black;
            this.vectorItemsLayer1.ShapeTitlesPattern = "{SIG_KOR_NM}";
            this.vectorItemsLayer1.ToolTipPattern = "{SIG_KOR_NM}";
            // 
            // SelectTownForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 607);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectTownForm";
            this.Text = "SelectTownForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.cbxField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDisplayStation;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnResult;
        private DevExpress.XtraEditors.ComboBoxEdit cbxField;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
    }
}