using System;
using System.Collections;

using nilnul.number.integer;


namespace nilnul.number.real
{
	

	public partial class Factorial:PositiveInteger
	{
        private NonnegativeInteger _n;

        public Factorial(NonnegativeInteger n) {
            this._n = n;
        }

		public NonnegativeInteger n {
			get {
				return _n;
			}
			set {
				_n = value;
			}
		}


		public ulong toUlong() { 
			if(n is NonnegativeInteger<uint>){

				return ((NonnegativeInteger<uint>)n).value.Factorial();
				
			}

		}



		public override string ToString()
		{
			return _n.ToString()+"!";
		}

		static public explicit operator ulong(Factorial a){



			return Compute(a._n);
		
			
			
			//21 will be overflown.
		}

		

			
	}//class

	static public class Factorial_Extension {

		static public ulong Factorial(this uint n) {
			if (n == 0) return 1;

			return n * (n - 1).Factorial();

		}
		
	}
	
	
	
}
