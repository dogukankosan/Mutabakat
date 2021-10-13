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
using System.Net;
using System.Net.Mail;
using System.IO;
using iTextSharp.text;

namespace ETARaporlama.Forms
{
    public partial class Mutabakat : DevExpress.XtraEditors.XtraForm
    {
        public Mutabakat()
        {
            InitializeComponent();
        }
        SqlConnection myconnet = new SqlConnection(File.ReadAllText("Database.txt"));
        bool hover = false;
        int sentcount = 0, notsentcount = 0;
        void ListCustomer(string gettext)
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
        private void Mutabakat_Load(object sender, EventArgs e)
        {
            ListCustomer("select CARKART.CARKOD,CARKART.CARUNVAN,format(CARBAKIYE,'N','tr-TR') as BAKİYE,ADREMAIL1 FROM CARKART  left join ADRESLER on ADRESLER.ADRKOD1=CARKOD order by CARBAKIYE desc");
            dateEdit1.Text = DateTime.Now.ToShortDateString();
        }
        private void Mutabakat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        void PdfCreate()
        {
            try
            {
                DirectoryInfo file = new DirectoryInfo(Application.StartupPath + "\\PDF".ToString());
                foreach (FileInfo files in file.GetFiles())
                {
                    files.Delete();
                }
                foreach (DirectoryInfo k in file.GetDirectories())
                {
                    k.Delete(true);
                }
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, "ADREMAIL1").ToString() != "")
                    {
                        FileStream fs = new FileStream(Application.StartupPath + "\\PDF\\" + gridView1.GetRowCellValue(i, "CARUNVAN") + ".pdf".ToString(), FileMode.OpenOrCreate);
                        iTextSharp.text.Document pdf = new iTextSharp.text.Document();
                        iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdf, fs);
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\res.png");
                        img.ScaleToFit(200, 100);
                        pdf.Open();
                        pdf.Add(img);
                        pdf.Add(new iTextSharp.text.Paragraph(Environment.NewLine + "Sayin  " + gridView1.GetRowCellValue(i, "CARUNVAN").ToString() + Environment.NewLine + " ", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("Sirketimiz Nezdindeki Hesabi Cariniz  " + DateTime.Now.ToShortDateString() + "  Tarihi itibariyle  " + gridView1.GetRowCellValue(i, "BAKİYE").ToString() + " TL'dir" + Environment.NewLine + " ", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("Mutabik Olup Olmadiginizi Bildirmenizi Rica Ederiz." + Environment.NewLine + " ", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("Saygilarimizla," + Environment.NewLine + "  ", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("NOTLAR:", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("*HATA VE UNUTMA MUSTESNADIR...", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("*MUTABAKAT VEYA ITIRAZINIZI BILDIRMEDIGINIZ TAKTIRDE T.T.K'NUN 92.MADDESINE GERECEGINCE BAKIYEDE MUTABIK SAYILACAGINIZI HATIRLATIRIZ.", fontNormal));
                        pdf.Add(new iTextSharp.text.Paragraph("*BAKIYEDE MUTABIK OLMADIGINIZ TAKTIRDE BIR HESAP EKSTRENIZIN GONDERILMESINI RICA EDERIZ.", fontNormal));
                        pdf.Close();
                        fs.Close();
                    }
                }
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI PDF OLUŞTURMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBoxControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hover == false)
            {
                toolTip1.SetToolTip(listBoxControl1, "GÖNDERİLEMEYEN CARİLER");
                hover = true;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {     
            DialogResult cv = new DialogResult();
            cv = XtraMessageBox.Show("TOPLU OLARAK CARİLERİNİZE MAİL GÖNDERMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", ""+gridView1.RowCount.ToString()+" KİŞİYE MAİL GÖNDERİLECEKTİR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cv == DialogResult.Yes)
            {
                notsentcount = 0;
                sentcount = 0;
                listBoxControl1.Items.Clear();
                PdfCreate();
                Encryption enc = new Encryption();
                SmtpClient cl = new SmtpClient();
                MailMessage ms = new MailMessage();
                cl.Credentials = new NetworkCredential(File.ReadAllText("Mail.txt"), enc.Desc(File.ReadAllText("4.txt")).ToString());
                ms.From = new MailAddress((File.ReadAllText("Mail.txt")));
                cl.Host = File.ReadAllText("host.txt");
                cl.Port = Convert.ToInt32(File.ReadAllText("port.txt"));
                cl.EnableSsl = true;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gel:
                    try
                    {
                        if (gridView1.GetRowCellValue(i, "CARUNVAN")!=null)
                        {

                            if (File.Exists(Application.StartupPath + "\\PDF\\" + gridView1.GetRowCellValue(i, "CARUNVAN").ToString() + ".pdf"))
                            {
                                Attachment at = new Attachment(Application.StartupPath + "\\PDF\\" + gridView1.GetRowCellValue(i, "CARUNVAN").ToString() + ".pdf");
                                ms.To.Add(gridView1.GetRowCellValue(i, "ADREMAIL1").ToString());
                                ms.Subject = "MUTABAKAT MEKTUBU";
                                ms.Attachments.Add(at);
                                cl.Send(ms);
                                ms.Attachments.Clear();
                                ms.To.Clear();
                                sentcount++;
                                at.Dispose();
                            }
                            else
                            {
                                notsentcount++;
                                listBoxControl1.Items.Add(gridView1.GetRowCellValue(i, "CARUNVAN").ToString());
                            }
                        }
                    }
                    catch (ArgumentException)
                    {
                        i++;
                       goto gel;
                   
                    }
                    catch (FormatException)
                    {
                        notsentcount++;
                        listBoxControl1.Items.Add(gridView1.GetRowCellValue(i, "CARUNVAN").ToString());
                        i++;
                        goto gel; 
                    }
                }
                listBoxControl1.Visible = true;
                labelControl3.Text = sentcount.ToString();
                labelControl4.Text = notsentcount.ToString();
                XtraMessageBox.Show("TOPLU OLARAK MAİL GÖNDERME İŞLEMİ TAMAMLANDI",""+sentcount.ToString()+" KİŞİYE MAİL GÖNDERİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XtraMessageBox.Show("TOPLU OLARAK MAİL GÖNDERME İŞLEMİ TAMAMLANDI", "" + notsentcount.ToString() + " KİŞİYE MAİL GÖNDERİLEMEDİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}



