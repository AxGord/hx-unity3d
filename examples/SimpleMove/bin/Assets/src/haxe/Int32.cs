
namespace haxe
{
	public  class Int32 
	{
		public static   int make(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ( a << 16 ) | b )) );
			}
		}
		
		
		public static   int ofInt(int x)
		{
			unchecked 
			{
				return ((int) (x) );
			}
		}
		
		
		public static   int toInt(int x)
		{
			unchecked 
			{
				if (( (( ( ((int) (x) ) >> 30 ) & 1 )) != ((int) (( ((uint) (((int) (x) )) ) >> 31 )) ) )) 
				{
					throw haxe.lang.HaxeException.wrap(haxe.lang.Runtime.concat("Overflow ", Std.@string(x)));
				}
				
				return ((int) (x) );
			}
		}
		
		
		public static   int @add(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) + ((int) (b) ) )) );
			}
		}
		
		
		public static   int sub(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) - ((int) (b) ) )) );
			}
		}
		
		
		public static   int mul(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) * ((int) (b) ) )) );
			}
		}
		
		
		public static   int div(int a, int b)
		{
			unchecked 
			{
				return ( ((int) (a) ) / ((int) (b) ) );
			}
		}
		
		
		public static   int mod(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) % ((int) (b) ) )) );
			}
		}
		
		
		public static   int shl(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) << b )) );
			}
		}
		
		
		public static   int shr(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) >> b )) );
			}
		}
		
		
		public static   int ushr(int a, int b)
		{
			unchecked 
			{
				return ((int) (((int) (( ((uint) (((int) (a) )) ) >> b )) )) );
			}
		}
		
		
		public static   int and(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) & ((int) (b) ) )) );
			}
		}
		
		
		public static   int or(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) | ((int) (b) ) )) );
			}
		}
		
		
		public static   int xor(int a, int b)
		{
			unchecked 
			{
				return ((int) (( ((int) (a) ) ^ ((int) (b) ) )) );
			}
		}
		
		
		public static   int neg(int a)
		{
			unchecked 
			{
				return ((int) ( - (((int) (a) )) ) );
			}
		}
		
		
		public static   int complement(int a)
		{
			unchecked 
			{
				return ((int) ( ~ (((int) (a) )) ) );
			}
		}
		
		
		public static   int compare(int a, int b)
		{
			unchecked 
			{
				return ( ((int) (a) ) - ((int) (b) ) );
			}
		}
		
		
		public static   bool isNeg(int a)
		{
			unchecked 
			{
				return ( ((int) (a) ) < 0 );
			}
		}
		
		
		public static   bool isZero(int a)
		{
			unchecked 
			{
				return ( ((int) (a) ) == 0 );
			}
		}
		
		
		public static   int ucompare(int a, int b)
		{
			unchecked 
			{
				uint ua = ((uint) (a) );
				uint ub = ((uint) (b) );
				return ( (( ua < ub )) ? (-1) : (( (( ua > ub )) ? (1) : (0) )) );
			}
		}
		
		
		public static   int toNativeInt(int a)
		{
			unchecked 
			{
				return ((int) (a) );
			}
		}
		
		
	}
}


