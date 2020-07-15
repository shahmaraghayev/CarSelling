using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.Domain
{
    public class EmailChecking
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public int? Kod { get; set; }

        public DateTime? KodGenerateDate { get; set; }

    }
}
