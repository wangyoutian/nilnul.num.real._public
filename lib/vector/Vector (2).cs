using System;

namespace math
{

	public class Vector{
		public double[] components;
		public bool transposed=false;
//		public Vector(double[] a){
//			this.components=a;
//			this.transposed=false;
//		}
		public override string ToString(){
			string r="";
			r+="Vector{";
			for(int i=0;i<this.components.Length;i++){
				r+=this.components[i];
				if(i<this.components.Length-1){
					r+=",";
				}
			}
			
			r+="}";
			return r;
		}
		public Vector(double[] a,bool t)
		{
			this.components=a;
			this.transposed=t;
		}

		public Vector(params double[] a)
		{
			this.components=a;
		}
		public static double operator *(Vector v1, Vector v2){
			if(v1.transposed==false){
				throw new Exception("Error for given v1 is a column vector or v2 is a row vector or v1.len!=v2.len");
			}
			if(v2.transposed==true){
				throw new Exception("v2 shouldnot be a row vector.");
			}
			if(v1.components.Length!=v2.components.Length){
				throw new Exception("two vectors lenth not equal.");
			}
										 
			double t=0;
			for(int i=0;i<v1.components.Length;i++){
				t+= (v1.components[i]*v2.components[i]);
			}
			return t;
		}
		public void transpose(){
			this.transposed=!this.transposed;
		}
	}
}
