
namespace cs
{
	public  class Lib : haxe.lang.HxObject 
	{
		public    Lib() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  string decimalSeparator;
		
		public static   void applyCultureChanges()
		{
			
			System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name, true);
			decimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
            ci.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
	
		}
		
		
		public static   void revertDefaultCulture()
		{
			
		System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name, true);
		System.Threading.Thread.CurrentThread.CurrentCulture = ci;
	
		}
		
		
		public static   T[] nativeArray<T>(Array<T> arr, bool equalLengthRequired)
		{
			unchecked 
			{
				T[] native = arr.__a;
				int len = arr.length;
				if ((  ! (equalLengthRequired)  || ( native.Length == len ) )) 
				{
					return native;
				}
				 else 
				{
					T[] ret = new T[len];
					System.Array.Copy(native, 0, ret, 0, len);
					return ret;
				}
				
			}
		}
		
		
		public static   System.Type fromNativeType(System.Type t)
		{
			unchecked 
			{
				return t;
			}
		}
		
		
		public static   System.Type toNativeType(System.Type cl)
		{
			unchecked 
			{
				return cl;
			}
		}
		
		
		public static   System.Type nativeType(object obj)
		{
			unchecked 
			{
				return obj.GetType();
			}
		}
		
		
		public static   Array<T> array<T>(T[] native)
		{
			unchecked 
			{
				return Array<object>.ofNative<T>(native);
			}
		}
		
		
		public static   Array<T> arrayAlloc<T>(int size)
		{
			unchecked 
			{
				return ((Array<T>) (((Array) (Array<object>.alloc<object>(size)) ).cast<T>()) );
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new cs.Lib(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new cs.Lib();
			}
		}
		
		
		public    Lib(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
	}
}


