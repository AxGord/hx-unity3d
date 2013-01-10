
public  class StringTools : haxe.lang.HxObject 
{
	public    StringTools() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   string urlEncode(string s)
	{
		unchecked 
		{
			return System.Uri.EscapeUriString(s);
		}
	}
	
	
	public static   string urlDecode(string s)
	{
		unchecked 
		{
			return System.Uri.UnescapeDataString(s);
		}
	}
	
	
	public static   string htmlEscape(string s)
	{
		unchecked 
		{
			return haxe.lang.StringExt.split(haxe.lang.StringExt.split(haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
		}
	}
	
	
	public static   string htmlUnescape(string s)
	{
		unchecked 
		{
			return haxe.lang.StringExt.split(haxe.lang.StringExt.split(haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&amp;").@join("&");
		}
	}
	
	
	public static   bool startsWith(string s, string start)
	{
		unchecked 
		{
			return s.StartsWith(start);
		}
	}
	
	
	public static   bool endsWith(string s, string end)
	{
		unchecked 
		{
			return s.EndsWith(end);
		}
	}
	
	
	public static   bool isSpace(string s, int pos)
	{
		unchecked 
		{
			haxe.lang.Null<int> c = haxe.lang.StringExt.charCodeAt(s, pos);
			return ( ( ( c.@value >= 9 ) && ( c.@value <= 13 ) ) || haxe.lang.Runtime.eq((c).toDynamic(), 32) );
		}
	}
	
	
	public static   string ltrim(string s)
	{
		unchecked 
		{
			return s.TrimStart();
		}
	}
	
	
	public static   string rtrim(string s)
	{
		unchecked 
		{
			return s.TrimEnd();
		}
	}
	
	
	public static   string trim(string s)
	{
		unchecked 
		{
			return haxe.lang.Runtime.toString(haxe.lang.Runtime.callField(s, "Trim", 937216258, default(Array)));
		}
	}
	
	
	public static   string rpad(string s, string c, int l)
	{
		unchecked 
		{
			int sl = s.Length;
			int cl = c.Length;
			while (( sl < l ))
			{
				if (( ( l - sl ) < cl )) 
				{
					s = haxe.lang.Runtime.concat(s, haxe.lang.StringExt.substr(c, 0, new haxe.lang.Null<int>(( l - sl ), true)));
					sl = l;
				}
				 else 
				{
					s = haxe.lang.Runtime.concat(s, c);
					sl += cl;
				}
				
			}
			
			return s;
		}
	}
	
	
	public static   string lpad(string s, string c, int l)
	{
		unchecked 
		{
			string ns = "";
			int sl = s.Length;
			if (( sl >= l )) 
			{
				return s;
			}
			
			int cl = c.Length;
			while (( sl < l ))
			{
				if (( ( l - sl ) < cl )) 
				{
					ns = haxe.lang.Runtime.concat(ns, haxe.lang.StringExt.substr(c, 0, new haxe.lang.Null<int>(( l - sl ), true)));
					sl = l;
				}
				 else 
				{
					ns = haxe.lang.Runtime.concat(ns, c);
					sl += cl;
				}
				
			}
			
			return haxe.lang.Runtime.concat(ns, s);
		}
	}
	
	
	public static   string replace(string s, string sub, string @by)
	{
		unchecked 
		{
			return s.Replace(sub, @by);
		}
	}
	
	
	public static   string hex(int n, haxe.lang.Null<int> digits)
	{
		unchecked 
		{
			string s = "";
			string hexChars = "0123456789ABCDEF";
			do 
			{
				s = haxe.lang.Runtime.concat(haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
				n = ((int) (( ((uint) (n) ) >> 4 )) );
			}
			while (( n > 0 ));
			if (( ! ( ! (digits.hasValue) ) )) 
			{
				while (( s.Length < digits.@value ))
				{
					s = haxe.lang.Runtime.concat("0", s);
				}
				
			}
			
			return s;
		}
	}
	
	
	public static   int fastCodeAt(string s, int index)
	{
		unchecked 
		{
			return ( (( ((uint) (index) ) < s.Length )) ? (haxe.lang.Runtime.toInt(s[index])) : (-1) );
		}
	}
	
	
	public static   bool isEOF(int c)
	{
		unchecked 
		{
			return ( c == -1 );
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new StringTools(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new StringTools();
		}
	}
	
	
	public    StringTools(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
}


