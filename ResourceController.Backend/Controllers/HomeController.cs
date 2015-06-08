using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResourceController.Backend.Core;
using ResourceController.Backend.Models;

namespace ResourceController.Backend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Initial()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //List<DeviceBase> devices = ConnectionDeviceProvider.FindDevices();

            List<DeviceViewModel> devices = new List<DeviceViewModel>();

            foreach (var device in ConnectionDeviceProvider.FindDevices())
            {
                DeviceViewModel deviceModel = new DeviceViewModel();

                deviceModel.Name = device.DeviceName;

                deviceModel.SerialNumber = device.DeviceCode;

                devices.Add(deviceModel);
            }

            return View(devices);
        }

        public ActionResult CurrentResources()
        {
            return View();
        }
    }
}