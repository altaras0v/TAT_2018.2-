using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIp
{
    class Finder
    {
        static char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char[] IpFinder(String str)
        {
            char[] arr; 
            char[] ip = new char[15];
            int a = str.Length;
            arr = str.ToCharArray(0, a - 1);
            for (int i = 0; i < arr.Length - 14; i++)
                if (numbers.Contains(arr[i]) && numbers.Contains(arr[i + 1]) && numbers.Contains(arr[i + 2]) && arr[i + 3] == '.'
                   && numbers.Contains(arr[i + 4]) && numbers.Contains(arr[i + 5]) && numbers.Contains(arr[i + 6]) && arr[i + 7] == '.'
                   && numbers.Contains(arr[i + 8]) && numbers.Contains(arr[i + 9]) && numbers.Contains(arr[i + 10]) && arr[i + 11] == '.'
                   && numbers.Contains(arr[i + 12]) && numbers.Contains(arr[i + 13]) && numbers.Contains(arr[i + 14]))
                {
                    for (int j = 0; j < 15; j++)
                    {
                        ip[j] = arr[i + j];
                    }
                }
            return ip;
        }

    }
}
