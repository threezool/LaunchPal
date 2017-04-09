using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPal.NativeInterfaces
{
    interface IHandlePurchases
    {
        bool PurchasePlus();

        bool HasPurchasedPlus();
    }
}
