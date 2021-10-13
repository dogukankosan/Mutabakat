using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETARaporlama.Forms
{
    public partial class SalesStatistic : DevExpress.XtraEditors.XtraForm
    {
        public SalesStatistic()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fr = new FolderBrowserDialog();
        SqlConnection myconnet = new SqlConnection(System.IO.File.ReadAllText("Database.txt"));
        void GridList()
        {
            try
            {
                myconnet.Open();
                SqlCommand command = new SqlCommand("select TOP 5  CARUNVAN ,CARBAKIYE from CARKART where CARBAKIYE<0  order by CARBAKIYE asc", myconnet);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    chartControl1.Series[0].Points.Add(new DevExpress.XtraCharts.SeriesPoint(read[0], read[1]));
                }
                myconnet.Close();
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI OKUMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myconnet.Close();
            }
        }
        private void eXCELALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    chartControl1.ExportToPdf(fr.SelectedPath + "\\CariTop(5)Satıcı.pdf");
                    XtraMessageBox.Show(fr.SelectedPath + "CariTop(5)Satıcı.pdf", "AKTARMA İŞLEMİ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "PDF DOSYANIZI KAPATINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rESİMALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    chartControl1.ExportToImage(fr.SelectedPath + "\\CariTop(5)Satıcı.png", System.Drawing.Imaging.ImageFormat.Png);
                    XtraMessageBox.Show(fr.SelectedPath + "CariTop(5)Satıcı.png", "AKTARMA İŞLEMİ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "RESİM DOSYANIZI KAPATINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalesStatistic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void SalesStatistic_Load(object sender, EventArgs e)
        {
            GridList();
        }
    }
}