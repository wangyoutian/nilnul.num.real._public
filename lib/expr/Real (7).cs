using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;


namespace nilnul.math.number.complex.real
{

	

	/// <summary>
	/// Primitive values, objects, functions, expressions, variables that are real numbers.
	/// </summary>
	
	public partial class Real
		
    {

		//int IComparable<IReal>.CompareTo(IReal a)
		//{
		//    throw new NotSupportedException();
		//}

		//int IComparable.CompareTo(object a)
		//{
		//    return ((IComparable<IReal>)(this)).CompareTo((IReal)a);
		//}

		//public bool Equals(IReal a) {
		//    throw new NotSupportedException();
		//}

		//public IReal factorial() {
		//    return new GammaFunction(this);
		//}


		
 
	

		#region Properties

		//public object value
		//{
		//    get
		//    {
		//        return this["value"];
		//    }
		//    set
		//    {
		//        this["value"] = value;
		//    }
		//}
	
		#endregion

		#region Methods
		//public Real Power(Real exp) {
		//        return new Power(this,exp);
		//    }
	
		//public override string ToString()
		//{
		//    if (this["value"] == null)
		//    {
		//        return "--ull";
		//    }
		//    else {
		//        return this["value"].ToString();
		//    }
		//}
		#endregion





	


	

	










		//#region IEquatable<IReal> Members

		//public bool Equals(IReal other)
		//{
		//    throw new NotImplementedException();
		//}

		//#endregion

		#region IComparable<IReal> Members

		public virtual int CompareTo(IReal other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}//class
   
}//namespace




