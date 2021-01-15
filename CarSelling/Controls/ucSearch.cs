using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSellingDAL.DAL;

namespace CarSelling.Controls
{
    public partial class ucSearch : UserControl
    {
        CommonDal common;

        public ucSearch()
        {
            InitializeComponent();
           
        }


        private void ucSearch_Load(object sender, EventArgs e)
        {
            common = new CommonDal();
            cbMarka.DataSource = common.GetBrandsByIdName();
            cbMarka.SelectedIndex = -1;
            cbModel.DataSource = common.GetModelsByIdName();
            cbModel.SelectedIndex = -1;
            cmbCity.DataSource = common.GetCityByIdName();
            cmbCity.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
