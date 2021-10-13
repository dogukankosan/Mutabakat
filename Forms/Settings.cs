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
using System.IO;
using System.Data.SqlClient;

namespace ETARaporlama.Forms
{
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        Encryption en = new Encryption();
        SqlConnection myconnet = new SqlConnection(File.ReadAllText("Database.txt"));
       void update()
        {
            try
            {

                myconnet.Open();
                SqlCommand command = new SqlCommand("update ADRESLER set ADREMAIL1= RTRIM(LTRIM('" + gridView1.GetFocusedRowCellValue("ADREMAIL1")+"')) where ADRKOD1='"+gridView1.GetFocusedRowCellValue("CARKOD")+"'", myconnet);
                command.ExecuteNonQuery();
                myconnet.Close();
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void List(string gettext)
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
        void TextCek()
        {
            try
            {
                textEdit1.Text = File.ReadAllText("Mail.txt");
                textEdit2.Text = en.Desc(File.ReadAllText("4.txt"));
                textEdit3.Text = File.ReadAllText("port.txt");
                textEdit4.Text = File.ReadAllText("host.txt");
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "DOSYA YOLUNU KONTROL EDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void TextUpdate()
        {
            try
            {

                File.WriteAllText("Mail.txt", textEdit1.Text);
                File.WriteAllText("4.txt", en.Enc(textEdit2.Text));
                File.WriteAllText("port.txt", textEdit3.Text);
                File.WriteAllText("host.txt", textEdit4.Text);
                XtraMessageBox.Show("BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message,"HATALI GÜNCELLEME İŞLEMİ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            TextCek();
            List("select CARKOD,CARUNVAN,ADREMAIL1 FROM CARKART left join ADRESLER on ADRESLER.ADRKOD1=CARKOD order by ADREMAIL1,CARUNVAN");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TextUpdate();
        }
        private void textEdit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            update();
        }
    }
}