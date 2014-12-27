using System;
using System.Globalization;
using Walterlv.Data.Sheeting;

namespace Walterlv.Demo
{
    [SheetHeaders("StartTime", "EndTime", "Content")]
    public class WorkItem
    {
        [SheetHeader(typeof(DateTimeConverter))]
        public DateTime StartTime { get; set; }

        [SheetHeader(typeof(DateTimeConverter))]
        public DateTime EndTime { get; set;  }

        public string Content { get; set; }
    }

    internal class DateTimeConverter : ITypeConverter<DateTime>
    {
        public string ConvertFrom(DateTime value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public DateTime ConvertTo(string value)
        {
            return DateTime.Parse(value);
        }
    }
}
