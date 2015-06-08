using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceController.Backend.Core
{
    [Serializable]
    class WaterDevice : DeviceBase
    {
        public WaterDevice(string code)
        {
            this.DeviceName = "Water";

            this.DeviceCode = code;
        }

        protected override void CalculateOutlay()
        {
        }

        protected override void RefreshMeasurement()
        {
            int previous = this.CurrentMeasurement;

            this.CurrentMeasurement = this.GetDataFromCounter();


        }
    }
}
