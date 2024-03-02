using System.ComponentModel.DataAnnotations;

namespace STARAS.BusinessLayer.Utilities.TimeUtils
{
    // Validate Date of Birth 
    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;

        public MinAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                if (dateOfBirth.AddYears(_minAge) > DateTime.Today)
                {
                    return new ValidationResult(ErrorMessage);
                }
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid date format.");
        }
    }

    // Validate Date of Future
    public class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)// Return a boolean value: true == IsValid, false != IsValid
        {
            DateTime d = Convert.ToDateTime(value);
            return d <= DateTime.Now; //Dates Smaller than or equal to today are valid (true)

        }
    }

    public static class TimeUtils
    {
        public static DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();

            return dateTimeInterval;
        }
        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public static string GetHoursTime(DateTime value)
        {
            return value.ToString("H:mm");
        }

        public static DateTime GetCurrentSEATime()
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime localTime = DateTime.Now;
            DateTime utcTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, tz);
            return utcTime;
        }

        public static DateTime ConvertToSEATime(DateTime value)
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime convertedTime = TimeZoneInfo.ConvertTime(value, tz);
            return convertedTime;
        }

        public static DateTime GetCurrentDate()
        {
            return DateTime.UtcNow.AddHours(7);
        }

        public static DateTime GetStartOfDate(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
        }

        public static DateTime GetEndOfDate(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
        }

        public static (DateTime, DateTime) GetLastAndFirstDateInCurrentMonth()
        {
            var now = GetCurrentSEATime();
            var first = new DateTime(now.Year, now.Month, 1);
            var last = first.AddMonths(1).AddDays(-1);
            return (first, last);
        }

        public static string ToCronExpression(DateTime dateTime)
        {
            // Extract the individual components from the DateTime object
            int minute = dateTime.Minute;
            int hour = dateTime.Hour;
            int dayOfMonth = dateTime.Day;
            int month = dateTime.Month;
            int dayOfWeek = (int)dateTime.DayOfWeek;

            // Adjust dayOfWeek to match the cron format (Sunday starts at 0)
            if (dayOfWeek == 0)
                dayOfWeek = 7;

            // Build the cron expression string
            string cronExpression = $"{minute} {hour} {dayOfMonth} {month} {dayOfWeek}";

            return cronExpression;
        }

        public static long GetTimeStamp(DateTime date)
        {
            return (long)(date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
        }

        public static long GetTimeStamp()
        {
            return GetTimeStamp(DateTime.Now);
        }

        public static DateTime ConvertDateTimeToVietNamTimeZone()
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime localTime = DateTime.Now;
            DateTime utcTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, tz);
            return utcTime;
        }
    }
}
