using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace System
{
    public static class stringExtension
    {
        /// <summary>
        /// rsq = replace single quote
        /// Replace single quote to 2 single quote Same as .Replace("'","''"),
        ///
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>str.Replace("'","''")</returns>
        public static string rsq(this string str)
        {
            return str.Replace("'", "''");
        }

        /// <summary>
        /// String to int with Round (
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>int</returns>
        public static int toInt(this string str)
        {
            if ( str.IsNumeric())
            {
                decimal d = decimal.Parse(str);
                int i = Decimal.ToInt32(Math.Round(d));
                return i;
            }
            else
            {
                return -1;
            }
        }
         
   

        /// <summary>
        /// Convert to Bool
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>bool</returns>
        public static bool ToBoolean(this string str)
        {
            if (!IsNullOrEmpty(str))
            {
                return Convert.ToBoolean(str);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check object is "" or null
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>bool</returns>
        public static bool IsNullOrEmpty(this string str)
        {

            if (str != null && !str.Equals(DBNull.Value) && str != "" && str.Trim() != "")
            {

                return false;

            }
            return true;
        }
         
        /// <summary>
        /// Give a DateFormat to verify string is datetime or not
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>bool</returns>
        public static DateTime ToDateTime(this string str, string dateFormat)
        {
            return DateTime.ParseExact(str, dateFormat, System.Globalization.CultureInfo.InvariantCulture);
        }
         
        /// <summary>
        ///Convert to Datetime by provided format
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>DateTime</returns>
        public static bool IsDateTime(this string str,string dateFormat)
        { 
            DateTime output=DateTime.Now;

            return DateTime.TryParseExact(str, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out output);

        }

        /// <summary>
        /// verify string is datetime or not
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>bool</returns>
        public static bool IsDateTime(this string str)
        {
            DateTime output = DateTime.Now;

            return DateTime.TryParse(str, out output);

        }
    }
     
    public static class EnumExtension
    {
       /// <summary>
       /// Convert Enum to int
       /// </summary>
       /// <param name="str">Enum</param>
       /// <returns>int</returns>
        public static  int ToInt(this Enum str)
        {
            return Convert.ToInt32(str);
        }
    }

    public static class objectExtension
    {
        /// <summary>
        /// Convert object to int
        /// </summary>
        /// <param name="o">object</param>
        /// <returns>int</returns>
        public static int toInt(this object o)
        {

            if (o == null)
            {
                return -1;
            }


            if (o.GetType().BaseType.ToString() == "System.Enum")
            {
                return (int)o;
            }
            else if (  o is bool)
            {
                if (o.ToBoolean())
                {
                    return 1;
                }
                else
                    return 0; 
            }
            else
            {

                if (IsNumeric(o))
                {
                    decimal d = decimal.Parse(o.ToString());
                    int i = Decimal.ToInt32(Math.Round(d));
                    return i;
                }
                else
                {
                    return -1;
                }
            }
            //return -1; 
        }


        /// <summary>
        /// check object is IsNumeric or not
        /// </summary>
        /// <param name="o">object</param>
        /// <returns>bool</returns>
        public static bool IsNumeric(this object o)
        {
            
            float output;
            return float.TryParse(o.ToString(), out output);
        }

        /// <summary>
        /// Convert object to Decimal
        /// </summary>
        /// <param name="o">object</param>
        /// <returns>decimal</returns>
        public static decimal toDecimal(this object o)
        {
            if (IsNumeric(o))
            {
                decimal d = decimal.Parse(o.ToString());

                return d;
            }
            else
            {
                return -1;
            }
        }

        public static bool IsNullOrEmpty(this object o)
        {

            if (o != null && !o.Equals(DBNull.Value) && o.ToString() != "" && o.ToString().Trim() != "")
            {

                return false;

            }
            return true;
        }


        public static bool ToBoolean(this object o)
        {


            if (!IsNullOrEmpty(o))
            {
                return Convert.ToBoolean(o);
            }
            else
            {
                return false;
            }
        }

        public static DateTime? ToDateTime(this object o)
        {
            if (o.IsNullOrEmpty())
            {
                return null;
            }
            return Convert.ToDateTime(o.ToString());
        }


        public static DateTime? ToDateTime(this object o, string dateFormat)
        {
            if (o == null)
            {
                return null;
            }

            return DateTime.ParseExact(o.ToString(), dateFormat, System.Globalization.CultureInfo.InvariantCulture);
        }

        public static bool IsDateTime(this object o, string dateFormat)
        {
            DateTime output = DateTime.Now;

            return DateTime.TryParseExact(o.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out output);
        }

        public static bool IsDateTime(this object o)
        {
            if (o == null)
            {
                return false;
            }


            DateTime output = DateTime.Now;

            return DateTime.TryParse(o.ToString(), out output);

        }


    }
}