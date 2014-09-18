using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
    
        class FiniteDiscreteNumberSet : Set
        {
            List<Number> _list;

            public bool IsSubsetOf(FiniteDiscreteNumberSet c){
			foreach(Number n in c._list){
				if(this._list.){
				}
			}
		}
            public bool contains(Number n)
            {
                foreach (Number i in _list)
                {
                    if (i == n)
                    {
                        return true;
                    }
                }
                return false;
            }


        }
    
}
