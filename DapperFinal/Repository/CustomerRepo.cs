using Dapper;
using DapperFinal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static DapperFinal.Models.CustomerModel;

namespace DapperFinal.Repository
{
    public class CustomerRepo
    {
        

       
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString);
        public IEnumerable<MasterDetails> GetMasterDetails()
        {


          
            var get = db.QueryMultiple( "GetMasterDetails", commandType: CommandType.StoredProcedure);
            
            MasterDetails obj = new MasterDetails();

            //Assigning each Multiple tables data to specific single model class  
            obj.CustPersonal = get.Read<Customer>().ToList();
            obj.CustRegions = get.Read<Region>().ToList();

            List<MasterDetails> masterdetails = new List<MasterDetails>();

            masterdetails.Add(obj);
           

            return masterdetails;

        }
    }
}
