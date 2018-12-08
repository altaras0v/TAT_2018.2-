using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string str = args[0];
            Finder finder = new Finder();
            IpValidator validator = new IpValidator();
            validator.GetValidation(finder.IpFinder(str));        
           
        }
    }
}
