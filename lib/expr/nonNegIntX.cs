using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.nonNegInt
{
	static public partial class nonNegIntX
	{

		/// <summary>
		/// up to caller to ensure no overflow.
		/// </summary>
		/// <param name="augend"></param>
		/// <param name="addend"></param>
		/// <param name="addendExp"></param>
		/// <returns></returns>
		static private uint[] _Add(this uint[] augend, uint addend, int addendExp)
		{

		    uint[] sum = new uint[augend.Length];

		    for (int i = 0; i < addendExp; i++)
		    {
		        sum[i] = augend[i];
		    }

		    sum[addendExp] = addend;

		    unsafe
		    {

		        fixed (uint* pr = sum)
		        {

		            uint* pr2 = pr;

		            pr2 += addendExp;

		            for (int i = addendExp; i < augend.Length-1; i++)
		            {
		                *(ulong*)pr2 += augend[i];	///augend must lead with 0.
		                pr2++;

		            }
		        }
		    }

		    return sum;


		}

		/// <summary>
		/// up to caller to ensure no overflow.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLen"></param>
		/// <param name="aPos">in range</param>
		/// <param name="b"></param>

		unsafe
		static private void _Increase( uint* augend, int augendLen, uint addend, int addendExponent)
		{

			ulong r = augend[addendExponent];		///aPos must be less than aLen-1

			r += addend;

			uint* pr2 = (uint*)&r;

			augend[addendExponent] = *pr2;

			pr2++;
			if (*(pr2 ) > 0)		/// a leading with 0 is safe from overflow.
			{
				_Increase(augend, augendLen, *(pr2 ), addendExponent + 1);
			}

		}


		/// <summary>
		/// ensure no overflow will occur beforehand.
		/// </summary>
		/// <param name="augend"></param>
		/// <param name="addend"></param>
		/// <param name="addendExponent"></param>
		static private void _Increase(
			this uint[] augend
			, uint addend
			, uint addendExponent
			)
		{

			if (addend>0)
			{
				ULong2UInt r = new ULong2UInt();

				r.ulongVal = augend[addendExponent];
				r.ulongVal += addend;

				augend[addendExponent] = r.lowUIntVal;

				augend._Increase(r.highUIntVal, addendExponent + 1);
				
			}
		}


		static private void _Increase(
		this uint[] augend
		, uint addend
		, int addendExponent
		)
		{

			if (addend > 0)
			{
				ULong2UInt r = new ULong2UInt();

				r.ulongVal = augend[addendExponent];
				r.ulongVal += addend;

				augend[addendExponent] = r.lowUIntVal;

				augend._Increase(r.highUIntVal, addendExponent + 1);

			}
		}

		
		static private void Increase(this uint[] augend, uint addend, uint addendExponent)
		{

			if (addend > 0)
			{
				if (addendExponent>augend.Length)
				{
					throw new OverflowException();
					
				}

				ULong2UInt r = new ULong2UInt();

				r.ulongVal = augend[addendExponent];
				r.ulongVal += addend;

				augend[addendExponent] = r.lowUIntVal;

				augend.Increase(r.highUIntVal, addendExponent + 1);

			}
		}


		/// <summary>
		/// a is no shorter than b; 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static private uint[] _Add(this uint[] a, uint[] b)
		{


			uint[] r = new uint[a.Length + 1];

			a.CopyTo(r, 0);

			for (uint i = 0; i < b.Length; i++)
			{

				r._Increase( b[i], i);
			}

			return r;


		}



		/// <summary>
		/// a is no shorter than b; 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>
		///		return a new array.
		/// </returns>
		/// 
		unsafe
		static private uint[] _Add(uint* a,int aLen, uint* b,int bLen)
		{

			int rLen = aLen + 1;

			uint[] r = new uint[rLen];
			


			//uint* r=stackalloc uint[rLen];

			for (int i = 0; i < aLen; i++)
			{
				r[i] = a[i];
			}

			//r[int]=0;

			for (uint i = 0; i < bLen; i++)
			{

				_Increase(r, b[i], i);
			}

			return r;


		}


		static public uint[] Add(this uint[] a, uint[] b)
		{

			if (a.Length >= b.Length)
			{
				return _Add(a, b);
			}
			return _Add(b, a);

		}


		unsafe
		static public uint[] Add(uint* a,int aLen, uint* b,int bLen)
		{

			if (aLen >= bLen)
			{
				return _Add(a,aLen, b,bLen);
			}
			return _Add(b,bLen, a,aLen);

		}


		//unsafe
		//static public uint[] Add(uint* a, int aLen, uint* b, int bLen,uint* r)
		//{

		//    if (aLen >= bLen)
		//    {
		//        return _Add(a, aLen, b, bLen,r);
		//    }
		//    return _Add(b, bLen, a, aLen,r);

		//}




		static private void Decrease(this uint[] a, uint[] b)
		{

			for (uint i = 0; i < b.Length; i++)
			{
				a.Decrease(b[i], i);
			}

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="bExponent"></param>
		static private void Decrease(
			this uint[] a, uint[] b,uint bExponent)
		{

			for (uint i = 0; i < b.Length; i++)
			{
				a.Decrease(b[i], i + bExponent);
			}

		}



		unsafe
		static private void _Decrease(uint* a,int aLen, uint* b,int bLen, int bExponent)
		{
			for (int i = bExponent; i < bLen + bExponent; i++)
			{
				_Decrease(a,aLen,b[i], i);
			}

		}

		unsafe
		static private void _Decrease(uint[] a, uint* b, uint bLen)
		{
			for (uint i = 0; i < bLen ; i++)
			{
				_Decrease(a, b[i], i);
			}

		}


		unsafe
		static private void _Decrease(uint[] a, uint* b, int bLen, uint bExponent)
		{


			for (uint i = bExponent; i < bLen + bExponent; i++)
			{
				_Decrease(a, b[i], i);
			}

		}



		unsafe
		static private void _Decrease(uint* a, int aLen, uint[] b, int bExponent)
		{
			int t=b.Length + bExponent;

			for (int i = bExponent; i < t; i++)
			{
				_Decrease(a, aLen, b[i], i);
			}

		}





		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b">>0</param>
		/// <param name="p"></param>
		static private void _Decrease(
			this uint[] a,
			uint b,		//b>0
			uint bExponent)
		{
			
				if (bExponent > a.ValidHigh())
				{
					throw new SubtractNegativeException();
				}


				if (a[bExponent] >= b)
				{
					a[bExponent] -= b;
				}

				else
				{
					a[bExponent] = (
							uint.MaxValue - (b - a[bExponent])
						) + 1;

					a._Decrease(1, bExponent + 1);

				}
	
			

			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="p"></param>
		static private void Decrease(this uint[] a, uint b, uint bExponent)
		{
			if (b > 0)
			{
				a._Decrease( b, bExponent);
			}


		}


		unsafe
		static private void _Decrease(uint* a,int aLen, uint b, int bExponent)
		{

			if (bExponent >= aLen)
			{
				throw new SubtractNegativeException();
			}


			if (a[bExponent] >= b)
			{
				a[bExponent] -= b;
			}

			else
			{
				a[bExponent] = (
						uint.MaxValue - (b - a[bExponent])
					) + 1;

				_Decrease(a ,aLen,1, bExponent + 1);

			}

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>-1: length is 0</returns>
		static public int ValidHigh(this uint[] a)
		{
			//if (a.Length == 0)
			//{
			//    return -1;
			//}

			int i;
			for (i = a.Length - 1; i >= 0; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}
			return i;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow"></param>
		/// <param name="aLen"></param>
		/// <returns></returns>
		static public int _ValidHighAtArray(this uint[] a, uint aLow, uint aLen)
		{
	
			int i;

			for (i = (int)(aLen + aLow - 1); i >= aLow; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}

			return i;
		}


		static public int _High(this uint[] a, int aLow, int aLen)
		{
			//if (a.Length == 0)
			//{
			//    return -1;
			//}
			int i;

			//checked { 
			//    i = aLen + aLow - 1;
			//}

			for (i = aLen + aLow - 1; i >= aLow; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}
			return i;
		}

		static public long _HighLong(this uint[] a, uint aLow, uint aLen)
		{
			//if (a.Length == 0)
			//{
			//    return -1;
			//}
			long i;

			//checked { 
			//    i = aLen + aLow - 1;
			//}

			for ( i = aLen + aLow - 1; i >= aLow; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}
			return i;
		}

		unsafe static public int ValidHigh(uint* a, uint aLen)
		{


			int i;

			for (i = ((int)aLen) - 1; i >= 0; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}
			return i;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLen">up2caller: >=0.</param>
		/// <returns>-1: it's 0.</returns>
		unsafe static public int _ValidHigh(uint* a, int aLen)
		{
	

			int i;

			for (i = aLen - 1; i >= 0; i--)
			{
				if (a[i] != 0)
				{
					break;
				}
			}

			return i;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>-1: length is 0</returns>
		static public int ValidLength(this uint[] a)
		{
			return ValidHigh(a) + 1;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>-1: length is 0</returns>
		/// 
		unsafe
		static public uint ValidLengthUint(uint* a,uint aLen)
		{
			return (uint)(ValidHigh(a,aLen) + 1);
		}


		unsafe
		static public int ValidLength(uint* a, int aLen)
		{
			return _ValidHigh(a, aLen) + 1;
		}

		static public uint _ValidLengthUint(this uint[] a, uint low, uint len)
		{
			//if (len == 0)
			//{
			//    return 0;
			//}

			//int i;


			//int high = low + len;

			return (uint)(_ValidHighAtArray(a,low, len) + 1);




		}

		static public uint[] TrimTo(this uint[] a)
		{

			int t = ValidLength(a);

			uint[] r = new uint[t];
			Array.Copy(a, r, t);
			return r;

		}

		unsafe
		static public uint[] TrimTo(uint* a,uint aLen)
		{

			uint t = ValidLengthUint(a,aLen);

			uint[] r = new uint[t];

			for (int i = 0; i <r.Length; i++)
			{
				r[i] = a[i];
			}
			
			return r;

		}

		unsafe
		static public uint[] TrimTo(uint* a, int aLen)
		{

			int t = ValidLength(a, aLen);

			uint[] r = new uint[t];

			for (int i = 0; i < r.Length; i++)
			{
				r[i] = a[i];
			}

			return r;

		}



		/// <summary>
		/// a longer than b.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <param name="bLen"></param>
		/// <returns></returns>
		unsafe
		static
		public int _Compare(uint* a, int aLen, uint* b, int bLen)
		{
			uint* i;

			uint* aLastOverB = a + bLen;

			for (i = a + aLen - 1; i >= aLastOverB; i--)
			{
				if (*i > 0)
				{
					return 1;
				}

			}

			//long baOffset;
			//baOffset = ;

			uint* bp = b - a + i;

			for (; i >= a; i--, bp--)
			{


				if (*i > *bp)
				{
					return 1;
				}
				if (*i < *bp)
				{
					return -1;
				}

			}
			return 0;
		}


		/// <summary>
		/// a longer than bLen.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <param name="bLen"></param>
		/// <returns></returns>
		unsafe
		static
		public int _Compare(uint[] a, uint* b, int bLen)
		{


			int i;

			for (i = a.Length - 1; i >= bLen; i--)
			{
				if (a[i] > 0)
				{
					return 1;
				}

			}

			//long baOffset;
			//baOffset = ;

			uint* bp = b + i;

			for (; i >= 0; i--, bp--)
			{


				if (a[i] > *bp)
				{
					return 1;
				}
				if (a[i] < *bp)
				{
					return -1;
				}

			}
			return 0;
		}
		/// <summary>
		/// a longer than bLen.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <param name="bLen"></param>
		/// <returns></returns>
		unsafe
		static
		public int _Compare(uint[] a, uint* b, uint bLen)
		{


			int i;

			for (i = a.Length - 1; i >= bLen; i--)
			{
				if (a[i] > 0)
				{
					return 1;
				}

			}

			//long baOffset;
			//baOffset = ;

			uint* bp = b + i;

			for (; i >= 0; i--, bp--)
			{


				if (a[i] > *bp)
				{
					return 1;
				}
				if (a[i] < *bp)
				{
					return -1;
				}

			}
			return 0;
		}


		unsafe
			static
			public int Compare(uint* a, int aLen, uint* b, int bLen)
		{

			if (aLen >= bLen)
			{
				return _Compare(a, aLen, b, bLen);
			}
			else
			{
				return _Compare(a, aLen, b, bLen);
			}

		}

		unsafe
			static
			public int Compare(this uint[] a, uint* b, int bLen)
		{

			if (a.Length >= bLen)
			{
				return _Compare(a,  b, bLen);
			}
			else
			{
				return _Compare(a,  b, bLen);
			}

		}

		unsafe
		static
		public int Compare(this uint[] a, uint* b, uint bLen)
		{

			if (a.Length >= bLen)
			{
				return _Compare(a, b, bLen);
			}
			else
			{
				return _Compare(a, b, bLen);
			}

		}


		static public int _Compare(this uint[] a, int aLow, int aLen, uint[] b, int bLow, int bLen)
		{

			int aHigh = a._High(aLow, aLen);
			int aHighFrag = aHigh - aLow;

			//int aValidLen = (int)(aHigh - aLow);// a.ValidLength(aLow, aLow);



			int bHigh = b._High(bLow, bLen);
			int bHighFrag = bHigh - bLow;
			//uint bValidLen = (uint)(bValidHigh - bLow);// b.ValidLength(bLow, bLen);


			if (aHighFrag < bHighFrag)
			{
				return -1;
			}
			if (aHighFrag > bHighFrag)
			{
				return 1;
			}

			//int bPos=bLow;

			for (int i = aHigh, j = bHigh; i >= aLow; i--, j--)
			{

				if (a[i] < b[j])
				{
					return -1;
				}
				if (a[i] > b[j])
				{
					return 1;
				}
			}
			return 0;


		}


		static public int _Compare(this uint[] a, uint aLow, uint aLen, uint[] b, uint bLow, uint bLen)
		{

			int aHigh = a._ValidHighAtArray(aLow, aLen);

			int aValidLen = (int)(aHigh - aLow);// a.ValidLength(aLow, aLow);



			int bValidHigh = b._ValidHighAtArray(bLow, bLen);
			uint bValidLen = (uint)(bValidHigh - bLow);// b.ValidLength(bLow, bLen);


			if (aValidLen < bValidLen)
			{
				return -1;
			}
			if (aValidLen > bValidLen)
			{
				return 1;
			}

			//int bPos=bLow;

			for (int i = aHigh, j = bValidHigh; i >= aLow; i--, j--)
			{

				if (a[i] < b[j])
				{
					return -1;
				}
				if (a[i] > b[j])
				{
					return 1;
				}
			}
			return 0;


		}

		
		/// <summary>
		/// a.Len>0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <returns></returns>

		static public int _Compare(this uint[] a, uint b)
		{

			

			for (int i = a.Length; i >0; i--)
			{

				
				if (a[i] > 0)
				{
					return 1;
				}
			}

			return a[0].CompareTo(b);
			


		}

		

		/// <summary>
		/// a.Len>1
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <returns></returns>

		static public int _Compare(this uint[] a, ulong b)
		{
			for (int i = a.ValidHigh(); i > 1; i--)
			{

				if (a[i] > 0)
				{
					return 1;
				}
			}

			unsafe
			{
				uint* t= ((uint*)&b)+1;

				if (a[1]>*t)
				{
					 return 1;
				}
				if (a[1]<*t)
				{
					return -1;
				}
				
				

			}
			return a[0].CompareTo(b);

		}


		/// <summary>
		/// a.Len>0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <returns></returns>

		static public int _Compare(this uint[] a, int aLow, int aLen, uint b)
		{



			for (int i = aLen + aLow; i > aLow; i--)
			{


				if (a[i] > 0)
				{
					return 1;
				}
			}

			return a[aLow].CompareTo(b);



		}


		/// <summary>
		/// a.Len>0
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow"></param>
		/// <param name="aLen"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public int _Compare(this uint[] a, uint aLow, uint aLen, uint b)
		{



			for (uint i = aLen + aLow; i > aLow; i--)
			{

				if (a[i] > 0)
				{
					return 1;
				}
			}

			return a[aLow].CompareTo(b);



		}


		/// <summary>
		/// a.Length no shorter than bLen
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="bLow"></param>
		/// <param name="bLen"></param>
		/// <returns></returns>

		static public int _Compare(this uint[] a, uint[] b, int bLow, int bLen)
		{

			return _Compare(a, 0, a.Length, b, bLow, bLen);

			//int al = a.ValidLength();
			//int bl = b.ValidLength(bLow, bLen);

			//if (al < bl)
			//{
			//    return -1;
			//}
			//if (al > bl)
			//{
			//    return 1;
			//}

			//for (int i = al-1; i >= 0; i--)
			//{
			//    if (a[i] < b[i])
			//    {
			//        return -1;
			//    }
			//    if (a[i] > b[i])
			//    {
			//        return 1;
			//    }
			//}
			//return 0;


		}


		static public int _Compare(this uint[] a, uint[] b, uint bLow, uint bLen)
		{

			return _Compare(a, 0u, (uint)(a.Length), b, bLow, bLow);

			//int al = a.ValidLength();
			//int bl = b.ValidLength(bLow, bLen);

			//if (al < bl)
			//{
			//    return -1;
			//}
			//if (al > bl)
			//{
			//    return 1;
			//}

			//for (int i = al-1; i >= 0; i--)
			//{
			//    if (a[i] < b[i])
			//    {
			//        return -1;
			//    }
			//    if (a[i] > b[i])
			//    {
			//        return 1;
			//    }
			//}
			//return 0;


		}




		static public uint[] Subtract(this uint[] a, uint[] b)
		{
			uint[] r = a.TrimTo();

			r.Decrease(b);
			return r;
		}


		unsafe
		static public uint[] Subtract(uint* a,uint aLen, uint* b,uint bLen)
		{

			uint[] r = TrimTo(a,aLen);

			_Decrease(r,b,bLen);

			return r;
		}

		unsafe
		static public uint[] Multiply( uint* a,int aLen, uint* b,int bLen)
		{
			return Multiply_(a,aLen,b,bLen).TrimTo();

		}



		static public uint[] Multiply(this uint[] a, uint[] b)
		{


			uint[] r = new uint[a.Length + b.Length];

			uint tp;
			
			ULong2UInt t=new ULong2UInt();

			for (uint i = 0; i < a.Length; i++)
			{
				for (uint j = 0; j < b.Length; j++)
				{
					t.ulongVal = a[i];
					t.ulongVal*= b[j];

					tp = i + j;

					r._Increase(t.lowUIntVal, tp);

					tp++;

					r._Increase(t.highUIntVal, tp);

				}
			}
			return r.TrimTo();

		}





		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow">in range</param>
		/// <param name="aLen">0-a.Len</param>
		/// <param name="b"></param>
		/// <param name="bLow"></param>
		/// <param name="bLen"></param>
		/// <returns></returns>
		static public uint[] _Multiply(this uint[] a,uint aLow,uint aLen, uint[] b,uint bLow,uint bLen)
		{

			uint rLen = aLen + bLen;

			uint[] r = new uint[rLen];

			uint tPos=0;

			for (uint i = aLow; i < aLen+aLow; i++,tPos++)
			{
				for (uint j = bLow; j < bLen; j++)
				{
					ULong2UInt t= new ULong2UInt();

					t.ulongVal = ((ulong)(a[i])) * b[j];

					//tPos = i + j;

					r._Increase(t.lowUIntVal, tPos);

					tPos++;

					r._Increase(t.highUIntVal, tPos);




				}
			}
			return r;

		}


		
		unsafe
		static public uint[] Multiply_(uint* a,  uint aLen, uint* b, uint bLen)
		{

			uint rLen = aLen + bLen;

			uint[] r = new uint[rLen];

			uint tPos = 0;

			for (uint* i = a; i < a + aLen; i++, tPos++)
			{
				for (uint* j = b; j <b+ bLen; j++)
				{
					ULong2UInt t = new ULong2UInt();

					t.ulongVal = *i;
					t.ulongVal *=  *b;

					//tPos = i + j;

					r._Increase(t.lowUIntVal, tPos);

					tPos++;

					r._Increase(t.highUIntVal, tPos);


				}
			}
			return r;

		}

		unsafe
		static public uint[] Multiply_(uint* a, int aLen, uint* b, int bLen)
		{

			int rLen = aLen + bLen;

			uint[] r = new uint[rLen];

			uint tPos = 0;

			for (uint* i = a; i < a + aLen; i++, tPos++)
			{
				for (uint* j = b; j < b + bLen; j++)
				{
					ULong2UInt t = new ULong2UInt();

					t.ulongVal = *i;
					t.ulongVal *= *b;

					//tPos = i + j;

					r._Increase(t.lowUIntVal, tPos);

					tPos++;

					r._Increase(t.highUIntVal, tPos);


				}
			}
			return r;

		}

		unsafe
		static public uint[] Multiply_(uint* a, uint aLen, uint b)
		{

			uint rLen = aLen + 1;

			uint[] r = new uint[aLen+1];

			ulong tm;
			uint* tmp=(uint*)(&tm);

			for (uint i = 0; i < aLen; i++)
			{
				tm = a[i];

				tm *= b;
				r._Increase(*tmp, i);	
				tmp++;
				r._Increase(*tmp, i+1);					
			}
			return r;

		}

	
		unsafe
		static public uint[] Multiply_(uint* a, int aLen, uint b)
		{

			int rLen = aLen + 1;

			uint[] r = new uint[aLen+1];

			ulong tm;
			uint* tmp=(uint*)(&tm);

			for (uint i = 0; i < aLen; i++)
			{
				tm = a[i];

				tm *= b;
				r._Increase(*tmp, i);	
				tmp++;
				r._Increase(*tmp, i+1);					
			}
			return r;

		}


		static public uint[] Multiply(this uint[] a, uint b)
		{
			uint[] r = new uint[a.Length + 1];


			for (uint i = 0; i < a.Length; i++)
			{

				ULong2UInt t=new ULong2UInt();
				t.ulongVal = ((ulong)(a[i])) * b;

				r._Increase(t.lowUIntVal, i);
				r._Increase(t.highUIntVal, i + 1);


			}

			return r.TrimTo();
		}



		static public uint[] Multiply(this uint a, uint b)
		{
			uint[] r = new uint[2];


			
			ULong2UInt t = new ULong2UInt();
			t.ulongVal = a;
			t.ulongVal*=b;
			r[0] = t.lowUIntVal;
			r[1] = t.highUIntVal;
			
			

			return r;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="aLow">[0,a.Length)</param>
		/// <param name="aLen">[0,a.Length-aLow]</param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public uint[] _Multiply(this uint[] a, uint aLow, uint aLen, uint b)
		{
			uint[] r = new uint[aLen + 1];

			uint aHigh = aLow + aLen;

			for (uint i = aLow, j = 0; i < aHigh; i++, j++)
			{

				ULong2UInt t = new ULong2UInt();
				t.ulongVal = ((ulong)(a[i])) * b;

				r._Increase(t.lowUIntVal, j);
				r._Increase(t.highUIntVal, j + 1);


			}

			return r;
		}
		static public uint[] _Multiply(this uint[] a, int aLow, int aLen, uint b)
		{
			uint[] r = new uint[aLen + 1];

			int aHigh = aLow + aLen;

			for (int i = aLow, j = 0; i < aHigh; i++, j++)
			{

				ULong2UInt t = new ULong2UInt();
				t.ulongVal = a[i];
				t.ulongVal *= b;

				r._Increase(t.lowUIntVal, j);
				r._Increase(t.highUIntVal, j + 1);


			}

			return r;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="p">
		///		the end point of a.
		/// </param>
		/// <returns></returns>
		/// <remarks>a from the beginning to p is no more than uint.MaxValue times of b. </remarks>


		static uint _Quotient(this uint[] dividendArray, int dividendStart, int dividendLen, uint[] divisor)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 



			uint u = uint.MaxValue;
			if (divisor.Multiply(u)._Compare(dividendArray, dividendStart, dividendLen) < 0)
			{
				return u;

			}
			uint l = 0;
			uint m = (u + l) / 2;
			do
			{
				if (divisor.Multiply(m)._Compare(dividendArray, dividendStart, dividendLen) > 0)
				{
					u = m;
					m = (u + l) / 2;
				}
				else if (divisor.Multiply(m)._Compare(dividendArray, dividendStart, dividendLen) < 0)
				{
					l = m;
					m = (u + l) / 2;
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}

		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="p">
		///		the end point of a.
		/// </param>
		/// <returns></returns>
		/// <remarks>a from the beginning to p is no more than uint.MaxValue times of b. </remarks>


		static uint _Quotient(this uint[] dividendArray, uint dividendStart, uint dividendLen, uint[] divisor)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 



			uint u = uint.MaxValue;
			if (divisor.Multiply(u)._Compare(dividendArray, dividendStart, dividendLen) < 0)
			{
				return u;

			}
			uint l = 0;
			uint m = (u + l) / 2;
			do
			{
				if (divisor.Multiply(m)._Compare(dividendArray, dividendStart, dividendLen) > 0)
				{
					u = m;
					m = (u + l) / 2;
				}
				else if (divisor.Multiply(m)._Compare(dividendArray, dividendStart, dividendLen) < 0)
				{
					l = m;
					m = (u + l) / 2;
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}


		static uint _Quotient(this uint[] dividendArray, int dividendLow, int dividendLen, uint divisor)
		{

			return _Quotient(dividendArray,dividendLow,dividendLen,new uint[]{divisor});

			
		}

		static uint _Quotient(this uint[] dividendArray, uint dividendLow, uint dividendLen, uint divisor)
		{

			return _Quotient(dividendArray,dividendLow,dividendLen,new uint[]{divisor});

			
		}



		//static uint _Quotient(this uint[] dividendArray,  uint divisor)
		//{

		//    ///divisor is not 0
		//    ///dividend is [0, divisor * uint*MaxValue ] 

		//    uint u = uint.MaxValue;
			
		//    if (

		//            dividendArray._Compare( u * divisor) < 0)
		//    {
		//        return u;

		//    }
		//    uint l = 0;
		//    uint m = (u + l) / 2;

		//    int compareM;
		//    do
		//    {
		//        compareM = dividendArray._Compare( divisor * m);

		//        if (compareM > 0)
		//        {
		//            u = m;
		//            m = (u + l) / 2;
		//        }
		//        else if (compareM < 0)
		//        {
		//            l = m;
		//            m = (u + l) / 2;
		//        }
		//        else
		//        {
		//            return m;
		//        }

		//    } while (u - l > 1);
		//    return l;
		//}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dividendArray"></param>
		/// <param name="dividendLow">[0,dividend.Length)</param>
		/// <param name="dividendLen">[0,dividendArray.Len-dividendLow]</param>
		/// <param name="divisorArray"></param>
		/// <param name="divisorLow"></param>
		/// <param name="divisorLen"></param>
		/// <returns></returns>
		static uint _Quotient(this uint[] dividendArray, uint dividendLow, uint dividendLen, uint[] divisorArray,uint divisorLow,uint divisorLen)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 

			if (
				divisorArray._Multiply(
					divisorLow
					,
					divisorLen
					,uint.MaxValue
				)._Compare(
						dividendArray, dividendLow, dividendLen
				) < 0)
			{
				return uint.MaxValue;
			}


			uint u = uint.MaxValue;


			uint l = 0;
			uint m = (u + l) / 2;
			do
			{
				if (divisorArray.Multiply(m)._Compare(dividendArray, dividendLow, dividendLen) > 0)
				{
					u = m;
					m = (u + l) / 2;
				}
				else if (divisorArray.Multiply(m)._Compare(dividendArray, dividendLow, dividendLen) < 0)
				{
					l = m;
					m = (u + l) / 2;
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dividendArray"></param>
		/// <param name="dividendLow">[0,dividend.Length)</param>
		/// <param name="dividendLen">[0,dividendArray.Len-dividendLow]</param>
		/// <param name="divisorArray"></param>
		/// <param name="divisorLow"></param>
		/// <param name="divisorLen"></param>
		/// <returns></returns>


		static uint _Quotient(this uint[] dividendArray, int dividendLow, int dividendLen, uint[] divisorArray,int divisorLow,int divisorLen)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 

			if (
				divisorArray._Multiply(					divisorLow					,					divisorLen					,uint.MaxValue				)._Compare(
						dividendArray, dividendLow, dividendLen
				) < 0)
			{
				return uint.MaxValue;
			}


			uint u = uint.MaxValue;


			uint l = 0;
			

			uint m = (uint)(((ulong)u + l) / 2);

			int cm;
			do
			{
				cm=divisorArray.Multiply(m)._Compare(dividendArray, dividendLow, dividendLen) ;

				if (cm> 0)
				{
					u = m;
					m = (uint) (((ulong)u + l) / 2);
				}
				else if (cm < 0)
				{
					l = m;
					m = (uint)(((ulong)u + l) / 2);
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dividendAddr"></param>
		/// <param name="dividendLen"></param>
		/// <param name="divisorAddr"></param>
		/// <param name="divisorLen"></param>
		/// <returns></returns>
		unsafe
		static uint _Quotient(uint* dividendAddr,  uint dividendLen, uint* divisorAddr,  uint divisorLen)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 
			///



			if (
				

				Multiply_(
					divisorAddr
					,
					divisorLen
					,
					uint.MaxValue
					).Compare(dividendAddr,  dividendLen) < 0)
			{
				return uint.MaxValue;
			}


			uint u = uint.MaxValue;


			uint l = 0;
			uint m = (u + l) / 2;

			int fm;
			do
			{
				fm=Multiply_(dividendAddr,divisorLen,m).Compare(dividendAddr,  dividendLen);

				if (fm > 0)
				{
					u = m;
					m = (u + l) / 2;
				}
				else if (fm < 0)
				{
					l = m;
					m = (u + l) / 2;
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}

		unsafe
			static uint _Quotient(uint* dividendAddr, int dividendLen, uint* divisorAddr, int divisorLen)
		{

			///divisor is not 0
			///dividend is [0, divisor * uint*MaxValue ] 
			///



			if (


				Multiply_(
					divisorAddr
					,
					divisorLen
					,
					uint.MaxValue
					).Compare(dividendAddr, dividendLen) < 0)
			{
				return uint.MaxValue;
			}


			uint u = uint.MaxValue;


			uint l = 0;
			uint m = (u + l) / 2;

			int fm;
			do
			{
				fm = Multiply_(dividendAddr, divisorLen, m).Compare(dividendAddr, dividendLen);

				if (fm > 0)
				{
					u = m;
					m = (u + l) / 2;
				}
				else if (fm < 0)
				{
					l = m;
					m = (u + l) / 2;
				}
				else
				{
					return m;
				}

			} while (u - l > 1);
			return l;
		}


		/// <summary>
		/// 
		/// all trimmed.
		/// 
		/// </summary>
		/// <param name="dividend">remainder will be left</param>
		/// <param name="dividendLow">
		/// [0,dividend.Len)
		/// </param>
		/// <param name="dividendLen">
		/// [0, dividend.Len-dividend.Low]
		/// </param>
		/// <param name="divisor">>0</param>
		/// <param name="divisorLow">[0,divisor.Len)</param>
		/// <param name="divisorLen">[0, divisor.Len-divisor.Low]</param>
		/// <returns>quotient</returns>
		/// 
		static public  uint[] _QuntientRemainder(
			this uint[] dividend
			,int dividendLow	//
			,int dividendLen	//
			, uint[] divisor	// 
			,int divisorLow		//
			,int divisorLen		//
		)
		{

			//uint[] dividendTrimmed = dividend.TrimTo();
			//uint[] divisorTrimmed = divisor.TrimTo();


			//int dividendHigh = dividend.ValidHigh();
			////int dividendValidLength = dividendHigh + 1;


			//int divisorHigh = divisor.ValidHigh();
			//int divisorValidLength = divisorHigh + 1;


			//if (dividendValidHigh < divisorValidHigh)
			//{
			//    return new uint[] { 0 };
			//}

			if (dividendLen<divisorLen)
			{
				return new uint[0] ;
				
			}



			//uint[] quotient = new uint[dividendValidHigh - divisorValidHigh + 1];

			uint[] quotient=new uint[dividendLen-divisorLen+1];

			int tL=divisorLen;

			for (int quotientPos = quotient.Length-1; quotientPos >= 0; quotientPos--)
			{
	
				quotient[quotientPos] =
					dividend._Quotient(

						quotientPos	
						,
						dividend.ValidHigh()-quotientPos+1
						,
						divisor
						,
						divisorLow
						,
						divisorLen
					);

				dividend.Decrease(
				
					divisor._Multiply(
							divisorLow
							,
							divisorLen
							,
							quotient[quotientPos]
						)
					,
					(uint)quotientPos
				);

				
			}

			return quotient;
		}


		static public uint[] _QuntientRemainder(
			this uint[] dividend
			, uint dividendLow	//[0,dividend.Len)
			, uint dividendLen	//[0, dividend.Len-dividend.Low]
			, uint divisor	// >0

		)
		{

			int dividendHigh = dividend.ValidHigh();

			if (dividendHigh < 0)
			{
				return new uint[0];

			}

			uint[] quotient = new uint[dividendHigh + 1];

			for (int quotientPos = quotient.Length - 1; quotientPos >= 0; quotientPos--)
			{

				quotient[quotientPos] =
					dividend._Quotient(

						dividendLow
						,
						dividendLen
						,
						divisor

					);

				dividend.Decrease(

					divisor *
							quotient[quotientPos]

					,
					(uint)quotientPos
				);


			}

			return quotient;
		}


		//static public uint[] _QuntientRemainder(
		//        this uint[] dividend
		//        , uint divisor	// >0

		//    )
		//{

		//    int dividendHigh = dividend.ValidHigh();

		//    if (dividendHigh < 0)
		//    {
		//        return new uint[0];

		//    }

		//    uint[] quotient = new uint[dividendHigh + 1];

		//    for (int quotientPos = quotient.Length - 1; quotientPos >= 0; quotientPos--)
		//    {

		//        quotient[quotientPos] =
		//            dividend._Quotient(

						
		//                divisor

		//            );

		//        dividend.Decrease(

		//            divisor *
		//                    quotient[quotientPos]

		//            ,
		//            (uint)quotientPos
		//        );


		//    }

		//    return quotient;
		//}


		




		unsafe static public  uint[]	
			QuotientRemainder(
				uint* dividendAddr
				
				, int dividendLen	
				, uint* divisorAddr	
				
				, int divisorLen		
			)
		{


			int dividendHigh = _ValidHigh(dividendAddr, dividendLen);
			int divisorHigh = _ValidHigh(divisorAddr, divisorLen);

			if (dividendHigh < divisorHigh)
			{
				return new uint[0];

			}

			uint[] quotient = new uint[dividendHigh - divisorHigh + 1];

			for (int quotientPos = quotient.Length - 1; quotientPos >= 0; quotientPos--)
			{
				
				quotient[quotientPos] =
					_Quotient(
						

						dividendAddr
						,
						dividendLen
						,
						divisorAddr
						,
						divisorLen
					);



				_Decrease(
					dividendAddr
					,
					dividendLen,

					Multiply_(
						divisorAddr
						, divisorLen
						,
						quotient[quotientPos]
					)

					, quotientPos
				);


			}

			return quotient;
		}

		static public uint[] QuotientRemainder(this uint[] dividend, uint divisor)
		{

			return QuotientRemainder(dividend, new uint[] { divisor});





		}


		static public uint[] QuotientRemainder(this uint[] dividend,uint[] divisor) {


			int dividendValidHigh = dividend.ValidHigh();
			//int dividendValidLength = dividendValidHigh+1;

			
			int divisorValidHigh = divisor.ValidHigh();
			//int divisorValidLength = divisorValidHigh+1;



			if (divisorValidHigh<0)
			{
				throw new DivideByZeroException();
				
			}

			return _QuntientRemainder(dividend, 0, dividendValidHigh + 1, divisor, 0, divisorValidHigh + 1);


		
		}

		static public string ToDecimalStr(this uint[] a)
		{

			uint[] a2=new uint[a.Length];

			a.CopyTo(a2,0);

			if (a2.ValidHigh()<0)
			{
				return "0";
		 
			}
			else

			if (a2._Compare(new uint[] { 10 },0,1) < 0)
			{
				
				return a2[0].ToString();


			}

			else
			{
				uint[] r = a2.QuotientRemainder(new uint[] { 10 });

				return r.ToDecimalStr() + a2.ToDecimalStr();
			}

		}

	

		static public uint[] Factorial(this uint[] n)
		{
			if (n.ValidHigh() == -1) return new uint[] { 1u };

			return n.Multiply(
				n.Subtract(
					new uint[] { 1 }
					
				)
				.Factorial())
			;

		}
		

	
		
			


	}
}
