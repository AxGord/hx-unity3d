
namespace haxe.lang
{
	public  interface IHxObject 
	{
		   double __hx_setField_f(string field, int hash, double @value, bool handleProperties);
		
		   object __hx_setField(string field, int hash, object @value, bool handleProperties);
		
		   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties);
		
		   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties);
		
		   object __hx_invokeField(string field, int hash, Array dynargs);
		
		   bool __hx_deleteField(string field, int hash);
		
		   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		   double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		   object __hx_lookupSetField(string field, int hash, object @value);
		
		   double __hx_lookupSetField_f(string field, int hash, double @value);
		
		   void __hx_getFields(Array<object> baseArr);
		
	}
}



namespace haxe.lang
{
	public  class HxObject : haxe.lang.IHxObject 
	{
		public    HxObject() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.HxObject(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.HxObject();
			}
		}
		
		
		public    HxObject(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					default:
					{
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
					default:
					{
						return ((haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
			}
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				if (isCheck) 
				{
					return haxe.lang.Runtime.undefined;
				}
				 else 
				{
					if (throwErrors) 
					{
						throw haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else 
					{
						return default(object);
					}
					
				}
				
			}
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				if (throwErrors) 
				{
					throw haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else 
				{
					return default(double);
				}
				
			}
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				throw haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				throw haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
		}
		
		
		public virtual   void __hx_getFields(Array<object> baseArr)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class DynamicObject : haxe.lang.HxObject 
	{
		public    DynamicObject() : base()
		{
			unchecked 
			{
				haxe.lang.DynamicObject.__hx_ctor(this);
			}
		}
		
		
		public static   void __hx_ctor(haxe.lang.DynamicObject __temp_me12)
		{
			unchecked 
			{
				object __temp_expr31 = default(object);
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.DynamicObject(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.DynamicObject();
			}
		}
		
		
		public    DynamicObject(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    DynamicObject(Array<int> __hx_hashes, Array<object> __hx_dynamics, Array<int> __hx_hashes_f, Array<double> __hx_dynamics_f)
		{
			unchecked 
			{
				this.__hx_hashes = __hx_hashes;
				this.__hx_dynamics = __hx_dynamics;
				this.__hx_hashes_f = __hx_hashes_f;
				this.__hx_dynamics_f = __hx_dynamics_f;
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				haxe.lang.Function ts = ((haxe.lang.Function) (haxe.lang.Runtime.getField(this, "toString", 946786476, false)) );
				if (( ts != default(haxe.lang.Function) )) 
				{
					return haxe.lang.Runtime.toString(ts.__hx_invoke0_o());
				}
				
				StringBuf ret = new StringBuf();
				ret.b.Append(Std.@string("{"));
				bool first = true;
				{
					int _g = 0;
					Array<object> _g1 = Reflect.fields(this);
					while (( _g < _g1.length ))
					{
						string f = haxe.lang.Runtime.toString(_g1[_g]);
						 ++ _g;
						if (first) 
						{
							first = false;
						}
						 else 
						{
							ret.b.Append(Std.@string(","));
						}
						
						ret.b.Append(Std.@string(" "));
						ret.b.Append(Std.@string(f));
						ret.b.Append(Std.@string(" : "));
						ret.b.Append(Std.@string(Reflect.field(this, f)));
					}
					
				}
				
				if ( ! (first) ) 
				{
					ret.b.Append(Std.@string(" "));
				}
				
				ret.b.Append(Std.@string("}"));
				return ret.toString();
			}
		}
		
		
		public override   bool __hx_deleteField(string field, int hash)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					this.__hx_hashes.splice(res, 1);
					this.__hx_dynamics.splice(res, 1);
					return true;
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						this.__hx_hashes_f.splice(res, 1);
						this.__hx_dynamics_f.splice(res, 1);
						return true;
					}
					
				}
				
				return false;
			}
		}
		
		
		public  Array<int> __hx_hashes = new Array<int>(new int[]{});
		
		public  Array<object> __hx_dynamics = new Array<object>(new object[]{});
		
		public  Array<int> __hx_hashes_f = new Array<int>(new int[]{});
		
		public  Array<double> __hx_dynamics_f = new Array<double>(new double[]{});
		
		public override   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics[res];
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						return this.__hx_dynamics_f[res];
					}
					
				}
				
				if (isCheck) 
				{
					return haxe.lang.Runtime.undefined;
				}
				 else 
				{
					return default(object);
				}
				
			}
		}
		
		
		public override   double __hx_lookupField_f(string field, int hash, bool throwErrors)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics_f[res];
				}
				 else 
				{
					res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
					if (( res >= 0 )) 
					{
						return haxe.lang.Runtime.toDouble(this.__hx_dynamics[res]);
					}
					
				}
				
				return default(double);
			}
		}
		
		
		public override   object __hx_lookupSetField(string field, int hash, object @value)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics[res] = ((object) (@value) );
				}
				 else 
				{
					int res2 = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
					if (( res >= 0 )) 
					{
						this.__hx_hashes_f.splice(res2, 1);
						this.__hx_dynamics_f.splice(res2, 1);
					}
					
				}
				
				this.__hx_hashes.insert( ~ (res) , hash);
				this.__hx_dynamics.insert( ~ (res) , ((object) (@value) ));
				return @value;
			}
		}
		
		
		public override   double __hx_lookupSetField_f(string field, int hash, double @value)
		{
			unchecked 
			{
				int res = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f);
				if (( res >= 0 )) 
				{
					return this.__hx_dynamics_f[res] = @value;
				}
				 else 
				{
					int res2 = haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes);
					if (( res >= 0 )) 
					{
						this.__hx_hashes.splice(res2, 1);
						this.__hx_dynamics.splice(res2, 1);
					}
					
				}
				
				this.__hx_hashes_f.insert( ~ (res) , hash);
				this.__hx_dynamics_f.insert( ~ (res) , @value);
				return @value;
			}
		}
		
		
		public override   void __hx_getFields(Array<object> baseArr)
		{
			unchecked 
			{
				{
					{
						object __temp_iterator18 = this.__hx_hashes.iterator();
						while (((bool) (haxe.lang.Runtime.callField(__temp_iterator18, "hasNext", 407283053, default(Array))) ))
						{
							int __temp_field14 = haxe.lang.Runtime.toInt(haxe.lang.Runtime.callField(__temp_iterator18, "next", 1224901875, default(Array)));
							baseArr.push(haxe.lang.FieldLookup.lookupHash(__temp_field14));
						}
						
					}
					
					{
						object __temp_iterator19 = this.__hx_hashes_f.iterator();
						while (((bool) (haxe.lang.Runtime.callField(__temp_iterator19, "hasNext", 407283053, default(Array))) ))
						{
							int __temp_field13 = haxe.lang.Runtime.toInt(haxe.lang.Runtime.callField(__temp_iterator19, "next", 1224901875, default(Array)));
							baseArr.push(haxe.lang.FieldLookup.lookupHash(__temp_field13));
						}
						
					}
					
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}



namespace haxe.lang
{
	public  interface IGenericObject : haxe.lang.IHxObject 
	{
	}
}



namespace haxe.lang
{
	public  class Enum : haxe.lang.HxObject 
	{
		public    Enum(int index, Array<object> @params)
		{
			unchecked 
			{
				this.index = index;
				this.@params = @params;
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new haxe.lang.Enum(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new haxe.lang.Enum(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
			}
		}
		
		
		public    Enum(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
		public override   bool Equals(object obj)
		{
			unchecked 
			{
				if (haxe.lang.Runtime.eq(obj, this)) 
				{
					return true;
				}
				
				haxe.lang.Enum obj1 = ((haxe.lang.Enum) (obj) );
				bool ret = ( ( ( obj1 != default(haxe.lang.Enum) ) && Std.@is(obj1, Type.getClass<object>(this)) ) && ( obj1.index == this.index ) );
				if ( ! (ret) ) 
				{
					return false;
				}
				
				if (( obj1.@params == this.@params )) 
				{
					return true;
				}
				
				int len = 0;
				if (( ( ( obj1.@params == default(Array<object>) ) || ( this.@params == default(Array<object>) ) ) || ( (len = this.@params.length) != obj1.@params.length ) )) 
				{
					return false;
				}
				
				{
					int _g = 0;
					while (( _g < len ))
					{
						int i = _g++;
						if ( ! (Type.enumEq<object>(obj1.@params[i], this.@params[i])) ) 
						{
							return false;
						}
						
					}
					
				}
				
				return true;
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				if (( this.@params == default(Array<object>) )) 
				{
					return this.getTag();
				}
				
				StringBuf ret = new StringBuf();
				ret.b.Append(Std.@string(this.getTag()));
				ret.b.Append(Std.@string("("));
				bool first = true;
				{
					int _g = 0;
					Array<object> _g1 = this.@params;
					while (( _g < _g1.length ))
					{
						object p = _g1[_g];
						 ++ _g;
						if (first) 
						{
							first = false;
						}
						 else 
						{
							ret.b.Append(Std.@string(","));
						}
						
						ret.b.Append(Std.@string(p));
					}
					
				}
				
				ret.b.Append(Std.@string(")"));
				return ret.toString();
			}
		}
		
		
		public   string getTag()
		{
			unchecked 
			{
				object cl = Type.getClass<object>(this);
				return haxe.lang.Runtime.toString(haxe.lang.Runtime.callField(haxe.lang.Runtime.getField(cl, "constructs", 1744813180, true), "__get", 1915412854, new Array<object>(new object[]{this.index})));
			}
		}
		
		
		public readonly Array<object> @params;
		
		public readonly int index;
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1041537810:
					{
						return this.index;
					}
					
					
					case 1836776262:
					{
						return this.@params;
					}
					
					
					case 589796196:
					{
						return new haxe.lang.Closure(this, "getTag", 589796196);
					}
					
					
					case 946786476:
					{
						return new haxe.lang.Closure(this, "toString", 946786476);
					}
					
					
					case 1955029599:
					{
						return new haxe.lang.Closure(this, "Equals", 1955029599);
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
					case 1041537810:
					{
						return this.index;
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
					case 589796196:
					{
						return this.getTag();
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1955029599:
					{
						return this.Equals(dynargs[0]);
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
				baseArr.push("index");
				baseArr.push("params");
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
}


