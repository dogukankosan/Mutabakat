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
    public partial class MapCustomer : DevExpress.XtraEditors.XtraForm
    {
        public MapCustomer()
        {
            InitializeComponent();
        }
        SqlConnection myconnet = new SqlConnection(System.IO.File.ReadAllText("Database.txt"));
        FolderBrowserDialog fr = new FolderBrowserDialog();

        void GridList(string gettext)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(gettext, myconnet);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI OKUMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eXCELALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    gridView1.ExportToPdf(fr.SelectedPath + "\\MüsteriAdresListe.pdf");
                    XtraMessageBox.Show(fr.SelectedPath + "MüsteriAdresListe.pdf", "AKTARMA İŞLEMİ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    gridView1.ExportToHtml(fr.SelectedPath + "\\MüsteriAdresListe.html");
                    XtraMessageBox.Show(fr.SelectedPath + "MüsteriAdresListe.html", "AKTARMA İŞLEMİ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HTML DOSYANIZI KAPATINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eXCELALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    gridView1.ExportToXlsx(fr.SelectedPath + "\\MüsteriAdresListe.xlsx");
                    XtraMessageBox.Show(fr.SelectedPath + "\\MüsteriAdresListe.xlsx", "AKTARMA İŞLEMİ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "EXCEL DOSYANIZI KAPATINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MapCustomer_Load(object sender, EventArgs e)
        {
            GridList("select CARKART.CARUNVAN, ADRULKE, ADRIL, ADRILCE, ADRADRES1 from ADRESLER inner join CARKART on CARKART.CARKOD = ADRESLER.ADRKOD1 order by CARUNVAN");
        }
        private void MapCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}