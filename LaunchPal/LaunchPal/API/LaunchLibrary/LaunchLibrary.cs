using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPal.API.LaunchLibrary.Models;
using LaunchPal.Models;

namespace LaunchPal.API.LaunchLibrary
{
    internal static class LaunchLibrary
    {
        private static string BaseUrl => "https://launchlibrary.net/1.2/";
        private static string Mode => "&mode=verbose";

        internal static async Task<LaunchData> GetNextLaunch()
        {
            var target = "launch?next=1";
            var result = new LaunchData();

            result.LaunchInfo = await HttpCaller.FetchData<Launch>(BaseUrl + target + Mode);
            result.MissionInfo = GetMissionData(result.LaunchInfo.)
        }

        internal static Task<LaunchData> GetLaunchById(int id)
        {
            throw new NotImplementedException();
        }

        internal static Task<List<LaunchData>> GetLaunchesBySearchString(string searchString)
        {
            throw new NotImplementedException();
        }

        internal static Task<List<LaunchData>> GetLaunchesThisWeek()
        {
            throw new NotImplementedException();
        }

        internal static Task<List<LaunchData>> GetLaunchesThisMonth()
        {
            throw new NotImplementedException();
        }

        private static async Task<Mission> GetMissionData(int launchId)
        {
            var target = "mission?launchid=" + launchId;

            var result = await HttpCaller.FetchData<Mission>(BaseUrl + target + Mode);

            return result;
        }
    }
}
