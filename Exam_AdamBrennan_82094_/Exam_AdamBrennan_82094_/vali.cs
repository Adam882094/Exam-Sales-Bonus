using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_AdamBrennan_82094_
{
    public static class vali
    {
        public static string totalHourscheck(string val)
        {
            if (val == "")
            {
                return 0.ToString();
            }
            else
            {
                double check = double.Parse(val);
                if (check >= 0 && check <= 160) // sees if number is negative
                {
                    return 1.ToString(); // returns 1 if true
                }
                else
                {
                    return 0.ToString(); // returns 0 if false
                }
            }
        }
        public static string neg(string val)
        {
            if (val == "")
            {
                return 1.ToString(); // returns 1 if true
            }
            double check = double.Parse(val);
            if (check < 0) // sees if number is negative
            {
                return 1.ToString(); // returns 1 if true
            }
            else
            {
                return 0.ToString(); // returns 0 if false
            }
        }
        public static string name(string val)
        {
            if (val == "") // sees if number is negative
            {
                return 1.ToString(); // returns 1 if true
            }
            else
            {
                return 0.ToString(); // returns 0 if false
            }
        }
        public static string user(string val)
        {
            if (val == "") // sees if number is negative
            {
                return 1.ToString(); // returns 1 if true
            }
            else
            {
                return 0.ToString(); // returns 0 if false
            }
        }
    }
}
