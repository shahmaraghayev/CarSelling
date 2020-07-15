using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.ViewModel
{
 public  class SearchViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Marka")]
        public int? BrandName { get; set; }

        [DisplayName("Model")]
        public int? ModelName { get; set; }

        [DisplayName("Mühərrikin həcmi")]
        public int? EngineCapaciyName { get; set; }

        [DisplayName("Yürüşü")]
        public int? Kilometerage  { get; set; }

        [DisplayName("Qiymeti")]
        public decimal Price { get; set; }

        [DisplayName("Istehsal tarixi")]
        public Boolean ManifactureYear { get; set; }

        [DisplayName("Şəhər")]
        public string AllCities { get; set; }
    }
}

