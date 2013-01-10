
namespace haxe
{
	public  class Log : haxe.lang.HxObject 
	{
		static Log() 
		{
			haxe.Log.trace = ( (( haxe.Fun_121b1162.__hx_current != default(haxe.Fun_121b1162) )) ? (haxe.Fun_121b1162.__hx_current) : (haxe.Fun_121b1162.__hx_current = ((haxe.Fun_121b1162) (new haxe.Fun_121b1162()) )) );
			haxe.Log.clear = ( (( haxe.Fun_d41d8cd9.__hx_current != default(haxe.Fun_d41d8cd9) )) ? (haxe.Fun_d41d8cd9.__hx_current) : (haxe.Fun_d41d8cd9.__hx_current = ((haxe.Fun_d41d8cd9) (new haxe.Fun_d41d8cd9()) )) );
		}
		public    Log() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.lang.Function trace;
		
		public static  haxe.lang.Function clear;
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.Log(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.Log();
			}
		}
		
		
		public    Log(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
	}
}



namespace haxe
{
	public  class Fun_121b1162 : haxe.lang.Function 
	{
		public    Fun_121b1162() : base(2, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.Fun_121b1162 __hx_current;
		
		public override   object __hx_invoke2_o(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				object infos = ( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (((object) (__fn_float2) )) : (( (( __fn_dyn2 == null )) ? (default(object)) : (((object) (__fn_dyn2) )) )) );
				object v = ( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				string str = haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.toString(haxe.lang.Runtime.getField(infos, "fileName", 1648581351, true)), ":"), haxe.lang.Runtime.toString(((int) (haxe.lang.Runtime.getField_f(infos, "lineNumber", 1981972957, true)) ))), ": "), Std.@string(v));
				UnityEngine.Debug.Log(str);
				return default(object);
			}
		}
		
		
	}
}



namespace haxe
{
	public  class Fun_d41d8cd9 : haxe.lang.Function 
	{
		public    Fun_d41d8cd9() : base(0, 0)
		{
			unchecked 
			{
			}
		}
		
		
		public static  haxe.Fun_d41d8cd9 __hx_current;
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				{
				}
				
				return default(object);
			}
		}
		
		
	}
}


