using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number;
using nilnul.math.number.real.rational.integer;
using nilnul.math.number.real.rational;
using nilnul.math.calculus;
using nilnul.math.complex.real;
using nilnul.math.complex.real.set;
using RealSetType = nilnul.math.complex.real.set.Type;

namespace nilnul.math.complex.real.function
{

	/// <summary>
	/// The return value is Real and all the parameters is Real, for there must be analysis such as Derivative.
	/// 
	/// All the parameters is real, not necessary, to be used in statistics.
	/// 
	/// Returned Value is real. But the domain is not necessary real.
	/// 
	/// AKA: RealValuedFunction
	/// </summary>
	public class RealFunction : Real
	{
		private Set _domain;
		public Func<Real, Real[]> logic
		{
			get
			{
				return this["logic"];
			}
			set
			{
				this["logic"] = value;
			}
		}
		public virtual Set domain {
			get {
				return _domain;
			}
			set {
				_domain = value;
				
			}
		}

		static public implicit operator Func<Real, Real[]>(Function f)
		{
			return f.logic;
		}

		static public implicit operator Function(Func<Real, Real[]> fc)
		{
			Function r = new Function();
			r.logic = fc;
			return r;
		}






		public PositiveInteger parametersCount
		{
			get
			{

				return (PositiveInteger)(this["parametersCount"]);
			}
			set
			{
				this["parametersCount"] = value;
			}
		}

		public Real PartialDerivative(Real[] x0, NonnegativeInteger[] sample)
		{
			return new PartialDerivative(this, x0, sample);//will check whether x0.length=f.parametersCount and sample's digits within x0.length.
		}

		/// <summary>
		/// Note: f(,) has two parameters.
		/// f's parameters count is unknown.
		/// f() or f(.) has only one parameters.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string seperator = ",";
			string r = this.name + "(";
			for (uint i = 0; i < (int)parametersCount; i++)
			{
				r += ",";
			}
			r = r.Remove(r.Length - seperator.Length);
			r += ")";
			return r;

		}


	}
}



///obsolete
namespace nilnul.math.number.real
{

	/// <summary>
	/// The return value is Real and all the parameters is Real, for there must be analysis such as Derivative.
	/// </summary>
    public class Function:Real
    {

		public Func<Real, Real[]> logic {
			get {
				return this["logic"];
			}
			set {
				this["logic"] = value;
			}
		}

		static public implicit operator Func<Real, Real[]>(Function f) {
			return f.logic;
		}

		static public implicit operator Function(Func<Real, Real[]> fc)
		{
			Function r = new Function();
			r.logic = fc;
			return r;
		}

		


        

        public PositiveInteger parametersCount {
            get {
				
				return (PositiveInteger)(this["parametersCount"]); 
			}
			set {
				this["parametersCount"]=value;
			}
        }

		public Real PartialDerivative(Real[] x0,NonnegativeInteger[] sample) {
			return new PartialDerivative(this, x0, sample);//will check whether x0.length=f.parametersCount and sample's digits within x0.length.
		}

		/// <summary>
		/// Note: f(,) has two parameters.
		/// f's parameters count is unknown.
		/// f() or f(.) has only one parameters.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string seperator=",";
			string r = this.name + "(";
			for (uint i = 0; i < (int)parametersCount;i++ ) {
				r += ",";
			}
			r = r.Remove(r.Length - seperator.Length);
			r += ")";
			return r;

		}


    }
}
