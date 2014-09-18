using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.xReal;

namespace nilnul.number.real
{
	public partial class Interval
	{
		public bool leftOpen { get; set; }
		public bool rightOpen { get; set; }
		public xReal.ExprI left { get; set; }
		public xReal.ExprI right { get; set; }

		public Interval(bool leftOpen, xReal.ExprI left, xReal.ExprI right, bool rightOpen)
		{

			validateLeftNoMoreThanRight(leftOpen,left,right,rightOpen);
			valideInf( leftOpen,  left,  right, rightOpen);
			this.leftOpen = leftOpen;
			this.left = left;
			this.right = right;
			this.rightOpen = rightOpen;
		}

		/// <summary>
		/// avoid [-inf,+inf]
		/// </summary>
		/// <param name="leftOpen"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="rightOpen"></param>
		private void valideInf(bool leftOpen, xReal.ExprI left, xReal.ExprI right, bool rightOpen){
			if (left is InfiniteI && !leftOpen 
				||
				right is InfiniteI && !rightOpen
				)
			{
				throw new Exception();
		 
			}
		}

		private void validateLeftNoMoreThanRight(bool leftOpen, xReal.ExprI left, xReal.ExprI right, bool rightOpen)
		{
			int? compareLR=	xReal.Compare.Eval(left,right);
			if (leftOpen || rightOpen)
			{

				if (compareLR.HasValue && compareLR.Value <0)
				{							
					return ;

				}
	
				
			}
			else
			{
				if (compareLR.HasValue && compareLR.Value<=0)
				{
					 return ;
				}

			}
			throw new Exception();
		}
					

	}
}
