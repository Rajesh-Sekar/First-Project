using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCSample.Controllers.User
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel model)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RajeshLocal"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
            }

                return View();
        }
    }
}