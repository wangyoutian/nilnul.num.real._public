using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class PositiveReal
        :
        IPositiveReal
        
	{
        #region IComparable<IReal> Members

        public int CompareTo(IReal other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
