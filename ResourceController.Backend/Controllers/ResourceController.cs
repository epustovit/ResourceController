using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResourceController.Backend.Models;
using MySql.Data.MySqlClient;

namespace ResourceController.Backend.Controllers
{
    public class ResourceController : Controller
    {
        // GET: Resource
        public ActionResult MyResource()
        {
            return View();
        }

        public ActionResult InitialData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InitialData(ResourceCapacityModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    string connectionString = "server=localhost; port=81; database=ResourceController;uid=root";

            //    using (MySqlConnection connection = new MySqlConnection(connectionString))
            //    {
            //        using (Cash cash = new Cash(connection, false))
            //        {
            //            cash.Database.CreateIfNotExists();
            //        }

            //        connection.Open();

            //        MySqlTransaction transaction = connection.BeginTransaction();

            //        try
            //        {
            //            using (Cash context = new Cash(connection, false))
            //            {
            //                context.Database.UseTransaction(transaction);

            //                List<ResourceCash> rc = new List<ResourceCash>();

            //                rc.Add(new ResourceCash { Id = "aaa" , ElectricityCash = 0.1, GasCash = 0.1, TotalSum = 10, WaterCash = 0.1});

            //                context.Cashes.AddRange(rc);

            //                context.SaveChanges();
            //            }

            //            transaction.Commit();
            //        }
            //        catch
            //        {
            //            transaction.Rollback();
            //            throw;
            //        }
            //    }
            //}

            return View();
        }
    }
}