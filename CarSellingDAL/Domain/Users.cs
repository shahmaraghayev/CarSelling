using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.Domain
{
    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? Code { get; set; }

        public DateTime CreateDate { get; set; }

        public string Salt { get; set; }

    }
}
