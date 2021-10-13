
namespace ETARaporlama.Forms
{
    partial class MapCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapCustomer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eXCELALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESİMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELALToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXCELALToolStripMenuItem,
            this.rESİMALToolStripMenuItem,
            this.eXCELALToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 82);
            // 
            // eXCELALToolStripMenuItem
            // 
            this.eXCELALToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.eXCELALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXCELALToolStripMenuItem.Image")));
            this.eXCELALToolStripMenuItem.Name = "eXCELALToolStripMenuItem";
            this.eXCELALToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.eXCELALToolStripMenuItem.Text = "PDF AL";
            this.eXCELALToolStripMenuItem.Click += new System.EventHandler(this.eXCELALToolStripMenuItem_Click);
            // 
            // rESİMALToolStripMenuItem
            // 
            this.rESİMALToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rESİMALToolStripMenuItem.Image")));
            this.rESİMALToolStripMenuItem.Name = "rESİMALToolStripMenuItem";
            this.rESİMALToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.rESİMALToolStripMenuItem.Text = "RESİM AL(HTML)";
            this.rESİMALToolStripMenuItem.Click += new System.EventHandler(this.rESİMALToolStripMenuItem_Click);
            // 
            // eXCELALToolStripMenuItem1
            // 
            this.eXCELALToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("eXCELALToolStripMenuItem1.Image")));
            this.eXCELALToolStripMenuItem1.Name = "eXCELALToolStripMenuItem1";
            this.eXCELALToolStripMenuItem1.Size = new System.Drawing.Size(194, 26);
            this.eXCELALToolStripMenuItem1.Text = "EXCEL AL";
            this.eXCELALToolStripMenuItem1.Click += new System.EventHandler(this.eXCELALToolStripMenuItem1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1500, 693);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Teal;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Teal;
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Blue;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MapCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1500, 693);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MapCustomer.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HARİTA MÜŞTERİLER";
            this.Load += new System.EventHandler(this.MapCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapCustomer_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXCELALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESİMALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELALToolStripMenuItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}