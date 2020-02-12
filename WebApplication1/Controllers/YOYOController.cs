using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MvcMovie.Controllers
{
    public class YOYOController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        
        public ActionResult Index()
        {
            List<lotteryUser> users = new List<lotteryUser>();
            string Mysql = ConfigurationManager.ConnectionStrings["MySql"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(Mysql))
            {
                string query = "SELECT userID, username, password FROM user";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            users.Add(new lotteryUser
                            {
                                ID = System.Convert.ToInt32(sdr["userID"]),
                                username = sdr["username"].ToString(),
                                password = sdr["password"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
        return View(users);
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}