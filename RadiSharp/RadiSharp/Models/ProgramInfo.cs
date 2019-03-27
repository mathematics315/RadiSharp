using System;
using System.Collections.Generic;
using System.Text;

namespace RadiSharp.Models
{
    /// <summary>
    /// 番組情報
    /// </summary>
    public class ProgramInfo
    {
        /// <summary>
        /// 番組タイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 放送局ID
        /// </summary>
        public string StationId { get; set; }
        /// <summary>
        /// 放送局名
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 放送日時
        /// </summary>
        public DateTime OnAirDateTime { get; set; }
        /// <summary>
        /// 放送時間
        /// </summary>
        public TimeSpan OnAirTime { get; set; }
        /// <summary>
        /// 番組URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// 番組内容(HTML形式)
        /// </summary>
        public string InfomationHTML { get; set; }
    }


}
