using System;
using System.Collections.Generic;

public static class Extensions
    {
        public static int FindIndex<T>(this IList<T> source, Predicate<T> match)
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (match(source[i]) == true)
                {
                    return i;
                }
            }
            return -1;
        }
        
        public static int? ToIntNullable(this string s)
        {
            int i = 0;
            int.TryParse(s, out i);
            return (i == 0) ? (int?)null : i;
        }

        public static int? NullifyZero(this int? i)
        {
            if (i != null && i == 0)
                return null;
            else
                return i;
        }
        
       public static int? NullifyZero(this int i)
        {
            if (i == 0)
                return null;
            else if (i == -1)
                return null;
            else
                return i;
        }

        public static string NullifyBlank(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            else
                return s;
        }
        
        public static bool ToBoolean(this string s)
        {
            if (!String.IsNullOrEmpty(s) && s.ToLower() == Boolean.TrueString.ToLower())
                return true;
            else
                return false;
        }

        public static decimal ToDecimal(this string s)
        {
            decimal d = 0;
            decimal.TryParse(s.Replace("$", string.Empty).Replace(",", string.Empty), out d);
            return d;
        }
        
        public static int ToInt(this string s)
        {
            int i = 0;
            int.TryParse(s.Replace("$", string.Empty).Replace(",", string.Empty), out i);
            return i;
        }

        public static bool FalsifyNull(this Boolean? b)
        {
            if (b == null)
                return false;
            else
                return (bool)b;
        }

    }