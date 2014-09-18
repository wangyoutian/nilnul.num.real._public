using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.number.real
{
	/// <summary>
	/// return an enumerable sequence of integers to express an real number.
	/// </summary>
	public partial class ContinuedFraction
		:UnaryOpA<RealI,ContinuedFraction.Expr>
	{

		public partial class Expr
			:RealI
		{
			public BigInteger floor{get;set;}
			public IEnumerable<nint.Nint> terms { get; set; }
			
			public Expr(BigInteger floor, IEnumerable<nint.Nint> terms)
			{
				this.floor=floor;
				this.terms=terms;
			}


			public RealI eval()
			{
				return this;
			}

			public RealI eval(out bool evaled)
			{
				throw new NotImplementedException();
			}

			ExprI ExprI.eval()
			{
				throw new NotImplementedException();
			}

			ExprI ExprI.eval(out bool evaled)
			{
				throw new NotImplementedException();
			}

			public IEnumerable<VarI> vars
			{
				get { throw new NotImplementedException(); }
			}
		}

		static private readonly ContinuedFraction _Instance = new ContinuedFraction();
		static public ContinuedFraction Instance
		{
			get
			{
				return _Instance;
			}
		}
		private ContinuedFraction()
		{
		}












		public override ExprI<ContinuedFraction.Expr> eval(ExprI<RealI> arg)
		{
			throw new NotImplementedException();
		}

		public override ContinuedFraction.Expr eval(RealI arg)
		{
			throw new NotImplementedException();
		}
		
	}
}
