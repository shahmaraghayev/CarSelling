﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.Domain
{
    public class Models
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? BrandId { get; set; }
    }
}
