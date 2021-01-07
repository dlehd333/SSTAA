
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
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
            this.lblStationExp = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.lblRank = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyEvaluationScoreModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
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
            this.tablePanel1.Controls.Add(this.chartControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.lblStationExp);
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
            this.tablePanel1.Size = new System.Drawing.Size(1022, 728);
            this.tablePanel1.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.tablePanel1.SetColumn(this.chartControl2, 5);
            this.tablePanel1.SetColumnSpan(this.chartControl2, 5);
            this.chartControl2.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(453, 366);
            this.chartControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl2.Name = "chartControl2";
            this.tablePanel1.SetRow(this.chartControl2, 6);
            this.tablePanel1.SetRowSpan(this.chartControl2, 4);
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(420, 276);
            this.chartControl2.TabIndex = 8;
            // 
            // monthlyEvaluationScoreModelBindingSource
            // 
            this.monthlyEvaluationScoreModelBindingSource.DataSource = typeof(SSTAA.Data.MonthlyEvaluationScoreModel);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
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
            this.labelControl1.Location = new System.Drawing.Point(879, 366);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 6);
            this.labelControl1.Size = new System.Drawing.Size(116, 66);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "기대점수";
            // 
            // chartControl1
            // 
            this.tablePanel1.SetColumn(this.chartControl1, 5);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 5);
            this.chartControl1.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(453, 86);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 2);
            this.tablePanel1.SetRowSpan(this.chartControl1, 4);
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(420, 276);
            this.chartControl1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 1);
            this.tablePanel1.SetColumnSpan(this.gridControl1, 4);
            this.gridControl1.DataSource = this.monthlyEvaluationScoreModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(27, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 2);
            this.tablePanel1.SetRowSpan(this.gridControl1, 8);
            this.gridControl1.Size = new System.Drawing.Size(420, 556);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colDate.DisplayFormat.FormatString = "yyyy-MM";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 66;
            // 
            // colFloatingPopulation
            // 
            this.colFloatingPopulation.DisplayFormat.FormatString = "#,###";
            this.colFloatingPopulation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFloatingPopulation.FieldName = "FloatingPopulation";
            this.colFloatingPopulation.Name = "colFloatingPopulation";
            this.colFloatingPopulation.Visible = true;
            this.colFloatingPopulation.VisibleIndex = 1;
            this.colFloatingPopulation.Width = 66;
            // 
            // colMonthlyLandPriceIndex
            // 
            this.colMonthlyLandPriceIndex.DisplayFormat.FormatString = "0.000";
            this.colMonthlyLandPriceIndex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyLandPriceIndex.FieldName = "MonthlyLandPriceIndex";
            this.colMonthlyLandPriceIndex.Name = "colMonthlyLandPriceIndex";
            this.colMonthlyLandPriceIndex.OptionsColumn.ReadOnly = true;
            this.colMonthlyLandPriceIndex.Visible = true;
            this.colMonthlyLandPriceIndex.VisibleIndex = 2;
            this.colMonthlyLandPriceIndex.Width = 66;
            // 
            // colMonthlyEvaluationScore
            // 
            this.colMonthlyEvaluationScore.DisplayFormat.FormatString = "0.000";
            this.colMonthlyEvaluationScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMonthlyEvaluationScore.FieldName = "MonthlyEvaluationScore";
            this.colMonthlyEvaluationScore.Name = "colMonthlyEvaluationScore";
            this.colMonthlyEvaluationScore.Visible = true;
            this.colMonthlyEvaluationScore.VisibleIndex = 3;
            this.colMonthlyEvaluationScore.Width = 66;
            // 
            // lblStationExp
            // 
            this.lblStationExp.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblStationExp.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationExp.Appearance.Options.UseBackColor = true;
            this.lblStationExp.Appearance.Options.UseFont = true;
            this.lblStationExp.Appearance.Options.UseTextOptions = true;
            this.lblStationExp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStationExp.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tablePanel1.SetColumn(this.lblStationExp, 10);
            this.tablePanel1.SetColumnSpan(this.lblStationExp, 3);
            this.lblStationExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStationExp.Location = new System.Drawing.Point(879, 296);
            this.lblStationExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStationExp.Name = "lblStationExp";
            this.tablePanel1.SetRow(this.lblStationExp, 5);
            this.lblStationExp.Size = new System.Drawing.Size(116, 66);
            this.lblStationExp.TabIndex = 4;
            this.lblStationExp.Text = "삼각지역";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tablePanel1.SetColumn(this.labelControl3, 11);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(916, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(43, 66);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "순위";
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnReturn, 10);
            this.tablePanel1.SetColumnSpan(this.btnReturn, 3);
            this.btnReturn.Location = new System.Drawing.Point(879, 597);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.tablePanel1.SetRow(this.btnReturn, 9);
            this.btnReturn.Size = new System.Drawing.Size(116, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "돌아가기";
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
            this.tablePanel1.SetColumn(this.lblScore, 10);
            this.tablePanel1.SetColumnSpan(this.lblScore, 3);
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Location = new System.Drawing.Point(879, 436);
            this.lblScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblScore.Name = "lblScore";
            this.tablePanel1.SetRow(this.lblScore, 7);
            this.lblScore.Size = new System.Drawing.Size(116, 66);
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
            this.tablePanel1.SetColumn(this.lblRank, 10);
            this.tablePanel1.SetColumnSpan(this.lblRank, 3);
            this.lblRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRank.Location = new System.Drawing.Point(879, 156);
            this.lblRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRank.Name = "lblRank";
            this.tablePanel1.SetRow(this.lblRank, 3);
            this.lblRank.Size = new System.Drawing.Size(116, 66);
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "5위";
            // 
            // StationScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 728);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StationScoreForm";
            this.Text = "StationScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyEvaluationScoreModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl lblStationExp;
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
    }
}