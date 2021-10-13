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
using ETARaporlama.Forms;
namespace ETARaporlama.Forms
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }
        Forms.Form1 mp = null;
        Forms.Statistics st = null;
        Forms.SalesStatistic sls = null;
        Forms.Mutabakat mtk = null;
        Forms.Settings stk = null;
        Forms.MapCustomer mpc = null;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mp==null ||mp.IsDisposed==true)
            {
                mp = new Form1();
                mp.MdiParent = this;
                mp.Show();
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (st == null || st.IsDisposed == true)
            {
                st = new Statistics();
                st.MdiParent = this;
                st.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sls == null || sls.IsDisposed == true)
            {
                sls = new SalesStatistic();
                sls.MdiParent = this;
                sls.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mtk == null || mtk.IsDisposed == true)
            {
                mtk = new Mutabakat();
                mtk.MdiParent = this;
                mtk.Show();
            }
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stk == null || stk.IsDisposed == true)
            {
                stk = new Settings();
                stk.MdiParent = this;
                stk.Show();
            }
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mpc == null || mpc.IsDisposed == true)
            {
                mpc = new MapCustomer();
                mpc.MdiParent = this;
                mpc.Show();
            }
        }
    }
}