
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblViewCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblViewRank = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.5F)});
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.lblViewRank);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.lblViewCategory);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 0.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.5F)});
            this.tablePanel1.Size = new System.Drawing.Size(1020, 688);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.tablePanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 107);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 2);
            this.tablePanel1.SetRowSpan(this.gridControl1, 2);
            this.gridControl1.Size = new System.Drawing.Size(504, 476);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetColumn(this.chartControl1, 2);
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(513, 107);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 2);
            this.tablePanel1.SetRowSpan(this.chartControl1, 2);
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(351, 476);
            this.chartControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(249, 46);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "연도별 평가점수 기준";
            // 
            // lblViewCategory
            // 
            this.lblViewCategory.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCategory.Appearance.Options.UseFont = true;
            this.lblViewCategory.Appearance.Options.UseTextOptions = true;
            this.lblViewCategory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblViewCategory.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblViewCategory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lblViewCategory, 1);
            this.lblViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewCategory.Location = new System.Drawing.Point(258, 55);
            this.lblViewCategory.Name = "lblViewCategory";
            this.tablePanel1.SetRow(this.lblViewCategory, 1);
            this.lblViewCategory.Size = new System.Drawing.Size(249, 46);
            this.lblViewCategory.TabIndex = 3;
            this.lblViewCategory.Text = "lblViewCategory";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl3, 3);
            this.tablePanel1.SetColumnSpan(this.labelControl3, 3);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(870, 107);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(147, 63);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "추천 역세권";
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
            this.tablePanel1.SetColumn(this.lblViewRank, 3);
            this.tablePanel1.SetColumnSpan(this.lblViewRank, 3);
            this.lblViewRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblViewRank.Location = new System.Drawing.Point(872, 178);
            this.lblViewRank.Margin = new System.Windows.Forms.Padding(5);
            this.lblViewRank.Name = "lblViewRank";
            this.lblViewRank.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanel1.SetRow(this.lblViewRank, 3);
            this.lblViewRank.Size = new System.Drawing.Size(143, 403);
            this.lblViewRank.TabIndex = 5;
            this.lblViewRank.Text = "lblViewRank";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl5, 0);
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(3, 55);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(249, 46);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "추천 역세권";
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 5);
            this.simpleButton1.Location = new System.Drawing.Point(972, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(45, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "안내";
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 3);
            this.tablePanel1.SetColumnSpan(this.simpleButton2, 2);
            this.simpleButton2.Location = new System.Drawing.Point(870, 625);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 4);
            this.simpleButton2.Size = new System.Drawing.Size(96, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "돌아가기";
            // 
            // AnnualScoreForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 688);
            this.Controls.Add(this.tablePanel1);
            this.Name = "AnnualScoreForm";
            this.Text = "AnnualScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}