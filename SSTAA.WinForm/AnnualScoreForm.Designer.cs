
namespace SSTAA.WinForm
{
    partial class AnnualScoreForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblViewRank = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblViewCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.annualEvaluationScoreModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdScore = new DevExpress.XtraGrid.GridControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstEvaluationScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondEvaluationScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThirdEvaluationScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFourthEvaluationScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgwDataSource = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualEvaluationScoreModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.2F)});
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.lblViewRank);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.lblViewCategory);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Controls.Add(this.grdScore);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.2F)});
            this.tablePanel1.Size = new System.Drawing.Size(894, 607);
            this.tablePanel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.simpleButton2, 4);
            this.tablePanel1.SetColumnSpan(this.simpleButton2, 3);
            this.simpleButton2.Location = new System.Drawing.Point(751, 555);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 5);
            this.simpleButton2.Size = new System.Drawing.Size(123, 30);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "돌아가기";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.simpleButton1, 6);
            this.simpleButton1.Location = new System.Drawing.Point(837, 27);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 1);
            this.simpleButton1.Size = new System.Drawing.Size(37, 18);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "안내";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl5, 1);
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(20, 62);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 2);
            this.labelControl5.Size = new System.Drawing.Size(209, 43);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "추천 역세권";
            // 
            // lblViewRank
            // 
            this.lblViewRank.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRank.Appearance.Options.UseFont = true;
            this.lblViewRank.Appearance.Options.UseTextOptions = true;
            this.lblViewRank.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblViewRank.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblViewRank.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblViewRank.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetColumn(this.lblViewRank, 4);
            this.tablePanel1.SetColumnSpan(this.lblViewRank, 3);
            this.lblViewRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewRank.Location = new System.Drawing.Point(752, 174);
            this.lblViewRank.Margin = new System.Windows.Forms.Padding(4);
            this.lblViewRank.Name = "lblViewRank";
            this.lblViewRank.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel1.SetRow(this.lblViewRank, 4);
            this.lblViewRank.Size = new System.Drawing.Size(121, 369);
            this.lblViewRank.TabIndex = 5;
            this.lblViewRank.Text = "lblViewRank";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl3, 4);
            this.tablePanel1.SetColumnSpan(this.labelControl3, 3);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(751, 110);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 3);
            this.labelControl3.Size = new System.Drawing.Size(123, 57);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "추천 역세권";
            // 
            // lblViewCategory
            // 
            this.lblViewCategory.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCategory.Appearance.Options.UseFont = true;
            this.lblViewCategory.Appearance.Options.UseTextOptions = true;
            this.lblViewCategory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblViewCategory.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblViewCategory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lblViewCategory, 2);
            this.lblViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewCategory.Location = new System.Drawing.Point(235, 62);
            this.lblViewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblViewCategory.Name = "lblViewCategory";
            this.tablePanel1.SetRow(this.lblViewCategory, 2);
            this.lblViewCategory.Size = new System.Drawing.Size(209, 43);
            this.lblViewCategory.TabIndex = 3;
            this.lblViewCategory.Text = "lblViewCategory";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(20, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(209, 43);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "연도별 평가점수 기준";
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetColumn(this.chartControl1, 3);
            this.chartControl1.DataSource = this.annualEvaluationScoreModelBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(450, 109);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 3);
            this.tablePanel1.SetRowSpan(this.chartControl1, 2);
            series5.ArgumentDataMember = "StationName";
            series5.CrosshairLabelPattern = "{S}:{V:0.00}";
            series5.FilterString = "[Rank] <= 5";
            sideBySideBarSeriesLabel2.TextPattern = "{A}:{V:0.00}";
            series5.Label = sideBySideBarSeriesLabel2;
            series5.Name = "2017";
            series5.ValueDataMembersSerializable = "FirstEvaluationScore";
            series6.ArgumentDataMember = "StationName";
            series6.CrosshairLabelPattern = "{S}:{V:0.00}";
            series6.FilterString = "[Rank] <= 5";
            series6.Name = "2018";
            series6.ValueDataMembersSerializable = "SecondEvaluationScore";
            series7.ArgumentDataMember = "StationName";
            series7.CrosshairLabelPattern = "{S}:{V:0.00}";
            series7.FilterString = "[Rank] <= 5";
            series7.Name = "2019";
            series7.ValueDataMembersSerializable = "ThirdEvaluationScore";
            series8.ArgumentDataMember = "StationName";
            series8.CrosshairLabelPattern = "{S}:{V:0.00}";
            series8.FilterString = "[Rank] <= 5";
            series8.Name = "2020";
            series8.ValueDataMembersSerializable = "FourthEvaluationScore";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5,
        series6,
        series7,
        series8};
            this.chartControl1.Size = new System.Drawing.Size(295, 436);
            this.chartControl1.TabIndex = 1;
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            chartTitle2.Text = "연도별 평가점수(3년) 및 기대점수";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // annualEvaluationScoreModelBindingSource
            // 
            this.annualEvaluationScoreModelBindingSource.DataSource = typeof(SSTAA.Data.AnnualEvaluationScoreModel);
            // 
            // grdScore
            // 
            this.tablePanel1.SetColumn(this.grdScore, 1);
            this.tablePanel1.SetColumnSpan(this.grdScore, 2);
            this.grdScore.DataSource = this.annualEvaluationScoreModelBindingSource;
            this.grdScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdScore.EmbeddedNavigator.ToolTipController = this.toolTipController1;
            this.grdScore.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Exclamation;
            this.grdScore.Location = new System.Drawing.Point(23, 141);
            this.grdScore.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdScore.MainView = this.gridView1;
            this.grdScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdScore.Name = "grdScore";
            this.tablePanel1.SetRow(this.grdScore, 3);
            this.tablePanel1.SetRowSpan(this.grdScore, 2);
            this.grdScore.Size = new System.Drawing.Size(424, 436);
            this.grdScore.TabIndex = 0;
            this.grdScore.ToolTipController = this.toolTipController1;
            this.grdScore.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdScore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdScore_MouseDoubleClick);
            // 
            // toolTipController1
            // 
            this.toolTipController1.IconSize = DevExpress.Utils.ToolTipIconSize.Large;
            this.toolTipController1.ReshowDelay = 5000;
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colStationName,
            this.colFirstEvaluationScore,
            this.colSecondEvaluationScore,
            this.colThirdEvaluationScore,
            this.colFourthEvaluationScore});
            this.gridView1.DetailHeight = 272;
            this.gridView1.GridControl = this.grdScore;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "순위";
            this.gridColumn1.FieldName = "Rank";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 33;
            // 
            // colStationName
            // 
            this.colStationName.Caption = "역명";
            this.colStationName.FieldName = "StationName";
            this.colStationName.Name = "colStationName";
            this.colStationName.OptionsColumn.AllowEdit = false;
            this.colStationName.OptionsColumn.AllowMove = false;
            this.colStationName.Visible = true;
            this.colStationName.VisibleIndex = 1;
            this.colStationName.Width = 85;
            // 
            // colFirstEvaluationScore
            // 
            this.colFirstEvaluationScore.Caption = "2017";
            this.colFirstEvaluationScore.DisplayFormat.FormatString = "0.00";
            this.colFirstEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFirstEvaluationScore.FieldName = "FirstEvaluationScore";
            this.colFirstEvaluationScore.Name = "colFirstEvaluationScore";
            this.colFirstEvaluationScore.OptionsColumn.AllowEdit = false;
            this.colFirstEvaluationScore.OptionsColumn.AllowMove = false;
            this.colFirstEvaluationScore.Visible = true;
            this.colFirstEvaluationScore.VisibleIndex = 2;
            this.colFirstEvaluationScore.Width = 68;
            // 
            // colSecondEvaluationScore
            // 
            this.colSecondEvaluationScore.Caption = "2018";
            this.colSecondEvaluationScore.DisplayFormat.FormatString = "0.00";
            this.colSecondEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSecondEvaluationScore.FieldName = "SecondEvaluationScore";
            this.colSecondEvaluationScore.Name = "colSecondEvaluationScore";
            this.colSecondEvaluationScore.OptionsColumn.AllowEdit = false;
            this.colSecondEvaluationScore.OptionsColumn.AllowMove = false;
            this.colSecondEvaluationScore.Visible = true;
            this.colSecondEvaluationScore.VisibleIndex = 3;
            this.colSecondEvaluationScore.Width = 68;
            // 
            // colThirdEvaluationScore
            // 
            this.colThirdEvaluationScore.Caption = "2019";
            this.colThirdEvaluationScore.DisplayFormat.FormatString = "0.00";
            this.colThirdEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colThirdEvaluationScore.FieldName = "ThirdEvaluationScore";
            this.colThirdEvaluationScore.Name = "colThirdEvaluationScore";
            this.colThirdEvaluationScore.OptionsColumn.AllowEdit = false;
            this.colThirdEvaluationScore.OptionsColumn.AllowMove = false;
            this.colThirdEvaluationScore.Visible = true;
            this.colThirdEvaluationScore.VisibleIndex = 4;
            this.colThirdEvaluationScore.Width = 68;
            // 
            // colFourthEvaluationScore
            // 
            this.colFourthEvaluationScore.Caption = "2020";
            this.colFourthEvaluationScore.DisplayFormat.FormatString = "0.00";
            this.colFourthEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFourthEvaluationScore.FieldName = "FourthEvaluationScore";
            this.colFourthEvaluationScore.Name = "colFourthEvaluationScore";
            this.colFourthEvaluationScore.OptionsColumn.AllowEdit = false;
            this.colFourthEvaluationScore.OptionsColumn.AllowMove = false;
            this.colFourthEvaluationScore.Visible = true;
            this.colFourthEvaluationScore.VisibleIndex = 5;
            this.colFourthEvaluationScore.Width = 77;
            // 
            // bgwDataSource
            // 
            this.bgwDataSource.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDataSource_DoWork);
            this.bgwDataSource.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDataSource_RunWorkerCompleted);
            // 
            // AnnualScoreForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 607);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnnualScoreForm";
            this.Text = "AnnualScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualEvaluationScoreModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblViewRank;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblViewCategory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl grdScore;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource annualEvaluationScoreModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStationName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstEvaluationScore;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondEvaluationScore;
        private DevExpress.XtraGrid.Columns.GridColumn colThirdEvaluationScore;
        private DevExpress.XtraGrid.Columns.GridColumn colFourthEvaluationScore;
        private System.ComponentModel.BackgroundWorker bgwDataSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}