using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.real.op
{
    /// <summary>
    /// this is the expression of Inf.
    /// </summary>
   public partial class Inf
    {
	   static public RealI Call(SetI set) {
		   return new InfExpr(set);
	   }

    }

   public partial class InfExpr
	   :RealI
	   
   {
	   public real.collection.SetI set { get; set; }
	   public InfExpr(real.collection.SetI set)
	   {
		   this.set = set;
	   }


	   public RealI eval()
	   {
		   throw new NotImplementedException();
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
}
