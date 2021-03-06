﻿
namespace SSTAA.WinForm
{
    partial class StationScoreForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedAreaSeriesView stackedAreaSeriesView1 = new DevExpress.XtraCharts.StackedAreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.monthlyEvaluationScoreModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFloatingPopulation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyLandPriceIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthlyEvaluationScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.lblRank = new DevExpress.XtraEditors.LabelControl();
            this.bgwDataSource = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyEvaluationScoreModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.chartControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.btnReturn);
            this.tablePanel1.Controls.Add(this.lblScore);
            this.tablePanel1.Controls.Add(this.lblRank);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Size = new System.Drawing.Size(892, 576);
            this.tablePanel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.tablePanel1.SetColumnSpan(this.labelControl2, 4);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(24, 14);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(366, 59);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "labelControl2";
            // 
            // chartControl2
            // 
            this.chartControl2.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.tablePanel1.SetColumn(this.chartControl2, 5);
            this.tablePanel1.SetColumnSpan(this.chartControl2, 5);
            this.chartControl2.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl2.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl2.Legend.Margins.Bottom = 0;
            this.chartControl2.Legend.MarkerSize = new System.Drawing.Size(16, 10);
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(396, 294);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl2.Name = "chartControl2";
            this.tablePanel1.SetRow(this.chartControl2, 6);
            this.tablePanel1.SetRowSpan(this.chartControl2, 5);
            series1.ArgumentDataMember = "Date";
            series1.Name = "07~08승차";
            series1.ValueDataMembersSerializable = "FloationPopulationBySevenToEightOnBoard";
            series1.View = lineSeriesView1;
            series2.ArgumentDataMember = "Date";
            series2.Name = "07~08하차";
            series2.ValueDataMembersSerializable = "FloationPopulationBySevenToEightOffBoard";
            series2.View = lineSeriesView2;
            series3.ArgumentDataMember = "Date";
            series3.Name = "18~19승차";
            series3.ValueDataMembersSerializable = "FloationPopulationByEighteenToNineteenOnBoard";
            series3.View = lineSeriesView3;
            series4.ArgumentDataMember = "Date";
            series4.Name = "18~19하차";
            series4.ValueDataMembersSerializable = "FloationPopulationByEighteenToNineteenOffBoard";
            series4.View = lineSeriesView4;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartControl2.Size = new System.Drawing.Size(365, 255);
            this.chartControl2.TabIndex = 8;
            // 
            // monthlyEvaluationScoreModelBindingSource
            // 
            this.monthlyEvaluationScoreModelBindingSource.DataSource = typeof(SSTAA.Data.MonthlyEvaluationScoreModel);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 10);
            this.tablePanel1.SetColumnSpan(this.labelControl1, 3);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(768, 240);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 5);
            this.tablePanel1.SetRowSpan(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(100, 104);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "기대점수";
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.tablePanel1.SetColumn(this.chartControl1, 5);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 5);
            this.chartControl1.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(396, 78);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 2);
            this.tablePanel1.SetRowSpan(this.chartControl1, 4);
            series5.ArgumentDataMember = "Date";
            series5.Name = "평가점수";
            series5.ValueDataMembersSerializable = "MonthlyEvaluationScore";
            series5.View = stackedAreaSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl1.Size = new System.Drawing.Size(365, 212);
            this.chartControl1.TabIndex = 6;
            chartTitle1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            chartTitle1.Text = "평가점수(월별)";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 1);
            this.tablePanel1.SetColumnSpan(this.gridControl1, 4);
            this.gridControl1.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(24, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 2);
            this.tablePanel1.SetRowSpan(this.gridControl1, 9);
            this.gridControl1.Size = new System.Drawing.Size(366, 471);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colFloatingPopulation,
            this.colMonthlyLandPriceIndex,
            this.colMonthlyEvaluationScore});
            this.gridView1.DetailHeight = 272;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "평가월";
            this.colDate.DisplayFormat.FormatString = "yyyy-MM";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.GroupFormat.FormatString = "yyyy-MM";
            this.colDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsColumn.AllowMove = false;
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 66;
            // 
            // colFloatingPopulation
            // 
            this.colFloatingPopulation.Caption = "유동인구";
            this.colFloatingPopulation.DisplayFormat.FormatString = "#,###";
            this.colFloatingPopulation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFloatingPopulation.FieldName = "FloatingPopulation";
            this.colFloatingPopulation.GroupFormat.FormatString = "#,###";
            this.colFloatingPopulation.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFloatingPopulation.Name = "colFloatingPopulation";
            this.colFloatingPopulation.OptionsColumn.AllowEdit = false;
            this.colFloatingPopulation.OptionsColumn.AllowMove = false;
            this.colFloatingPopulation.Visible = true;
            this.colFloatingPopulation.VisibleIndex = 1;
            this.colFloatingPopulation.Width = 66;
            // 
            // colMonthlyLandPriceIndex
            // 
            this.colMonthlyLandPriceIndex.Caption = "지가지수";
            this.colMonthlyLandPriceIndex.DisplayFormat.FormatString = "0.000";
            this.colMonthlyLandPriceIndex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyLandPriceIndex.FieldName = "MonthlyLandPriceIndex";
            this.colMonthlyLandPriceIndex.GroupFormat.FormatString = "0.000";
            this.colMonthlyLandPriceIndex.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyLandPriceIndex.Name = "colMonthlyLandPriceIndex";
            this.colMonthlyLandPriceIndex.OptionsColumn.AllowEdit = false;
            this.colMonthlyLandPriceIndex.OptionsColumn.AllowMove = false;
            this.colMonthlyLandPriceIndex.OptionsColumn.ReadOnly = true;
            this.colMonthlyLandPriceIndex.Visible = true;
            this.colMonthlyLandPriceIndex.VisibleIndex = 2;
            this.colMonthlyLandPriceIndex.Width = 66;
            // 
            // colMonthlyEvaluationScore
            // 
            this.colMonthlyEvaluationScore.Caption = "평가점수";
            this.colMonthlyEvaluationScore.DisplayFormat.FormatString = "0.000";
            this.colMonthlyEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyEvaluationScore.FieldName = "MonthlyEvaluationScore";
            this.colMonthlyEvaluationScore.GroupFormat.FormatString = "0.000";
            this.colMonthlyEvaluationScore.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyEvaluationScore.Name = "colMonthlyEvaluationScore";
            this.colMonthlyEvaluationScore.OptionsColumn.AllowEdit = false;
            this.colMonthlyEvaluationScore.OptionsColumn.AllowMove = false;
            this.colMonthlyEvaluationScore.Visible = true;
            this.colMonthlyEvaluationScore.VisibleIndex = 3;
            this.colMonthlyEvaluationScore.Width = 66;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tablePanel1.SetColumn(this.labelControl3, 11);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(799, 78);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(36, 50);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "순위";
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnReturn, 10);
            this.tablePanel1.SetColumnSpan(this.btnReturn, 3);
            this.btnReturn.Location = new System.Drawing.Point(768, 469);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.tablePanel1.SetRow(this.btnReturn, 9);
            this.btnReturn.Size = new System.Drawing.Size(100, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "돌아가기";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblScore
            // 
            this.lblScore.Appearance.BackColor = System.Drawing.Color.White;
            this.lblScore.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Appearance.Options.UseBackColor = true;
            this.lblScore.Appearance.Options.UseFont = true;
            this.lblScore.Appearance.Options.UseTextOptions = true;
            this.lblScore.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblScore.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblScore.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetColumn(this.lblScore, 10);
            this.tablePanel1.SetColumnSpan(this.lblScore, 3);
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Location = new System.Drawing.Point(768, 348);
            this.lblScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblScore.Name = "lblScore";
            this.tablePanel1.SetRow(this.lblScore, 7);
            this.lblScore.Size = new System.Drawing.Size(100, 50);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "30.789";
            // 
            // lblRank
            // 
            this.lblRank.Appearance.BackColor = System.Drawing.Color.White;
            this.lblRank.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Appearance.Options.UseBackColor = true;
            this.lblRank.Appearance.Options.UseFont = true;
            this.lblRank.Appearance.Options.UseTextOptions = true;
            this.lblRank.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRank.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblRank.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetColumn(this.lblRank, 10);
            this.tablePanel1.SetColumnSpan(this.lblRank, 3);
            this.lblRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRank.Location = new System.Drawing.Point(768, 132);
            this.lblRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRank.Name = "lblRank";
            this.tablePanel1.SetRow(this.lblRank, 3);
            this.lblRank.Size = new System.Drawing.Size(100, 50);
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "5위";
            // 
            // bgwDataSource
            // 
            this.bgwDataSource.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDataSource_DoWork);
            this.bgwDataSource.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDataSource_RunWorkerCompleted);
            // 
            // StationScoreForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 576);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StationScoreForm";
            this.Text = "StationScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyEvaluationScoreModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private DevExpress.XtraEditors.LabelControl lblRank;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.BindingSource monthlyEvaluationScoreModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFloatingPopulation;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLandPriceIndex;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyEvaluationScore;
        private System.ComponentModel.BackgroundWorker bgwDataSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}