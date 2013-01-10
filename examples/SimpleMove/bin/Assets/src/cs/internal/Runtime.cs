
namespace haxe.lang
{
	public  class Runtime 
	{
		
	public static object getField(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return null;
		return obj.__hx_getField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false, false);
	}
	
	public static double getField_f(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return 0.0;
		return obj.__hx_getField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false);
	}
	
	public static object setField(haxe.lang.HxObject obj, string field, int fieldHash, object value)
	{
		return obj.__hx_setField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}
	
	public static double setField_f(haxe.lang.HxObject obj, string field, int fieldHash, double value)
	{
		return obj.__hx_setField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}
	
	public static object callField(haxe.lang.HxObject obj, string field, int fieldHash, Array args)
	{
		return obj.__hx_invokeField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, args);
	}
		static Runtime() 
		{
			haxe.lang.Runtime.undefined = new haxe.lang.DynamicObject(new Array<int>(new int[]{}), new Array<object>(new object[]{}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
		}
		public static  object undefined;
		
		public static   object closure(object obj, int hash, string field)
		{
			
		return new haxe.lang.Closure(obj, field, hash);
	
		}
		
		
		public static   bool eq(object v1, object v2)
		{
			
			if (System.Object.ReferenceEquals(v1, v2))
				return true;
			if (v1 == null || v2 == null)
				return false;
			
			System.IConvertible v1c = v1 as System.IConvertible;
			
			if (v1c != null)
			{
				System.IConvertible v2c = v2 as System.IConvertible;
				
				if (v2c == null)
				{
					return false;
				}
				
				System.TypeCode t1 = v1c.GetTypeCode();
				System.TypeCode t2 = v2c.GetTypeCode();
				if (t1 == t2)
					return v1c.Equals(v2c);
				
				switch(t1)
				{
					case System.TypeCode.Int64:
					case System.TypeCode.UInt64:
						return v1c.ToUInt64(null) == v2c.ToUInt64(null);
					default:
						return v1c.ToDouble(null) == v2c.ToDouble(null);
				}
			}
			
			System.ValueType v1v = v1 as System.ValueType;
			if (v1v != null)
			{
				return v1.Equals(v2);
			} else {
				System.Type v1t = v1 as System.Type;
				if (v1t != null)
				{
					System.Type v2t = v2 as System.Type;
					if (v2t != null)
						return typeEq(v1t, v2t);
					return false;
				}
			}
			
			return false;
	
		}
		
		
		public static   bool refEq(object v1, object v2)
		{
			
			return System.Object.ReferenceEquals(v1, v2);
	
		}
		
		
		public static   double toDouble(object obj)
		{
			
		return (obj == null) ? 0.0 : (obj is double) ? (double)obj : ((System.IConvertible) obj).ToDouble(null);
	
		}
		
		
		public static   int toInt(object obj)
		{
			
		return (obj == null) ? 0 : (obj is int) ? (int)obj : ((System.IConvertible) obj).ToInt32(null);
	
		}
		
		
		public static   bool isInt(object obj)
		{
			
			System.IConvertible cv1 = obj as System.IConvertible;
			if (cv1 != null)
			{
                switch (cv1.GetTypeCode())
                {
                    case System.TypeCode.Double:
                        double d = (double)obj;

				        return d >= int.MinValue && d <= int.MaxValue && d == ( (int)d );
                    case System.TypeCode.UInt32:
                    case System.TypeCode.Int32:
                        return true;
                    default:
                        return false;
                }
				
			}
			return false;
	
		}
		
		
		public static   int compare(object v1, object v2)
		{
			
			System.IConvertible cv1 = v1 as System.IConvertible;
			if (cv1 != null)
			{
				System.IConvertible cv2 = v2 as System.IConvertible;
				
				if (cv2 == null)
				{
					throw new System.ArgumentException("Cannot compare " + v1.GetType().ToString() + " and " + v2.GetType().ToString());
				}
				
				switch(cv1.GetTypeCode())
				{
					case System.TypeCode.String:
						if (cv2.GetTypeCode() != System.TypeCode.String)
							throw new System.ArgumentException("Cannot compare " + v1.GetType().ToString() + " and " + v2.GetType().ToString());
						return v1.ToString().CompareTo(v2);
					/*case System.TypeCode.Int64:
					case System.TypeCode.UInt64:
						return ((int) (cv1.ToUInt64() - cv2.ToUInt64())) no Int64 operator support */
					case System.TypeCode.Double:
					double d1 = (double) v1;
					double d2 = cv2.ToDouble(null);
					
					if (double.IsInfinity(d1) || double.IsInfinity(d2))
						return (d1 < d2) ? -1 : (d1 > d2) ? 1 : 0;
					else
						return (int) (d1 - d2);
					default:
						return ((int) (cv1.ToDouble(null) - cv2.ToDouble(null)));
				}
			}
			
			System.IComparable c1 = v1 as System.IComparable;
			System.IComparable c2 = v2 as System.IComparable;
			
			if (c1 == null || c2 == null)
			{
				if (c1 == c2)
					return 0;
				
				throw new System.ArgumentException("Cannot compare " + v1.GetType().ToString() + " and " + v2.GetType().ToString());
			}
			
			return c1.CompareTo(c2);
	
		}
		
		
		public static   object plus(object v1, object v2)
		{
			
			if (v1 is string || v2 is string)
				return Std.@string(v1) + Std.@string(v2);
			
			System.IConvertible cv1 = v1 as System.IConvertible;
			if (cv1 != null)
			{
				System.IConvertible cv2 = v2 as System.IConvertible;
				
				if (cv2 == null)
				{
					throw new System.ArgumentException("Cannot dynamically add " + v1.GetType().ToString() + " and " + v2.GetType().ToString());
				}
				
				return cv1.ToDouble(null) + cv2.ToDouble(null);
			}
			
			throw new System.ArgumentException("Cannot dynamically add " + v1 + " and " + v2);
	
		}
		
		
		public static   object slowGetField(object obj, string field, bool throwErrors)
		{
			
	
		if (obj == null)
			if (throwErrors) 
				throw new System.NullReferenceException("Cannot access field '" + field + "' of null.");
			else
				return null;
		
		System.Type t = obj as System.Type;
		System.Reflection.BindingFlags bf;
        if (t == null)
		{
			string s = obj as string;
			if (s != null)
				return haxe.lang.StringRefl.handleGetField(s, field, throwErrors);
			t = obj.GetType();
			bf = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.FlattenHierarchy;
		} else {
			if (obj == typeof(string) && field.Equals("fromCharCode"))
				return new haxe.lang.Closure(typeof(haxe.lang.StringExt), field, 0);
			
			obj = null;
			bf = System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public;
		}

		System.Reflection.FieldInfo f = t.GetField(field, bf);
		if (f != null)
		{
			return haxe.lang.Runtime.unbox(f.GetValue(obj));
		} else {
			System.Reflection.PropertyInfo prop = t.GetProperty(field, bf);
			if (prop == null)
			{
				System.Reflection.MemberInfo[] m = t.GetMember(field, bf);
				if (m.Length > 0)
				{
					return new haxe.lang.Closure(obj != null ? obj : t, field, 0);
				} else {
					if (throwErrors) 
						throw HaxeException.wrap("Cannot access field '" + field + "'.");
					else
						return null;
				}
			}
			return haxe.lang.Runtime.unbox(prop.GetValue(obj, null));
		}
	
	
		}
		
		
		public static   bool slowHasField(object obj, string field)
		{
			
		if (obj == null) return false;
		System.Type t = obj as System.Type;
		System.Reflection.BindingFlags bf;
        if (t == null)
		{
			string s = obj as string;
			if (s != null)
				return haxe.lang.StringRefl.handleGetField(s, field, false) != null;
			t = obj.GetType();
			bf = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.FlattenHierarchy;
		} else {
			if (t == typeof(string))
				return field.Equals("fromCharCode");
			obj = null;
			bf = System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public;
		}

		System.Reflection.MemberInfo[] mi = t.GetMember(field, bf);
		return mi != null && mi.Length > 0;
	
		}
		
		
		public static   object slowSetField(object obj, string field, object @value)
		{
			
		if (obj == null)
			throw new System.NullReferenceException("Cannot access field '" + field + "' of null.");
		
		System.Type t = obj as System.Type;
		System.Reflection.BindingFlags bf;
        if (t == null)
		{
			t = obj.GetType();
			bf = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.FlattenHierarchy;
		} else {
			obj = null;
			bf = System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public;
		}

		System.Reflection.FieldInfo f = t.GetField(field, bf);
		if (f != null)
		{
			if (f.FieldType.ToString().StartsWith("haxe.lang.Null"))
			{
				@value = haxe.lang.Runtime.mkNullable(@value, f.FieldType);
			}
			
			f.SetValue(obj, @value);
			return @value;
		} else {
			System.Reflection.PropertyInfo prop = t.GetProperty(field, bf);
			if (prop == null)
			{
				throw haxe.lang.HaxeException.wrap("Field '" + field + "' not found for writing from Class " + t);
			}
			
			if (prop.PropertyType.ToString().StartsWith("haxe.lang.Null"))
			{
				@value = haxe.lang.Runtime.mkNullable(@value, prop.PropertyType);
			}
			prop.SetValue(obj, @value, null);

			return @value;
		}
		
	
		}
		
		
		public static   object callMethod(object obj, System.Reflection.MethodBase[] methods, int methodLength, Array args)
		{
			unchecked 
			{
				int length = ((int) (haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) );
				object[] oargs = new object[length];
				System.Type[] ts = new System.Type[length];
				{
					int _g = 0;
					while (( _g < length ))
					{
						int i = _g++;
						oargs[i] = args[i];
						if (( ! (( args[i] == null )) )) 
						{
							ts[i] = cs.Lib.nativeType(args[i]);
						}
						
					}
					
				}
				
				int last = 0;
				if (( methodLength > 1 )) 
				{
					{
						int _g1 = 0;
						while (( _g1 < methodLength ))
						{
							int i1 = _g1++;
							System.Reflection.ParameterInfo[] @params = methods[i1].GetParameters();
							if (( @params.Length != length )) 
							{
								continue;
							}
							 else 
							{
								bool fits = true;
								{
									int _g2 = 0;
									int _g11 = @params.Length;
									while (( _g2 < _g11 ))
									{
										int i2 = _g2++;
										System.Type param = @params[i2].ParameterType;
										string strParam = haxe.lang.Runtime.concat(Std.@string(param), "");
										if (( strParam.StartsWith("haxe.lang.Null") || ( (( ( oargs[i2] == null ) || ( oargs[i2] is System.IConvertible ) )) && (((System.Type) (typeof(System.IConvertible)) )).IsAssignableFrom(param) ) )) 
										{
											continue;
										}
										 else 
										{
											if ((  ! (param.ContainsGenericParameters)  &&  ! (param.IsAssignableFrom(ts[i2]))  )) 
											{
												fits = false;
												break;
											}
											
										}
										
									}
									
								}
								
								if (fits) 
								{
									methods[last++] = methods[i1];
								}
								
							}
							
						}
						
					}
					
					methodLength = last;
				}
				
				if (( methodLength == 0 )) 
				{
					throw haxe.lang.HaxeException.wrap(haxe.lang.Runtime.concat("Invalid calling parameters for method ", methods[0].Name));
				}
				
				System.Reflection.ParameterInfo[] params1 = methods[0].GetParameters();
				{
					int _g12 = 0;
					int _g3 = params1.Length;
					while (( _g12 < _g3 ))
					{
						int i3 = _g12++;
						System.Type param1 = params1[i3].ParameterType;
						string strParam1 = haxe.lang.Runtime.concat(Std.@string(param1), "");
						if (strParam1.StartsWith("haxe.lang.Null")) 
						{
							oargs[i3] = haxe.lang.Runtime.mkNullable(oargs[i3], param1);
						}
						 else 
						{
							if ((((System.Type) (typeof(System.IConvertible)) )).IsAssignableFrom(param1)) 
							{
								if (( oargs[i3] == null )) 
								{
									if (param1.IsValueType) 
									{
										oargs[i3] = System.Activator.CreateInstance(param1);
									}
									
								}
								 else 
								{
									oargs[i3] = (((System.IConvertible) (oargs[i3]) )).ToType(param1, default(System.IFormatProvider));
								}
								
							}
							
						}
						
					}
					
				}
				
				if (( methods[0].ContainsGenericParameters && ( methods[0] is System.Reflection.MethodInfo ) )) 
				{
					System.Reflection.MethodInfo m = ((System.Reflection.MethodInfo) (methods[0]) );
					System.Type[] tgs = m.GetGenericArguments();
					{
						int _g13 = 0;
						int _g4 = tgs.Length;
						while (( _g13 < _g4 ))
						{
							int i4 = _g13++;
							tgs[i4] = typeof(object);
						}
						
					}
					
					m = m.MakeGenericMethod(tgs);
					object retg = m.Invoke(obj, oargs);
					return haxe.lang.Runtime.unbox(retg);
				}
				
				System.Reflection.MethodBase m1 = methods[0];
				if (( ( obj == null ) && ( m1 is System.Reflection.ConstructorInfo ) )) 
				{
					object ret = (((System.Reflection.ConstructorInfo) (m1) )).Invoke(oargs);
					return haxe.lang.Runtime.unbox(ret);
				}
				
				object ret1 = m1.Invoke(obj, oargs);
				return haxe.lang.Runtime.unbox(ret1);
			}
		}
		
		
		public static   object unbox(object dyn)
		{
			unchecked 
			{
				if (( ( ! (( dyn == null )) ) && (haxe.lang.Runtime.concat(Std.@string(cs.Lib.nativeType(dyn)), "")).StartsWith("haxe.lang.Null") )) 
				{
					return ((object) (haxe.lang.Runtime.callField(dyn, "toDynamic", 1705629508, default(Array))) );
				}
				 else 
				{
					return dyn;
				}
				
			}
		}
		
		
		public static   object mkNullable(object obj, System.Type nullableType)
		{
			
		if (nullableType.ContainsGenericParameters)
			return haxe.lang.Null<object>.ofDynamic<object>(obj);
		return nullableType.GetMethod("_ofDynamic").Invoke(null, new object[] { obj });
	
		}
		
		
		public static   object slowCallField(object obj, string field, Array args)
		{
			
		if (args == null) args = new Array<object>();
		
		System.Reflection.BindingFlags bf;
		System.Type t = obj as System.Type;
		if (t == null)
		{
			string s = obj as string;
			if (s != null)
				return haxe.lang.StringRefl.handleCallField(s, field, args);
			t = obj.GetType();
			bf = System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.FlattenHierarchy;
		} else {
			if (t == typeof(string) && field.Equals("fromCharCode"))
				return haxe.lang.StringExt.fromCharCode(toInt(args[0]));
			obj = null;
			bf = System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public;
		}
		
		System.Reflection.MethodInfo[] mis = t.GetMethods(bf);
		int last = 0;
		for (int i = 0; i < mis.Length; i++)
		{
			if (mis[i].Name.Equals(field))
			{
				mis[last++] = mis[i];
			}
		}
		
		if (last == 0)
		{
			throw haxe.lang.HaxeException.wrap("Method '" + field + "' not found on type " + t);
		}
		
		return haxe.lang.Runtime.callMethod(obj, mis, last, args);
	
		}
		
		
		public static   object callField(object obj, string field, int fieldHash, Array args)
		{
			
		haxe.lang.HxObject hxObj = obj as haxe.lang.HxObject;
		if (hxObj != null)
			return hxObj.__hx_invokeField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, args);
		
		return slowCallField(obj, field, args);
	
		}
		
		
		public static   object getField(object obj, string field, int fieldHash, bool throwErrors)
		{
			
	
		haxe.lang.HxObject hxObj = obj as haxe.lang.HxObject;
		if (hxObj != null)
			return hxObj.__hx_getField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false, false);
		
		return slowGetField(obj, field, throwErrors);
	
	
		}
		
		
		public static   double getField_f(object obj, string field, int fieldHash, bool throwErrors)
		{
			
	
		haxe.lang.HxObject hxObj = obj as haxe.lang.HxObject;
		if (hxObj != null)
			return hxObj.__hx_getField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false);
		
		return (double)slowGetField(obj, field, throwErrors);
	
	
		}
		
		
		public static   object setField(object obj, string field, int fieldHash, object @value)
		{
			
	
		haxe.lang.HxObject hxObj = obj as haxe.lang.HxObject;
		if (hxObj != null)
			return hxObj.__hx_setField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
		
		return slowSetField(obj, field, value);
	
	
		}
		
		
		public static   double setField_f(object obj, string field, int fieldHash, double @value)
		{
			

		haxe.lang.HxObject hxObj = obj as haxe.lang.HxObject;
		if (hxObj != null)
			return hxObj.__hx_setField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
		
		return (double)slowSetField(obj, field, value);
	
	
		}
		
		
		public static   string toString(object obj)
		{
			unchecked 
			{
				if (( obj == null )) 
				{
					return default(string);
				}
				
				return obj.ToString();
			}
		}
		
		
		public static   bool typeEq(System.Type t1, System.Type t2)
		{
			
			if (t1 == null || t2 == null)
				return t1 == t2;
			return t1.Name.Equals(t2.Name);
	
		}
		
		
		public static   To genericCast<To>(object obj)
		{
			
		if (obj is To)
			return (To) obj;
		else if (obj == null)
			return default(To);
		if (typeof(To) == typeof(double))
			return (To)(object) toDouble(obj);
		else if (typeof(To) == typeof(int))
			return (To)(object) toInt(obj);
		else
			return (To) obj;
	
		}
		
		
		public static   string concat(string s1, string s2)
		{
			
		return (s1 == null ? "null" : s1) + (s2 == null ? "null" : s2);
	
		}
		
		
	}
}



namespace haxe.lang
{
	public enum EmptyObject
	{
		EMPTY
	}
}


