using System;
using System.Collections.Generic;
using LaunchPal.Models;

namespace LaunchPal.Managers
{
    class CacheManager
    {
        private LaunchData NextLaunch { get; set; }
        private List<LaunchData> LaunchDatas { get; set; }

        internal bool TryGetNextLaunch(out LaunchData data)
        {
            if (NextLaunch.ExpireDate < DateTime.Now)
            {
                data = NextLaunch;
                return true;
            }

            data = new LaunchData();
            return false;
        }
    }
}
