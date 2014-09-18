using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.math.number.complex.real
{
	public partial class Real<T>
	{
		/// <summary>
		/// double is note included for it observes the real interface--its calculation is approximated and obscure.
		/// </summary>
		static readonly FiniteSet<Type> ClrNonnegativeIntegerTypeS=new FiniteSet<Type>(
													
															 typeof(uint),
															 typeof(ulong)
														 );
		static public readonly FiniteSet<Type> ClrIntegerTypeS=	ClrNonnegativeIntegerTypeS.Add(
				
			new []{
				typeof(int),
				typeof(long)
			}
				
		);

		static public readonly FiniteSet<Type> ClrRealTypeS =  ClrIntegerTypeS.Add(
			new []{
				typeof(decimal)
			}

		);

		static public readonly FiniteSet<Type> ClrNumberTypes = ClrRealTypeS.Add(
			new[]{
				typeof(double),
				typeof(float)
			}
		);
												  
											

	}
}
