﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecom_Project.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
namespace Ecom_Project.Controllers;

public class HomeController : Controller
{
    private string constr = "server=localhost;port=3306;uid=root;pwd=Lambo@786;database=furndb;charset=utf8;sslmode=none;AllowPublicKeyRetrieval=True";
    //private string mail;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        if (GlobalModel.first_name != null)
       {

            ViewBag.Name = GlobalModel.first_name;
           
       }
        _logger = logger;
    }

    public IActionResult Index()
    {
       if (GlobalModel.first_name != null)
       {

            ViewBag.Name = GlobalModel.first_name;
       }
        return View();
    }

    public IActionResult privacy()

    {
        return View();
    
    }
    public IActionResult register()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
[HttpPost]
        public ActionResult Register(UserModel obj)
        {
            ViewBag.first_name = obj.first_name;
            ViewBag.last_name = obj.last_name;
            ViewBag.email_id = obj.email_id;
            ViewBag.password = obj.password;

           // mail=obj.email_id;
            //string enPassword = obj.EncodePasswordToBase64(obj.Password);
            //string dePassword = obj.DecodeFrom64(enPassword);
            //ViewBag.enPassword = enPassword;
            //ViewBag.dePassword = dePassword;
            MySqlConnection conn = new MySqlConnection(constr);
            using (conn)
            {
                try
                {
                    List <UserModel> user = new List<UserModel>();
                    conn.Open();
                    MySqlCommand command =  conn.CreateCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    string? fname = obj.first_name;
                    string? lname = obj.last_name;
                    string? email = obj.email_id;
                    string? pword = obj.password;
                   // reader.Close();
                   Console.WriteLine("fname: " + fname);
                    command.CommandText=$"Insert into customer(first_name, last_name, email_id, password) values('{fname}','{lname}','{email}','{pword}');";
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    conn.Close();
                    System.Console.WriteLine("Connection is : " + conn.State.ToString() + Environment.NewLine);
                    // return StatusCode(200);
                }catch(MySql.Data.MySqlClient.MySqlException ex){
                    System.Console.WriteLine("Error: " + ex.Message.ToString());
                    conn.Close();
                    System.Console.WriteLine("Connection is : " + conn.State.ToString() + Environment.NewLine);
                    return StatusCode(500);
                }finally {
                    //System.Console.WriteLine("Press any key to Exit...");
                    //
                    //Console.ReadKey();
                }
            // if (chkAddon != null)
            //     ViewBag.Addon = "Selected";
            // else
            //     ViewBag.Addon = "Not Selected";
            return View(obj);
            // return View("Login", obj);
            }
           
        }
        
     


        // public IActionResult login()
        // {
        //     List <UserModel> user = new List<UserModel>();
        // // ViewBag.first_name = obj.first_name;
        // // ViewBag.last_name = obj.last_name;
        // //ViewBag.email_id = obj.email_id;
        // //ViewBag.password = obj.password;
        // //string enPassword = obj.EncodePasswordToBase64(obj.Password);
        //  //string dePassword = obj.DecodeFrom64(enPassword);
        //  //ViewBag.enPassword = enPassword;
        //  //ViewBag.dePassword = dePassword;
        //     MySqlConnection conn = new MySqlConnection(constr);
        //     using (conn)
        
        //         {
                    
        //             string query=$"select * from customer where email_id='$email_id' and  password='$password'  ";
                  
        //             if (query is not null  )
        //             {
                    
        //             System.Console.WriteLine("Successfully logged in!");
        //             System.Console.WriteLine("Connection is : " + conn.State.ToString() + Environment.NewLine);
        //             }
                    
        //             {
        //             System.Console.WriteLine( "Email or Password is incorrect!");
        //             System.Console.WriteLine("Connection is : " + conn.State.ToString() + Environment.NewLine);
        //             // return View(Index());
        //             }
        //             using (MySqlCommand cmd = new MySqlCommand(query))
        //             {
        //                 cmd.Connection = conn;
        //                 conn.Open();
        //                 // using  (MySqlDataReader sdr = cmd.ExecuteReader())
                        
        //                 // {
        //                 // while (sdr.Read())
        //                 // {
        //                 //     user.Add(new UserModel
        //                 //     {
        //                 //      //first_name=string.Format("{0:S}", sdr["first_name"]),
        //                 //      //last_name=string.Format("{0:S}", sdr["last_name"]),
        //                 //      email_id=string.Format("{0:S}", sdr["email_id"]),
        //                 //      password=string.Format("{0:S}", sdr["password"]),
        //                 //     });
        //                 // } 
                       
        //                 // }
        //                 conn.Close();
        //             }

        //         }

        //         return View(user);
        // }
                            
      public IActionResult about()
        {
            return View();
        }                       
        public IActionResult contact()
        {
            return View();
        }                       
        public IActionResult terms()
        {
            return View();
        }    
        public IActionResult faq()
        {
            return View();
        }  
          public IActionResult product()
        {
            return View();
        }     
         public IActionResult cart()
        {
            return View();
        }   
        public IActionResult beds()
        {
            return View();
        }   
         public IActionResult homeoffice()
        {
            return View();
        }   

        public IActionResult dining()
        {
            return View();
        }   
         public IActionResult recliners()
        {
            return View();
        }   
        public IActionResult checkout()
        {
            return View();
        }   

         public IActionResult order()
        {
            return View();
        }   
        public IActionResult view()
        {
            return View();
        }   

         public IActionResult help()
        {
            return View();
        }   
        
         public IActionResult service()
        {
            return View();
        }  
        public IActionResult shop()
        {
            return View();
        }  
          
           public IActionResult payment()
        {
            return View();
        }  
        public IActionResult money()
        {
            return View();
        }  
        public IActionResult returns()
        {
            return View();
        }  
        public IActionResult shipping()
        {
            return View();
        }  

        public IActionResult wish()
        {
            return View();
        }  

        public IActionResult track()
        {
            return View();
        }   

        // public IActionResult login1()
        // {
        //     return View();
        // }                     
                                                                                  
   [HttpPost]
    public IActionResult login(loginModel obj)
   {
        MySqlConnection conn = new MySqlConnection(constr);
        using (conn)
        {
             var uname = obj.email_id;
             var pword = obj.password;
            string query = $"SELECT first_name, email_id, password FROM customer where email_id = '{uname}' and password ='{pword}';";
    
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = conn;
                conn.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        // obj.password = string.Format("{0:S}", sdr["password"]);
                        GlobalModel.first_name = string.Format("{0:S}", sdr["first_name"]);
                        
                        Console.WriteLine("Global name is");
                        Console.WriteLine(GlobalModel.first_name);
                        if (string.Compare(obj.password,string.Format("{0:S}", sdr["password"]),false)==0)
                            return RedirectToAction("Index");
                        else
                            return View("privacy");                        
                    }
                }
                conn.Close();
            }
        }        
        return View(obj);
    }

  
  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}