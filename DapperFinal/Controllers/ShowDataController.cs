using Dapper;
using DapperFinal.Models;
using DapperFinal.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperFinal.Controllers
{
    public class ShowDataController : Controller
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString);
       
       

       
        // GET: Customer
        public ActionResult MasterDetail()   //Action for  two tables in one view
        {
            CustomerRepo cr = new CustomerRepo();
            MasterDetails MultiTable = new MasterDetails();

            List<MasterDetails> MasterData = cr.GetMasterDetails().ToList();

            MultiTable.CustPersonal = MasterData[0].CustPersonal;
            MultiTable.CustRegions = MasterData[0].CustRegions;


            return View(MultiTable);
        }
    }
}