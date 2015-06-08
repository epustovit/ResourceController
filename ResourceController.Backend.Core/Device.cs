using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceController.Backend.Core
{
    [Serializable]
    public abstract class DeviceBase : IDevice
    {
        protected DeviceBase()
        {
        }

        public int GetDataFromCounter()
        {
            return 11000;
        }

        public int CurrentMeasurement
        {
            get;

            protected set;
        }

        public string DeviceCode
        {
            get;

            protected set;
        }

        public string DeviceName
        {
            get;

            protected set;
        }

        //public void RefreshMeasurement()
        //{
        //    CurrentMeasurement = this.GetDataFromCounter();
        //}

        protected abstract void RefreshMeasurement();

        protected abstract void CalculateOutlay();

    }
}
