using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceController.Backend.Core
{
    public class ConnectionDeviceProvider
    {
        public ConnectionDeviceProvider()
        {

        }

        public static List<DeviceBase> FindDevices()
        {
            List<DeviceBase> devices = new List<DeviceBase>();

            devices.Add(new WaterDevice("1KxE"));

            devices.Add(new WaterDevice("FA5k2"));

            return devices;
        }
    }
}
