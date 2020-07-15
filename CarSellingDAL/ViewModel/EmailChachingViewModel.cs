using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.ViewModel
{
  public  class EmailChachingViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("kod")]
        public int? Kod { get; set; }

        [DisplayName("Vaxt")]
        public DateTime? KodGenerateDate { get; set; }
    }
}
