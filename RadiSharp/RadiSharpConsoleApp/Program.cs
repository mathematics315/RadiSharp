using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using RadiSharp;
using RadiSharp.Models;
using static RadiSharp.Radiko;

namespace RadiSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Radiko radio = new Radiko("JP13");
            Task.Run(async () =>
            {
                List<ProgramInfo> programInfoList = await radio.GetProgramGuideAsync(GuideType.DateSpecification, DateTime.Now);
                foreach (var programInfo in programInfoList)
                {
                    Console.WriteLine($"{programInfo.OnAirDateTime.ToString("yyyy/MM/dd HH:mm:ss")}:[{programInfo.StationId}]{programInfo.StationName}:{programInfo.Title}:{programInfo.OnAirTime}:{programInfo.Url}");
                }
            });

            Console.ReadKey();
        }
    }
}
