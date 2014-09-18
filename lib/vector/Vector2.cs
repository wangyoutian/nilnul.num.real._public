using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.realNumber;

namespace nilnul.linearAlgebra
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Vector2
	{
		public IList<RealI> components { get; set; }

		public Vector2(params RealI[] components)
		{
			this.components = components;
		}

					
	}

	public partial class Vector2:VectorI
	{


		#region IEnumerable<RealI> Members

		public IEnumerator<RealI> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
