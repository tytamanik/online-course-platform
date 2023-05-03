using PE.BusinessLogic.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using PE.web.Models;

namespace PE.web.Controllers
{
    public class ULoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: 
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source=WIN-QJ63609DU36; database=PlatEd; integrated security = SSPI "
        }

        public ActionResult Verify(UserLogin log)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                return View();
            }
            else 
            {
                return View();
            }
            con.Close();    
            return View();
        }
    }
}