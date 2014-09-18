using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using NPlus = nilnul.num.natural.PositiveNatural_inheritNatural2;

namespace nilnul.num.real.func
{
	public partial class RootOfNatural
	{
		private N _radical;

		public N radical
		{
			get { return _radical; }
			set { _radical = value; }
		}
		private NPlus _root;

		public NPlus root
		{
			get { return _root; }
			set { _root = value; }
		}
		
		
		

		public RootOfNatural(nilnul.num.natural.Natural_bigInteger n,nilnul.num.natural.PositiveNatural_inheritNatural2 root)
		{
			this._radical = n;
			this._radical = root;
		}
					
	}
}
