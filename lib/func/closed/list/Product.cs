using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class Product
		:ClosedListOpI
	{

		static private readonly Product _Instance = new Product();
		static public Product Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Product()
		{
		}

		public ExprI call(params ExprI[] terms) {
			return new ClosedListOpExpr(this, terms);
		}


		public int ary
		{
			get { throw new NotImplementedException(); }
		}

		public IEnumerable<Type> types
		{
			get { throw new NotImplementedException(); }
		}
		static public ExprI Call(params ExprI[] terms) {
			return Instance.call(terms);
		}
	}
}
