using RealTime_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTime_Server.Data
{
    public static class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            return new List<ChartModel>
            {
                new ChartModel { Data = new List<int> { r.Next(1,40) }, Label = "Data1" },
                new ChartModel { Data = new List<int> { r.Next(1,40) }, Label = "Data1" },
                new ChartModel { Data = new List<int> { r.Next(1,40) }, Label = "Data1" },
                new ChartModel { Data = new List<int> { r.Next(1,40) }, Label = "Data1" }
            };
        }
    }
}
