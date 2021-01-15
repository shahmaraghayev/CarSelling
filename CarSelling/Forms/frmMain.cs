using CarSelling.Controls;
using CarSelling.Sessions;
using CarSellingDAL.DAL;
using CarSellingDAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelling
{
    public partial class frmMain : Form
    {
        PosAdDal posAdDdal;
        public frmMain()
        {
            InitializeComponent();
            posAdDdal = new PosAdDal();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            var frm = new frmLogin();
            frm.ShowDialog();
            btnUser.Text = LoginSession.LoginUser.Email;

          //  throw new Exception("xetaaaaaaaaaa");
        }
        private void DisposeControlsOnPanel()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Dispose();//dagitmar
            }
        }

        private void btnPostAd_Click(object sender, EventArgs e)
        {
            frmPosAd m = new frmPosAd();
            m.Show();
         
            if (LoginSession.LoginUser != null)
            {
               
            }
            else
            {

            }
             
        }

        private void ucSearch1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucSearch uSearch = new ucSearch();
            this.panelMain.Controls.Add(uSearch);
            uSearch.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
