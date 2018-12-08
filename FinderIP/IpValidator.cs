using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIp
{

    class IpValidator
    {
        static char[] numbers1 = new char[] { '1', '2' };
        static char[] numbers2 = new char[] { '0', '1', '2', '3', '4', '5' };
        static char[] numbers3 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public string GetValidation(char[] mas)
        {
            if (numbers1.Contains(mas[0]) && numbers2.Contains(mas[1]) && numbers3.Contains(mas[2]) &&
                numbers1.Contains(mas[4]) && numbers2.Contains(mas[5]) && numbers3.Contains(mas[6]) &&
                numbers1.Contains(mas[8]) && numbers2.Contains(mas[9]) && numbers3.Contains(mas[10]) &&
                numbers1.Contains(mas[12]) && numbers2.Contains(mas[13]) && numbers3.Contains(mas[14]))
            {
                return "Normal ip";
            }
            else
            {
                return "Bad ip";
            }
        }
    }
}