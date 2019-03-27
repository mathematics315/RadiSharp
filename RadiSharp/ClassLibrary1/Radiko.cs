using RadiSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static RadiSharp.Models.ProgramGuide;

namespace RadiSharp
{
    public class Radiko
    {
        private static HttpClient Client { get; } = new HttpClient();
        public enum GuideType
        {
            Now,
            Today,
            DateSpecification
        }

        private string AreaCode { get; }

        public static string NOW_URL { get; } = @"http://radiko.jp/v3/program/now/{0}.xml";

        public static string TODAY_URL { get; } = @"http://radiko.jp/v3/program/today/{0}.xml";

        public static string DATE_URL { get; } = @"http://radiko.jp/v3/program/date/{0}/{1}.xml";

        public Radiko(string areaCode)
        {
            AreaCode = areaCode;
        }

        public async Task<List<ProgramInfo>> GetProgramGuideAsync(GuideType guideType, DateTime? dateTime = null)
        {

            List<ProgramInfo> programInfoList = new List<ProgramInfo>();
            try
            {
                Uri uri = null;
                switch (guideType)
                {
                    case GuideType.Now:
                        uri = new Uri(string.Format(NOW_URL, AreaCode));
                        break;
                    case GuideType.Today:
                        uri = new Uri(string.Format(TODAY_URL, AreaCode));
                        break;
                    case GuideType.DateSpecification:

                        if (!dateTime.HasValue) throw new ArgumentNullException();

                        uri = new Uri(string.Format(DATE_URL, dateTime?.ToString("yyyyMMdd"), AreaCode));
                        break;
                }

                var responce = await Client.GetStringAsync(uri);
                var xmlSerializer = new XmlSerializer(typeof(radiko));
                radiko result = null;
                using (StringReader stringReader = new StringReader(responce))
                using (var xmlReader = System.Xml.XmlReader.Create(stringReader))
                {
                    result = (radiko)xmlSerializer.Deserialize(xmlReader);
                }

                if (result == null) return programInfoList;

                foreach (var item in result.stations)
                {
                    foreach (var item2 in item.progs.prog)
                    {
                        try
                        {
                            string dateText = $"{item.progs.date}{item2.ftl.ToString().PadLeft(4, '0')}";
                            int year = Convert.ToInt32(new string(item.progs.date.ToString().Take(4).ToArray()));
                            int month = Convert.ToInt32(new string(item.progs.date.ToString().Skip(4).Take(2).ToArray()));
                            int day = Convert.ToInt32(new string(item.progs.date.ToString().Skip(6).Take(2).ToArray()));
                            var hour = Convert.ToInt32(new string(item2.ftl.ToString().PadLeft(4, '0').Take(2).ToArray()));
                            var minute = Convert.ToInt32(new string(item2.ftl.ToString().PadLeft(4, '0').Skip(2).Take(2).ToArray()));

                            ProgramInfo programInfo = new ProgramInfo
                            {
                                Title = item2.title,
                                StationName = item.name,
                                StationId = item.id,
                                OnAirDateTime = new DateTime(year, month, day).Add(new TimeSpan(hour, minute, 00)),
                                OnAirTime = new TimeSpan(0, 0, item2.dur),
                                InfomationHTML = item2.info
                            };

                            if (!string.IsNullOrWhiteSpace(item2.url))
                            {
                                programInfo.Url = new Uri(item2.url);
                            }

                            programInfoList.Add(programInfo);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return programInfoList;
        }
    }
}
