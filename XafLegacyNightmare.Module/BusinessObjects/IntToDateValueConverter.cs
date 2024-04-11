using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafLegacyNightmare.Module.BusinessObjects
{
    public class IntToDateValueConverter : ValueConverter
    {
        /// <summary>
        /// Converts an integer in yyyymmdd format to a DateTime object.
        /// </summary>
        /// <param name="dateInt">The date as an integer in yyyymmdd format.</param>
        /// <returns>A DateTime object representing the date, or null if the input is not a valid date.</returns>
        public static DateTime? ConvertIntToDate(int dateInt)
        {
            try
            {
                string dateString = dateInt.ToString();

                // Ensure the string is exactly 8 characters long, which represents yyyymmdd
                if (dateString.Length != 8)
                {
                    throw new ArgumentException("The integer must be in yyyymmdd format.");
                }

                DateTime date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
                return date;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        /// <summary>
        /// Converts a DateTime object to an integer in yyyyMMdd format.
        /// </summary>
        /// <param name="date">The DateTime to be converted.</param>
        /// <returns>An integer representing the formatted date.</returns>
        public static int ConvertDateToInt(DateTime date)
        {
            string dateString = date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            return int.Parse(dateString);
        }
        public override object ConvertFromStorageType(object value)
        {
            return ConvertIntToDate((int)value);
        }
        public override object ConvertToStorageType(object value)
        {
            return ConvertDateToInt((DateTime)value);
        }
        public override System.Type StorageType
        {
            get { return typeof(int); }
        }
    }
}
