using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourceController.Backend.Models
{
    public class ResourceCapacityModel
    {
        public ResourceCapacityModel()
        {

        }

        public string TotalSum
        {
            get;

            set;
        }

        public string WaterCapacity
        {
            get;

            set;
        }

        public string GasCapacity
        {
            get;

            set;
        }

        public string ElectricityCapacity
        {
            get;

            set;
        }
    }
}