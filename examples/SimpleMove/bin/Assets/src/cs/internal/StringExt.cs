
namespace haxe.lang
{
	public  class StringExt 
	{
		public static   string charAt(string me, int index)
		{
			
		}
		
		
		public static   haxe.lang.Null<int> charCodeAt(string me, int index)
		{
			
		}
		
		
		public static   int indexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
			
		}
		
		
		public static   int lastIndexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
			
		}
		
		
		public static   Array<object> split(string me, string delimiter)
		{
			
		}
		
		
		public static   string substr(string me, int pos, haxe.lang.Null<int> len)
		{
			
		}
		
		
		public static   string substring(string me, int startIndex, haxe.lang.Null<int> endIndex)
		{
			
		}
		
		
		public static   string toLowerCase(string me)
		{
			
		}
		
		
		public static   string toUpperCase(string me)
		{
			
		}
		
		
		public static   string toNativeString(string me)
		{
			unchecked 
			{
				return me;
			}
		}
		
		
		public static   string fromCharCode(int code)
		{
			
		}
		
		
	}
}



namespace haxe.lang
{
	public  class StringRefl 
	{
		static StringRefl() 
		{
			haxe.lang.StringRefl.fields = new Array<object>(new object[]{"length", "toUpperCase", "toLowerCase", "charAt", "charCodeAt", "indexOf", "lastIndexOf", "split", "substr", "substring"});
		}
		public static  Array<object> fields;
		
		public static   object handleGetField(string str, string f, bool throwErrors)
		{
			unchecked 
			{
				switch (f)
				{
					case "length":
					{
						return str.Length;
					}
					
					
					case "toUpperCase":case "toLowerCase":case "charAt":case "charCodeAt":case "indexOf":case "lastIndexOf":case "split":case "substr":case "substring":
					{
						return new haxe.lang.Closure(str, f, 0);
					}
					
					
					default:
					{
						if (throwErrors) 
						{
							throw haxe.lang.HaxeException.wrap(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat("Field not found: \'", f), "\' in String"));
						}
						 else 
						{
							return default(object);
						}
						
					}
					
				}
				
			}
		}
		
		
		public static   object handleCallField(string str, string f, Array args)
		{
			unchecked 
			{
				Array _args = new Array<object>(new object[]{str});
				if (( args == default(Array) )) 
				{
					args = _args;
				}
				 else 
				{
					args = ((Array) (haxe.lang.Runtime.callField(_args, "concat", 1204816148, new Array<object>(new object[]{args}))) );
				}
				
				return haxe.lang.Runtime.slowCallField(typeof(haxe.lang.StringExt), f, args);
			}
		}
		
		
	}
}

