using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.integer
{
	public struct NonnegativeInteger<T>
		:uint
		
	{
		private T _value;

		public NonnegativeInteger(uint u) {
			_value = u;


		}

		public uint value {
			get {
				return _value;
			}
			set {
				_value = value;
			}
		}

		public uint toUint() {
			return _value;
		}

		static public implicit operator uint(NonnegativeInteger<uint> a) {
			return a.value;
		}

		static public implicit operator NonnegativeInteger<uint>(uint a) {
			return new NonnegativeInteger<uint>(a);
		}

		static public NonnegativeInteger<uint> operator +(NonnegativeInteger<uint> a, NonnegativeInteger<uint> b)
		{
			return new NonnegativeInteger<uint>(a.value + b.value);
		}
		static public NonnegativeInteger<uint> operator -(NonnegativeInteger<uint> a, NonnegativeInteger<uint> b)
		{
			return new NonnegativeInteger<uint>(a.value - b.value);
		}



		static public NonnegativeInteger<uint> operator *(NonnegativeInteger<uint> a, NonnegativeInteger<uint> b)
		{
			return new NonnegativeInteger<uint>(a.value * b.value);
		}
		static public NonnegativeInteger<uint> operator /(NonnegativeInteger<uint> a, NonnegativeInteger<uint> b)
		{
			if (a % b == 0)
			{
				return new NonnegativeInteger<uint>(a.value / b.value);
			}
			throw new ArgumentException();
		}

	}
}
