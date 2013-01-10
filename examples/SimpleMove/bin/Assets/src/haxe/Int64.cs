
namespace haxe
{
	public  class Int64 
	{
		public static   long make(int high, int low)
		{
			unchecked 
			{
				return ((long) (( ( ((long) (high) ) << 32 ) | ((long) (low) ) )) );
			}
		}
		
		
		public static   long ofInt(int x)
		{
			unchecked 
			{
				return ((long) (x) );
			}
		}
		
		
		public static   long ofInt32(int x)
		{
			unchecked 
			{
				return ((long) (x) );
			}
		}
		
		
		public static   int toInt(long x)
		{
			unchecked 
			{
				return ((int) (x) );
			}
		}
		
		
		public static   int getLow(long x)
		{
			unchecked 
			{
				return ((int) (( ((long) (x) ) & -1 )) );
			}
		}
		
		
		public static   int getHigh(long x)
		{
			unchecked 
			{
				return ((int) (( ((ulong) (x) ) >> 32 )) );
			}
		}
		
		
		public static   long @add(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) + ((long) (b) ) )) );
			}
		}
		
		
		public static   long sub(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) - ((long) (b) ) )) );
			}
		}
		
		
		public static   long mul(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) * ((long) (b) ) )) );
			}
		}
		
		
		public static   object divMod(long modulus, long divisor)
		{
			unchecked 
			{
				long q = ( ((long) (modulus) ) / ((long) (divisor) ) );
				long m = ((long) (( ((long) (modulus) ) % ((long) (divisor) ) )) );
				return new haxe.lang.DynamicObject(new Array<int>(new int[]{845179051, 2012934199}), new Array<object>(new object[]{q, m}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
			}
		}
		
		
		public static   long div(long a, long b)
		{
			unchecked 
			{
				return ( ((long) (a) ) / ((long) (b) ) );
			}
		}
		
		
		public static   long mod(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) % ((long) (b) ) )) );
			}
		}
		
		
		public static   long shl(long a, int b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) << b )) );
			}
		}
		
		
		public static   long shr(long a, int b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) >> b )) );
			}
		}
		
		
		public static   long ushr(long a, int b)
		{
			unchecked 
			{
				return ((long) (( ((ulong) (a) ) >> b )) );
			}
		}
		
		
		public static   long and(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) & ((long) (b) ) )) );
			}
		}
		
		
		public static   long or(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) | ((long) (b) ) )) );
			}
		}
		
		
		public static   long xor(long a, long b)
		{
			unchecked 
			{
				return ((long) (( ((long) (a) ) ^ ((long) (b) ) )) );
			}
		}
		
		
		public static   long neg(long a)
		{
			unchecked 
			{
				return ((long) ( ~ (((long) (a) )) ) );
			}
		}
		
		
		public static   bool isNeg(long a)
		{
			unchecked 
			{
				return ( ((long) (a) ) < 0 );
			}
		}
		
		
		public static   bool isZero(long a)
		{
			unchecked 
			{
				return ( ((long) (a) ) == 0 );
			}
		}
		
		
		public static   int compare(long a, long b)
		{
			unchecked 
			{
				return ((int) (( ((long) (a) ) - ((long) (b) ) )) );
			}
		}
		
		
		public static   int ucompare(long a, long b)
		{
			unchecked 
			{
				if (( ((long) (a) ) < 0 )) 
				{
					return ( (( ((long) (b) ) < 0 )) ? (((int) (( ((long) ( ~ (((long) (a) )) ) ) - ((long) ( ~ (((long) (b) )) ) ) )) )) : (1) );
				}
				
				return ( (( ((long) (b) ) < 0 )) ? (-1) : (((int) (( ((long) (a) ) - ((long) (b) ) )) )) );
			}
		}
		
		
		public static   string toStr(long a)
		{
			unchecked 
			{
				return haxe.lang.Runtime.concat(Std.@string(a), "");
			}
		}
		
		
	}
}


