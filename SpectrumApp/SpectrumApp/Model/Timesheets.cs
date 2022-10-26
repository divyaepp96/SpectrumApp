using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SpectrumApp.Model
{
    public class Sheet
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public DateTime JobStartTime { get; set; }
        public DateTime JobEndTime { get; set; }
        public DateTime BreakStartTime { get; set; }
        public DateTime BreakEndTime { get; set; }
        public DateTime JobDate { get; set; } = DateTime.Now;

        public string displayAddress
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Address))
                {
                    return Address.ToString();
                }
                return string.Empty; ;
            }
        }

        public string displayJobDate
        {
            get
            {
                if (JobDate != null)
                {
                    return JobDate.ToString(GetCurrentCulture().LongDatePattern);
                }
                return null;
            }
        }

        public string displayJobStart
        {
            get
            {
                if (JobStartTime != null)
                {
                    return JobStartTime.ToString(GetCurrentCulture().ShortTimePattern);
                }
                return "0:00";
            }
        }

        public string displayBreakStart
        {
            get
            {
                if (BreakStartTime != null)
                {
                    return BreakStartTime.ToString(GetCurrentCulture().ShortTimePattern);
                }
                return "0:00";
            }
        }

        public string displayBreakEnd
        {
            get
            {
                if (BreakEndTime != null)
                {
                    return BreakEndTime.ToString(GetCurrentCulture().ShortTimePattern);
                }
                return "0:00";
            }
        }

        public string displayJobEnd
        {
            get
            {
                if (JobEndTime != null)
                {
                    return JobEndTime.ToString(GetCurrentCulture().ShortTimePattern);
                }
                return "0:00";
            }
        }

        public static DateTimeFormatInfo GetCurrentCulture()
        {
            try
            {
                CultureInfo culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
                return culture.DateTimeFormat;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
    }
}
