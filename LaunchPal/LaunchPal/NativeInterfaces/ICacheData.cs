using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.Interfaces;

namespace LaunchPal.NativeInterfaces
{
    interface ICacheData
    {
        void StoreDataInCache<T>(List<ICachable<T>> data) where T : class;
    }
}
