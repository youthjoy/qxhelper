using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public class ChartConfig
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string Module { get; set; }
        /// <summary>
        /// 图表类型
        /// </summary>
        public string ChartType { get; set; }
        /// <summary>
        /// 存储过程参数
        /// </summary>
        public Dictionary<string, string> ProcParameters { get; set; }
        /// <summary>
        /// X轴 日期刻度动态改变
        /// </summary>
        public string DateTime_XIntervalType { get; set; }
        /// <summary>
        /// Y轴 日期刻度动态改变
        /// </summary>
        public string DateTime_YIntervalType { get; set; }
        /// <summary>
        /// 动态改变Legend文本
        /// </summary>
        public string LegendText { get; set; }
        /// <summary>
        /// 图表标题动态改变
        /// </summary>
        public string Title { get; set; }
    }
}
