using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.realNumber
{
	public partial class ClrRealSet

	{
		/// <summary>
		/// double is note included for it observes not the real interface--its calculation is approximated and obscure.
		/// </summary>
		static readonly FiniteSet<Type> ClrNonnegativeIntegerTypeS;
		
		
		static ClrRealSet(){


			ClrNonnegativeIntegerTypeS=new FiniteSet<Type>(
													
															 typeof(uint),
															 typeof(ulong)
														 );


			ClrIntegerTypeS= new FiniteSet<Type>();
			ClrIntegerTypeS.Add(ClrNonnegativeIntegerTypeS.AsEnumerable());
			ClrIntegerTypeS.Add(
				new[]{typeof(int),
				typeof(long)}

			);


			ClrRealTypeS= new FiniteSet<Type>();

			ClrRealTypeS.Add(ClrIntegerTypeS.AsEnumerable()).Add(
				typeof(decimal)

			);


			ClrNumberTypes=new FiniteSet<Type>();
			ClrNumberTypes.Add(ClrRealTypeS.AsEnumerable()).Add(
				new []{ typeof(double),
				typeof(float)}
			);
		}
		static public readonly FiniteSet<Type> ClrIntegerTypeS;

		static public readonly FiniteSet<Type> ClrRealTypeS ;

		static public readonly FiniteSet<Type> ClrNumberTypes ;
												  
											

	}
}
