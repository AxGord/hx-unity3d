
namespace haxe.lang
{
	public  class StringExt 
	{
		public static   string charAt(string me, int index)
		{
						if ( ((uint) index) >= me.Length)				return null;			else				return new string(me[index], 1);	
		}
		
		
		public static   haxe.lang.Null<int> charCodeAt(string me, int index)
		{
						if ( ((uint) index) >= me.Length)				return default(haxe.lang.Null<int>);			else				return new haxe.lang.Null<int>((int)me[index], true);	
		}
		
		
		public static   int indexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
						uint sIndex = (startIndex.hasValue) ? ((uint) startIndex.@value) : 0;			if (sIndex >= me.Length)				return -1;			return me.IndexOf(str, (int)sIndex);	
		}
		
		
		public static   int lastIndexOf(string me, string str, haxe.lang.Null<int> startIndex)
		{
						int sIndex = (startIndex.hasValue) ? (startIndex.@value) : (me.Length - 1);			if (sIndex > me.Length)				sIndex = me.Length - 1;			else if (sIndex < 0)				return -1;			return me.LastIndexOf(str, sIndex);	
		}
		
		
		public static   Array<object> split(string me, string delimiter)
		{
						string[] native;			if (delimiter.Length == 0)			{				int len = me.Length;				native = new string[len];				for (int i = 0; i < len; i++)					native[i] = new string(me[i], 1);			} else {				native = me.Split(new string[] { delimiter }, System.StringSplitOptions.None);			}			return new Array<object>(native);	
		}
		
		
		public static   string substr(string me, int pos, haxe.lang.Null<int> len)
		{
						int meLen = me.Length;			int targetLen = meLen;			if (len.hasValue)			{				targetLen = len.@value;				if (targetLen == 0)					return "";				if( pos != 0 && targetLen < 0 ){					return "";				}			}						if( pos < 0 ){				pos = meLen + pos;				if( pos < 0 ) pos = 0;			} else if( targetLen < 0 ){				targetLen = meLen + targetLen - pos;			}			if( pos + targetLen > meLen ){				targetLen = meLen - pos;			}			if ( pos < 0 || targetLen <= 0 ) return "";						return me.Substring(pos, targetLen);	
		}
		
		
		public static   string substring(string me, int startIndex, haxe.lang.Null<int> endIndex)
		{
					int endIdx;		int len = me.Length;		if ( !endIndex.hasValue ) {			endIdx = len;		} else if ( (endIdx = endIndex.@value) < 0 ) {			endIdx = 0;		} else if ( endIdx > len ) {			endIdx = len;		}				if ( startIndex < 0 ) {			startIndex = 0;		} else if ( startIndex > len ) {			startIndex = len;		}				if ( startIndex > endIdx ) {			int tmp = startIndex;			startIndex = endIdx;			endIdx = tmp;		}				return me.Substring(startIndex, endIdx - startIndex);	
		}
		
		
		public static   string toLowerCase(string me)
		{
						return me.ToLower();	
		}
		
		
		public static   string toUpperCase(string me)
		{
						return me.ToUpper();	
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
						return new string( (char) code, 1 );	
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


