using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
    /// <summary>
    /// Define the ratio of a cirle to its diameter.
    /// </summary>
    public class Pi
    {
        private const string _Recite = "3.14159 26535 89793 23846 26433 83279 50288";
        const decimal ApproximateValue=3.14159265358979323846264338327950288m;
        const decimal dot35digits = .00000000000000000000000000000000001m;
        

        /// <summary>
        /// Return a value that's in the closed interval [true value-deviation,trueValue+deviation] 
        /// </summary>
        /// <param name="deviation"></param>
        /// <returns></returns>
        static public decimal Estimate(decimal deviation){
            if (deviation > .005m)
            {
                return 3.14m;
            }
            else if (deviation > (dot35digits))
            {
                return ApproximateValue;

            }
            else {
                throw new Exception("Cannot reach such precesion.");
            }

        }

        static public Pi Exact() {
            return new Pi();
        }
    }
}
