using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_60
{
    public static class StringExtensions
    {
        //public static int Shift
        //{
        //    get { return str.Split; }

        //}
        public static int Shift(this string str)
        {
            int Shift = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
            return Shift;
        }
    }
}
