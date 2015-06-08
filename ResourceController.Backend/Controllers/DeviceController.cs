using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Timers;
using ResourceController.Backend.Core;
using ResourceController.Backend.Models;
//using AspNet.Identity.MySQL;

namespace ResourceController.Backend.Controllers
{
    public class DeviceController : Controller
    {
        // GET: Device
        public string Index()
        {
            return "Hello";
        }

        public ActionResult NewDevice()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewDevice(DeviceViewModel model)
        {
            if (ModelState.IsValid)
            {
                //DeviceStore deviceStore = new DeviceStore()

                //UserStore<IdentityUser> userStore = new UserStore<IdentityUser>(new MySQLDatabase("DefaultConnection"));
                
                //Device device = new Device();

                //device.Name = model.Name;

                //device.SerialNumber = model.SerialNumber;

                //device.UserId = userTable.GetUserId("user2@user.com"); userStore.u

                //device.DeviceId = "2";

                //deviceTable.Insert(device);
            }

            return View();
        }

        public string FindAllDevices()
        {
            //var provider = new ConnectionDeviceProvider();

            string jsonString = string.Empty;

            List<DeviceBase> devices = ConnectionDeviceProvider.FindDevices();

            foreach (var device in devices)
            {
                jsonString += JsonHelper.JsonSerializer<DeviceBase>(device);

                jsonString += Environment.NewLine;
            }

            return jsonString;
        }

        [HttpPost]
        public void ConnectToDevice(string id)
        {


            return;
        }
    }
}