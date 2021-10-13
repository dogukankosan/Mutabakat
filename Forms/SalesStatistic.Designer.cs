
namespace ETARaporlama.Forms
{
    partial class SalesStatistic
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
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView5 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesStatistic));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eXCELALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESİMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Dark";
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartControl1.BorderOptions.Thickness = 4;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram5;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 6;
            this.chartControl1.PaletteName = "Concourse";
            series5.LegendTextPattern = "{A}";
            series5.Name = "EN BORCLU CARİ";
            sideBySideBarSeriesView5.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            sideBySideBarSeriesView5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
            sideBySideBarSeriesView5.ColorEach = true;
            series5.View = sideBySideBarSeriesView5;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl1.Size = new System.Drawing.Size(1500, 693);
            this.chartControl1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXCELALToolStripMenuItem,
            this.rESİMALToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 56);
            // 
            // eXCELALToolStripMenuItem
            // 
            this.eXCELALToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.eXCELALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXCELALToolStripMenuItem.Image")));
            this.eXCELALToolStripMenuItem.Name = "eXCELALToolStripMenuItem";
            this.eXCELALToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.eXCELALToolStripMenuItem.Text = "PDF AL";
            this.eXCELALToolStripMenuItem.Click += new System.EventHandler(this.eXCELALToolStripMenuItem_Click);
            // 
            // rESİMALToolStripMenuItem
            // 
            this.rESİMALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rESİMALToolStripMenuItem.Image")));
            this.rESİMALToolStripMenuItem.Name = "rESİMALToolStripMenuItem";
            this.rESİMALToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.rESİMALToolStripMenuItem.Text = "RESİM AL";
            this.rESİMALToolStripMenuItem.Click += new System.EventHandler(this.rESİMALToolStripMenuItem_Click);
            // 
            // SalesStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1500, 693);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.chartControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SalesStatistic.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP(5) SATICI CARİ";
            this.Load += new System.EventHandler(this.SalesStatistic_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesStatistic_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXCELALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESİMALToolStripMenuItem;
    }
}