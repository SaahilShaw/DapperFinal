using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using DapperFinal.Models;

namespace DapperFinal.Controllers
{
    public class MenuController : Controller
    {
        private IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString);
        // GET: Menu
      
        public ActionResult MenuView()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult SearchResult(int id)
        {
            Student student = db.QueryFirstOrDefault<Student>("EmployeeGet ", new { Id = id }, commandType: CommandType.StoredProcedure);
            if (student != null)
            {
                return View(student);
            }
            else
            {
                student = new Student();
                student.Id = -1;
                return View(student);
            }

        }
        public ActionResult SingleRecordView()
        {
            return View();
        }
        public ActionResult SingleRecordForName(int id,Student stud)
        {
           
            

            try
            {
                stud = db.QueryFirstOrDefault<Student>("SingleValueStudent ", new { id = id }, commandType: CommandType.StoredProcedure);
            }
            catch (Exception e)
            {

            }
            if (stud != null)
            {
                return View(stud);
            }
            else
            {
                stud = new Student();
                stud.Id = -1;
                return View(stud);
            }

            //return View(stud);

        }

        public ActionResult StudTable()
        {

            List<Student> students = new List<Student>();
           // students = null;
            try
            {
                students = db.Query<Student>("StudentList", commandType: CommandType.StoredProcedure).ToList();
            }
            catch(Exception e)
            {
                
            }
            return View(students);
        }
        //public ActionResult SearchForReturn()
        //{
        //    return View();
        //}
        //public ActionResult OutputReturn(int id)
        //{
        //    //int id = 2;
        //    try
        //    {
        //        ViewBag.find = db.QueryFirstOrDefault<int>("CheckEmployeeId ", new { Id = id }, commandType: CommandType.StoredProcedure);
        //    }
        //    catch(Exception e)
        //    {

        //    }
        //    return View();
        //}
        public ActionResult MultiList()
        {
            List<StudentSub> students = new List<StudentSub>();
            try
            {
                students = db.Query<StudentSub>("JoinStudent", commandType: CommandType.StoredProcedure).ToList();
            }
            catch(Exception e)
            {

            }
     
            return View(students);

        }

       public ActionResult Union()
        {
            List<Student> students = new List<Student>();
            try
            {
                students = db.Query<Student>("UnionList", commandType: CommandType.StoredProcedure).ToList();
            }
            catch (Exception e)
            {

            }
            return View(students);
        }


    }
}