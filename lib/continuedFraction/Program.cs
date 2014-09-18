using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuedFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinuedFraction a=new ContinuedFraction(1,7,3,8);
            ContinuedFraction b = new ContinuedFraction(1,7,5,7);

            Console.WriteLine(a.CompareTo(b));
            
        }
    }
}
