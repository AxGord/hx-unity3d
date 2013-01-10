
public  class IntIter : haxe.lang.HxObject 
{
	public    IntIter(int min, int max) : base()
	{
		unchecked 
		{
			IntIter.__hx_ctor(this, min, max);
		}
	}
	
	
	public static   void __hx_ctor(IntIter __temp_me9, int min, int max)
	{
		unchecked 
		{
			__temp_me9.min = min;
			__temp_me9.max = max;
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new IntIter(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new IntIter(haxe.lang.Runtime.toInt(arr[0]), haxe.lang.Runtime.toInt(arr[1]));
		}
	}
	
	
	public    IntIter(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	public virtual   int next()
	{
		unchecked 
		{
			return this.min++;
		}
	}
	
	
	public virtual   bool hasNext()
	{
		unchecked 
		{
			return ( this.min < this.max );
		}
	}
	
	
	public  int max;
	
	public  int min;
	
	public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 5443986:
				{
					return this.min = ((int) (@value) );
				}
				
				
				case 5442212:
				{
					return this.max = ((int) (@value) );
				}
				
				
				default:
				{
					return base.__hx_setField_f(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 5443986:
				{
					return this.min = haxe.lang.Runtime.toInt(@value);
				}
				
				
				case 5442212:
				{
					return this.max = haxe.lang.Runtime.toInt(@value);
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
				case 5443986:
				{
					return this.min;
				}
				
				
				case 5442212:
				{
					return this.max;
				}
				
				
				case 407283053:
				{
					return new haxe.lang.Closure(this, "hasNext", 407283053);
				}
				
				
				case 1224901875:
				{
					return new haxe.lang.Closure(this, "next", 1224901875);
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 5443986:
				{
					return this.min;
				}
				
				
				case 5442212:
				{
					return this.max;
				}
				
				
				default:
				{
					return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
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
				case 407283053:
				{
					return this.hasNext();
				}
				
				
				case 1224901875:
				{
					return this.next();
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
			baseArr.push("min");
			baseArr.push("max");
			{
				base.__hx_getFields(baseArr);
			}
			
		}
	}
	
	
}


