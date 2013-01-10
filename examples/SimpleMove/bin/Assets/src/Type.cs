
public  class ValueType : haxe.lang.Enum 
{
	static ValueType() 
	{
		ValueType.constructs = new Array<object>(new object[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"});
		ValueType.TNull = new ValueType(0, default(Array<object>));
		ValueType.TInt = new ValueType(1, default(Array<object>));
		ValueType.TFloat = new ValueType(2, default(Array<object>));
		ValueType.TBool = new ValueType(3, default(Array<object>));
		ValueType.TObject = new ValueType(4, default(Array<object>));
		ValueType.TFunction = new ValueType(5, default(Array<object>));
		ValueType.TUnknown = new ValueType(8, default(Array<object>));
	}
	public    ValueType(int index, Array<object> @params) : base(index, @params)
	{
		unchecked 
		{
			ValueType.__hx_ctor(this, index, @params);
		}
	}
	
	
	public static   void __hx_ctor(ValueType __temp_me11, int index, Array<object> @params)
	{
		unchecked 
		{
			object __temp_expr29 = default(object);
		}
	}
	
	
	public static  Array<object> constructs;
	
	public static  ValueType TNull;
	
	public static  ValueType TInt;
	
	public static  ValueType TFloat;
	
	public static  ValueType TBool;
	
	public static  ValueType TObject;
	
	public static  ValueType TFunction;
	
	public static   ValueType TClass(System.Type c)
	{
		unchecked 
		{
			return new ValueType(6, new Array<object>(new object[]{c}));
		}
	}
	
	
	public static   ValueType TEnum(System.Type e)
	{
		unchecked 
		{
			return new ValueType(7, new Array<object>(new object[]{e}));
		}
	}
	
	
	public static  ValueType TUnknown;
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new ValueType(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new ValueType(haxe.lang.Runtime.toInt(arr[0]), ((Array<object>) (((Array) (arr[1]) ).cast<object>()) ));
		}
	}
	
	
	public    ValueType(haxe.lang.EmptyObject empty) : base(haxe.lang.EmptyObject.EMPTY)
	{
		unchecked 
		{
		}
	}
	
	
}



public  class Type : haxe.lang.HxObject 
{
	public    Type() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   System.Type getClass<T>(T o)
	{
		
		if (o is haxe.lang.DynamicObject || o is System.Type)
			return null;
		
		return o.GetType();
	
	}
	
	
	public static   System.Type getEnum(object o)
	{
		
		if (o is System.Enum || o is haxe.lang.Enum)
			return o.GetType();
		return null;
	
	}
	
	
	public static   System.Type getSuperClass(System.Type c)
	{
		unchecked 
		{
			System.Type t = ((System.Type) (c) );
			System.Type @base = t.BaseType;
			if (( ( haxe.lang.Runtime.typeEq(@base, default(System.Type)) || string.Equals(haxe.lang.Runtime.concat(Std.@string(@base), ""), "haxe.lang.HxObject") ) || string.Equals(haxe.lang.Runtime.concat(Std.@string(@base), ""), "System.Object") )) 
			{
				return default(System.Type);
			}
			
			return ((System.Type) (@base) );
		}
	}
	
	
	public static   string getClassName(System.Type c)
	{
		unchecked 
		{
			string ret = haxe.lang.Runtime.toString(((System.Type) (c) ));
			string __temp_stmt30 = default(string);
			switch (ret)
			{
				case "System.Int32":
				{
					__temp_stmt30 = "Int";
					break;
				}
				
				
				case "System.Double":
				{
					__temp_stmt30 = "Float";
					break;
				}
				
				
				case "System.String":
				{
					__temp_stmt30 = "String";
					break;
				}
				
				
				case "System.Object":
				{
					__temp_stmt30 = "Dynamic";
					break;
				}
				
				
				case "System.Type":
				{
					__temp_stmt30 = "Class";
					break;
				}
				
				
				default:
				{
					__temp_stmt30 = haxe.lang.Runtime.toString(haxe.lang.StringExt.split(ret, "`")[0]);
					break;
				}
				
			}
			
			return __temp_stmt30;
		}
	}
	
	
	public static   string getEnumName(System.Type e)
	{
		unchecked 
		{
			string ret = haxe.lang.Runtime.toString(((System.Type) (e) ));
			if (( ( ret.Length == 14 ) && string.Equals(ret, "System.Boolean") )) 
			{
				return "Bool";
			}
			
			return ret;
		}
	}
	
	
	public static   System.Type resolveClass(string name)
	{
		unchecked 
		{
			System.Type t = System.Type.GetType(name);
			if (haxe.lang.Runtime.typeEq(t, default(System.Type))) 
			{
				switch (name)
				{
					case "Int":
					{
						return ((System.Type) (typeof(int)) );
					}
					
					
					case "Float":
					{
						return ((System.Type) (typeof(double)) );
					}
					
					
					case "Class":
					{
						return ((System.Type) (typeof(System.Type)) );
					}
					
					
					case "String":
					{
						return ((System.Type) (typeof(string)) );
					}
					
					
					case "Dynamic":
					{
						return ((System.Type) (typeof(object)) );
					}
					
					
					default:
					{
						return default(System.Type);
					}
					
				}
				
			}
			 else 
			{
				if (( t.IsInterface && (((System.Type) (typeof(haxe.lang.IGenericObject)) )).IsAssignableFrom(t) )) 
				{
					t = default(System.Type);
					int i = 0;
					string ts = "";
					while (( haxe.lang.Runtime.typeEq(t, default(System.Type)) && ( i < 18 ) ))
					{
						i++;
						ts = haxe.lang.Runtime.concat(ts, haxe.lang.Runtime.concat((( (( i == 1 )) ? ("") : (",") )), "System.Object"));
						t = System.Type.GetType(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(haxe.lang.Runtime.concat(name, "`"), haxe.lang.Runtime.toString(i)), "["), ts), "]"));
					}
					
					return ((System.Type) (t) );
				}
				 else 
				{
					return ((System.Type) (t) );
				}
				
			}
			
		}
	}
	
	
	public static   System.Type resolveEnum(string name)
	{
		unchecked 
		{
			if (string.Equals(name, "Bool")) 
			{
				return ((System.Type) (typeof(bool)) );
			}
			
			return ((System.Type) (Type.resolveClass(name)) );
		}
	}
	
	
	public static   T createInstance<T>(System.Type cl, Array args)
	{
		unchecked 
		{
			System.Type t = ((System.Type) (cl) );
			System.Reflection.ConstructorInfo[] ctors = t.GetConstructors();
			return haxe.lang.Runtime.genericCast<T>(haxe.lang.Runtime.callMethod(default(object), ((System.Reflection.MethodBase[]) (ctors) ), ctors.Length, args));
		}
	}
	
	
	public static   T createEmptyInstance<T>(System.Type cl)
	{
		unchecked 
		{
			if (Reflect.hasField(cl, "__hx_createEmpty")) 
			{
				return haxe.lang.Runtime.genericCast<T>(haxe.lang.Runtime.callField(cl, "__hx_createEmpty", 2084789794, default(Array)));
			}
			
			return Type.createInstance<T>(cl, new Array<object>(new object[]{}));
		}
	}
	
	
	public static   T createEnum<T>(System.Type e, string constr, Array @params)
	{
		
		if (@params == null) 
		{
			object ret = haxe.lang.Runtime.slowGetField(e, constr, false);
			if (ret is haxe.lang.Function)
				throw haxe.lang.HaxeException.wrap("Constructor " + constr + " needs parameters");
			return (T) ret;
		} else {
			return (T) haxe.lang.Runtime.slowCallField(e, constr, @params);
		}
	
	}
	
	
	public static   T createEnumIndex<T>(System.Type e, int index, Array @params)
	{
		unchecked 
		{
			Array<object> constr = Type.getEnumConstructs(e);
			return Type.createEnum<T>(e, haxe.lang.Runtime.toString(constr[index]), @params);
		}
	}
	
	
	public static   Array<object> getInstanceFields(System.Type c)
	{
		
		if (c == typeof(string))
		{
			return haxe.lang.StringRefl.fields;
		}
		
		Array<object> ret = new Array<object>();

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Instance);
        for (int i = 0; i < mis.Length; i++)
        {
			if (mis[i] is System.Reflection.PropertyInfo)
                continue;
			string n = mis[i].Name;
			if (!n.StartsWith("__hx_") && n[0] != '.')
				ret.push(mis[i].Name);
        }

		return ret;
	
	}
	
	
	public static   Array<object> getClassFields(System.Type c)
	{
		
		Array<object> ret = new Array<object>();
		
		if (c == typeof(string))
		{
			ret.push("fromCharCode");
			return ret;
		}

        System.Reflection.MemberInfo[] mis = c.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        for (int i = 0; i < mis.Length; i++)
        {
            string n = mis[i].Name;
			if (!n.StartsWith("__hx_"))
				ret.push(mis[i].Name);
        }

        return ret;
	
	}
	
	
	public static   Array<object> getEnumConstructs(System.Type e)
	{
		unchecked 
		{
			if (Reflect.hasField(e, "constructs")) 
			{
				return ((Array<object>) (((Array) (haxe.lang.Runtime.getField(e, "constructs", 1744813180, true)) ).cast<object>()) );
			}
			
			return new Array<object>(System.Enum.GetNames(e));
		}
	}
	
	
	public static   ValueType @typeof(object v)
	{
		
		if (v == null) return ValueType.TNull;

        System.Type t = v as System.Type;
        if (t != null)
        {
            //class type
            return ValueType.TObject;
        }

        t = v.GetType();
        if (t.IsEnum) 
            return ValueType.TEnum(t);
        if (t.IsValueType)
        {
            System.IConvertible vc = v as System.IConvertible;
            if (vc != null)
            {
                switch (vc.GetTypeCode())
                {
                    case System.TypeCode.Boolean: return ValueType.TBool;
                    case System.TypeCode.Double:
						double d = vc.ToDouble(null);
						if (d >= int.MinValue && d <= int.MaxValue && d == vc.ToInt32(null))
							return ValueType.TInt;
						else
							return ValueType.TFloat;
                    case System.TypeCode.Int32:
                        return ValueType.TInt;
                    default:
                        return ValueType.TClass(t);
                }
            } else {
                return ValueType.TClass(t);
            }
        }

        if (v is haxe.lang.IHxObject)
        {
            if (v is haxe.lang.DynamicObject)
                return ValueType.TObject;
            else if (v is haxe.lang.Enum)
                return ValueType.TEnum(t);
            return ValueType.TClass(t);
        } else if (v is haxe.lang.Function) {
            return ValueType.TFunction;
        } else {
            return ValueType.TClass(t);
        }
	
	}
	
	
	public static   bool enumEq<T>(T a, T b)
	{
		
			if (a is haxe.lang.Enum)
				return a.Equals(b);
			else
				return haxe.lang.Runtime.eq(a, b);
	
	}
	
	
	public static   string enumConstructor(object e)
	{
		
		if (e is System.Enum)
			return e + "";
		else
			return ((haxe.lang.Enum) e).getTag();
	
	}
	
	
	public static   Array enumParameters(object e)
	{
		
		return ( e is System.Enum ) ? new Array<object>() : ((haxe.lang.Enum) e).@params;
	
	}
	
	
	public static   int enumIndex(object e)
	{
		
		if (e is System.Enum)
			return ((System.IConvertible) e).ToInt32(null);
		else
			return ((haxe.lang.Enum) e).index;
	
	}
	
	
	public static   Array<T> allEnums<T>(System.Type e)
	{
		unchecked 
		{
			return default(Array<T>);
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Type(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Type();
		}
	}
	
	
	public    Type(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
}


