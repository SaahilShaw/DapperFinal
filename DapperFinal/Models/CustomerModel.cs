using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperFinal.Models
{
    public class CustomerModel
    {
        public class Customer
        {
            public string Name { get; set; }
            public string CustomerType { get; set; }
            public string Gender { get; set; }

        }
        public class Region
        {
            public string Country { get; set; }
            public string State { get; set; }
            public string City { get; set; }
        }
    }
}