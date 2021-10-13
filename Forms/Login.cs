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
using System.IO;

namespace ETARaporlama.Forms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection myconnet = new SqlConnection(File.ReadAllText("Database.txt"));
        string company, fileread;
        void Control()
        {
            Encryption enc = new Encryption();
            StreamWriter wr = new StreamWriter("8.txt");
            wr.Write(enc.Enc("07.10.2022"));
            wr.Close();
            FileStream read = new FileStream("8.txt", FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(read);
            string readveri = rd.ReadLine();
            rd.Close();
            read.Close();
            if (DateTime.Today >=Convert.ToDateTime(enc.Desc(readveri)))
            {
                XtraMessageBox.Show("PROGRAMDA BİR YILINIZI DOLDURDUNUZ LÜTFEN TEKCOM BİLGİSAYAR OKAN KOŞAN (0542)-(262)-(4132) VEYA DOĞUKAN KOŞAN (0544)-(289)-(5650)","SATICINIZA BAŞVURUNUZ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Control();
            DatabaseList("select name as 'ŞİRKETLERİNİZ' from sys.databases where name like '%ETA%'");  
        }
        void DatabaseList(string getttext)
        {
            SqlDataAdapter da = new SqlDataAdapter(getttext, myconnet);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                company = gridView1.GetFocusedRowCellValue("ŞİRKETLERİNİZ").ToString();

                FileStream read = new FileStream("Database.txt", FileMode.Open, FileAccess.Read);
                StreamReader rd = new StreamReader(read);
                fileread = rd.ReadLine();
                fileread = fileread.Replace(File.ReadAllText("table.txt"), company);
                rd.Close();
                read.Close();
                //
                FileStream fs = new FileStream("table.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter swr = new StreamWriter(fs);
                swr.Write(company);
                swr.Close();
                fs.Close();
                ///

                FileStream fst = new FileStream("Database.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fst);
                wr.Write(fileread);
                wr.Close();
                fst.Close();

                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "OKUMA İŞLEMİ HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}