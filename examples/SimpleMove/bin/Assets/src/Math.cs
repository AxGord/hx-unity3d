
public  class Math 
{
	static Math() 
	{
		{
			Math.PI = System.Math.PI;
			Math.NaN = double.NaN;
			Math.NEGATIVE_INFINITY = double.NegativeInfinity;
			Math.POSITIVE_INFINITY = double.PositiveInfinity;
			Math.rand = new System.Random();
		}
		
	}
	public static  System.Random rand;
	
	public static  double PI;
	
	public static  double NaN;
	
	public static  double NEGATIVE_INFINITY;
	
	public static  double POSITIVE_INFINITY;
	
	public static   double abs(double v)
	{
		unchecked 
		{
			return System.Math.Abs(v);
		}
	}
	
	
	public static   double min(double a, double b)
	{
		unchecked 
		{
			return ( (( a < b )) ? (a) : (b) );
		}
	}
	
	
	public static   double max(double a, double b)
	{
		unchecked 
		{
			return ( (( a > b )) ? (a) : (b) );
		}
	}
	
	
	public static   double sin(double v)
	{
		unchecked 
		{
			return System.Math.Sin(v);
		}
	}
	
	
	public static   double cos(double v)
	{
		unchecked 
		{
			return System.Math.Cos(v);
		}
	}
	
	
	public static   double atan2(double y, double x)
	{
		unchecked 
		{
			return System.Math.Atan2(y, x);
		}
	}
	
	
	public static   double tan(double v)
	{
		unchecked 
		{
			return System.Math.Tan(v);
		}
	}
	
	
	public static   double exp(double v)
	{
		unchecked 
		{
			return System.Math.Exp(v);
		}
	}
	
	
	public static   double log(double v)
	{
		unchecked 
		{
			return System.Math.Log(v);
		}
	}
	
	
	public static   double sqrt(double v)
	{
		unchecked 
		{
			return System.Math.Sqrt(v);
		}
	}
	
	
	public static   int round(double v)
	{
		unchecked 
		{
			int vint = ((int) (v) );
			double dec = ( v - vint );
			if (( ( dec >= 1 ) || ( dec <= -1 ) )) 
			{
				return vint;
			}
			
			if (( dec >= .5 )) 
			{
				return ( vint + 1 );
			}
			
			if (( dec < -.5 )) 
			{
				return ( vint - 1 );
			}
			
			return vint;
		}
	}
	
	
	public static   int floor(double v)
	{
		unchecked 
		{
			return ((int) (System.Math.Floor(v)) );
		}
	}
	
	
	public static   int ceil(double v)
	{
		unchecked 
		{
			return ((int) (System.Math.Ceiling(v)) );
		}
	}
	
	
	public static   double atan(double v)
	{
		unchecked 
		{
			return System.Math.Atan(v);
		}
	}
	
	
	public static   double asin(double v)
	{
		unchecked 
		{
			return System.Math.Asin(v);
		}
	}
	
	
	public static   double acos(double v)
	{
		unchecked 
		{
			return System.Math.Acos(v);
		}
	}
	
	
	public static   double pow(double v, double exp)
	{
		unchecked 
		{
			return System.Math.Pow(v, exp);
		}
	}
	
	
	public static   double random()
	{
		unchecked 
		{
			return Math.rand.NextDouble();
		}
	}
	
	
	public static   bool isFinite(double f)
	{
		unchecked 
		{
			return !double.IsInfinity(f);
		}
	}
	
	
	public static   bool isNaN(double f)
	{
		unchecked 
		{
			return double.IsNaN(f);
		}
	}
	
	
}


