using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSellingDAL.ViewModel;
using CarSellingDAL.DAL;

namespace CarSelling
{
    public partial class ucSearch : UserControl
    {
        List<SearchViewModel> qlobal;
        SearchDal searchCrud;
        public ucSearch()
        {
            InitializeComponent();
            searchCrud = new SearchDal();
            qlobal = new List<SearchViewModel>();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //ucSearch = searchCrud.GetAllByCarName(txtMaksPrice.Text,txtMinPrice.Text,cbAllBrands,cbAllCities,cbAllModels,cbManufactureYear,cbPrice,ckbBarter.ToString(),ckbKredit.ToString());

        }
    }
    
}

