
public  class Reflect : haxe.lang.HxObject 
{
	public    Reflect() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   bool hasField(object o, string field)
	{
		
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, true, false) != haxe.lang.Runtime.undefined;
		
		return haxe.lang.Runtime.slowHasField(o, field);
	
	}
	
	
	public static   object field(object o, string field)
	{
		
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, false);
		
		return haxe.lang.Runtime.slowGetField(o, field, false);
	
	}
	
	
	public static   void setField(object o, string field, object @value)
	{
		
		if (o is haxe.lang.IHxObject)
			((haxe.lang.IHxObject) o).__hx_setField(field, haxe.lang.FieldLookup.hash(field), value, false);
		else
			haxe.lang.Runtime.slowSetField(o, field, value);
	
	}
	
	
	public static   object getProperty(object o, string field)
	{
		
		if (o is haxe.lang.IHxObject)
			return ((haxe.lang.IHxObject) o).__hx_getField(field, haxe.lang.FieldLookup.hash(field), false, false, true);
		
		return haxe.lang.Runtime.slowGetField(o, field, false);
	
	}
	
	
	public static   void setProperty(object o, string field, object @value)
	{
		
		if (o is haxe.lang.IHxObject)
			((haxe.lang.IHxObject) o).__hx_setField(field, haxe.lang.FieldLookup.hash(field), value, true);
		else
			haxe.lang.Runtime.slowSetField(o, field, value);
	
	}
	
	
	public static   object callMethod(object o, object func, Array args)
	{
		
		return ((haxe.lang.Function) func).__hx_invokeDynamic(args);
	
	}
	
	
	public static   Array<object> fields(object o)
	{
		
		if (o is haxe.lang.IHxObject)
		{
			Array<object> ret = new Array<object>();
				((haxe.lang.IHxObject) o).__hx_getFields(ret);
			return ret;
		} else if (o is System.Type) {
			return Type.getClassFields( (System.Type) o);
		} else {
			return new Array<object>();
		}
	
	}
	
	
	public static   bool isFunction(object f)
	{
		
		return f is haxe.lang.Function;
	
	}
	
	
	public static   int compare<T>(T a, T b)
	{
		
		return haxe.lang.Runtime.compare(a, b);
	
	}
	
	
	public static   bool compareMethods(object f1, object f2)
	{
		
		if (f1 == f2) 
			return true;
		
		if (f1 is haxe.lang.Closure && f2 is haxe.lang.Closure)
		{
			haxe.lang.Closure f1c = (haxe.lang.Closure) f1;
			haxe.lang.Closure f2c = (haxe.lang.Closure) f2;
			
			return haxe.lang.Runtime.refEq(f1c.obj, f2c.obj) && f1c.field.Equals(f2c.field);
		}
		
		return false;
	
	}
	
	
	public static   bool isObject(object v)
	{
		
		return v is haxe.lang.DynamicObject;
	
	}
	
	
	public static   bool deleteField(object o, string f)
	{
		
		return (o is haxe.lang.DynamicObject && ((haxe.lang.DynamicObject) o).__hx_deleteField(f, haxe.lang.FieldLookup.hash(f)));
	
	}
	
	
	public static   T copy<T>(T o)
	{
		unchecked 
		{
			object o2 = new haxe.lang.DynamicObject(new Array<int>(new int[]{}), new Array<object>(new object[]{}), new Array<int>(new int[]{}), new Array<double>(new double[]{}));
			{
				int _g = 0;
				Array<object> _g1 = Reflect.fields(o);
				while (( _g < _g1.length ))
				{
					string f = haxe.lang.Runtime.toString(_g1[_g]);
					 ++ _g;
					Reflect.setField(o2, f, Reflect.field(o, f));
				}
				
			}
			
			return haxe.lang.Runtime.genericCast<T>(o2);
		}
	}
	
	
	public static   object makeVarArgs(haxe.lang.Function f)
	{
		unchecked 
		{
			return new haxe.lang.VarArgsFunction(f);
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new Reflect(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new Reflect();
		}
	}
	
	
	public    Reflect(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
}


