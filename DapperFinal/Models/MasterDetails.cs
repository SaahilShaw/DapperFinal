using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DapperFinal.Models.CustomerModel;

namespace DapperFinal.Models
{
    public class MasterDetails
    {
        public List<Customer> CustPersonal { get; set; }
        public List<Region> CustRegions { get; set; }
    }
}