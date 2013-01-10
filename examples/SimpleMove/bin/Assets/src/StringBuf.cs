
public  class StringBuf : haxe.lang.HxObject 
{
	public    StringBuf() : base()
	{
		unchecked 
		{
			StringBuf.__hx_ctor(this);
		}
	}
	
	
	public static   void __hx_ctor(StringBuf __temp_me10)
	{
		unchecked 
		{
			__temp_me10.b = new System.Text.StringBuilder();
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new StringBuf(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new StringBuf();
		}
	}
	
	
	public    StringBuf(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	public virtual   string toString()
	{
		unchecked 
		{
			return this.b.ToString();
		}
	}
	
	
	public   void addChar(int c)
	{
		unchecked 
		{
			this.b.Append(((char) (c) ));
		}
	}
	
	
	public virtual   void addSub(string s, int pos, haxe.lang.Null<int> len)
	{
		unchecked 
		{
			int l = ( ( ! (len.hasValue) ) ? (new haxe.lang.Null<int>(( s.Length - pos ), true)) : (len) ).@value;
			this.b.Append(s, pos, l);
		}
	}
	
	
	public   void @add(object x)
	{
		unchecked 
		{
			this.b.Append(Std.@string(x));
		}
	}
	
	
	public  System.Text.StringBuilder b;
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 98:
				{
					return this.b = ((System.Text.StringBuilder) (@value) );
				}
				
				
				default:
				{
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 98:
				{
					return this.b;
				}
				
				
				case 4846113:
				{
					return new haxe.lang.Closure(this, "add", 4846113);
				}
				
				
				case 520665567:
				{
					return new haxe.lang.Closure(this, "addSub", 520665567);
				}
				
				
				case 2113708439:
				{
					return new haxe.lang.Closure(this, "addChar", 2113708439);
				}
				
				
				case 946786476:
				{
					return new haxe.lang.Closure(this, "toString", 946786476);
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_invokeField(string field, int hash, Array dynargs)
	{
		unchecked 
		{
			switch (hash)
			{
				case 4846113:
				{
					this.@add(dynargs[0]);
					return default(object);
				}
				
				
				case 520665567:
				{
					this.addSub(haxe.lang.Runtime.toString(dynargs[0]), haxe.lang.Runtime.toInt(dynargs[1]), haxe.lang.Null<object>.ofDynamic<int>(dynargs[2]));
					return default(object);
				}
				
				
				case 2113708439:
				{
					this.addChar(haxe.lang.Runtime.toInt(dynargs[0]));
					return default(object);
				}
				
				
				case 946786476:
				{
					return this.toString();
				}
				
				
				default:
				{
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
		}
	}
	
	
	public override   void __hx_getFields(Array<object> baseArr)
	{
		unchecked 
		{
			baseArr.push("b");
			{
				base.__hx_getFields(baseArr);
			}
			
		}
	}
	
	
	public override string ToString()
	{
		return this.toString();
	}
	
	
}


