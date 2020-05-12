using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.Domain
{
    public class CarImages
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public int? CarId { get; set; }

    }
}
