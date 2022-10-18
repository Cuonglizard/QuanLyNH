using System;

namespace QuanLy
{
    public class Utility
    {
        public static int ReadInt()
        {
            int value;

            while (true)
            {
            try
            {
                {
                    value=int.Parse(Console.ReadLine());
                    return value;
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Nhap Lai !!");
            }    
            }
        }
        // convert string to date
        public static DateTime ConvertStringToDateTime(string DatetimeStr)
        {
            DateTime myDate= DateTime.ParseExact(DatetimeStr, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            return myDate;
        }

        public static string  ConvertDateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}