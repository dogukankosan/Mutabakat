using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using LiveCharts.WinForms;
namespace ETARaporlama.Forms
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection myconnet = new SqlConnection(System.IO.File.ReadAllText("Database.txt"));
        string[] city;
        string[] cityvalue;
        byte i = 0;
        bool control=false;
        void Listata(string gettext)
        {
            try
            {
                myconnet.Open();
                SqlCommand command = new SqlCommand(gettext, myconnet);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    city[i] = read[0].ToString();
                    cityvalue[i] = read[1].ToString();
                    i++;
                }
                myconnet.Close();
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI OKUMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void ListGet(string gettext)
        {
            try
            {
                myconnet.Open();
                SqlCommand command = new SqlCommand(gettext, myconnet);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    i++;
                }
                myconnet.Close();
                city = new string[i];
                cityvalue = new string[i];
                i = 0;
            }
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message, "HATALI OKUMA İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            control = false;
            for (int i = 0; i < city.Length; i++)
            {
                if (arg2.Name.ToUpper().ToString() == city[i].ToString())
                {
                    XtraMessageBox.Show(arg2.Name.ToUpper()+ " ŞEHİRİNE AİT (" +cityvalue[i].ToString() +") MÜŞTERİ BULUNMAKTADIR","ŞEHİRE AİT CARİ SAYISI", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    control = true;
                }
            }
            if (control == false)
            {
                XtraMessageBox.Show(arg2.Name.ToUpper() + " ŞEHİRİNE AİT (0) MÜŞTERİ BULUNMAKTADIR", "ŞEHİRE AİT CARİ SAYISI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void MapGet()
        {
            GeoMap geo = new GeoMap();
            geo.Source = $"{Application.StartupPath}\\CITY.xml";
            geo.Dock = DockStyle.Fill;
            this.Controls.Add(geo);
            geo.LandClick += GeoMap_LandClick;
            geo.Hoverable = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListGet("select ADRIL, count(ADRIL) from ADRESLER group by ADRIL having ADRIL <> '' or ADRIL <> null order by Count(ADRIL)");
            Listata("select ADRIL, count(ADRIL) from ADRESLER group by ADRIL having ADRIL <> '' or ADRIL <> null order by Count(ADRIL)");
            MapGet();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Forms.Form1 fr = new Form1();
                fr.Close();
            }
           
        }
    }
}
