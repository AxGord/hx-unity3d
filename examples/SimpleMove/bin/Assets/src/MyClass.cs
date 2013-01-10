
public  class MyClass : UnityEngine.MonoBehaviour, haxe.lang.IHxObject 
{
	public    MyClass() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new MyClass(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new MyClass();
		}
	}
	
	
	public    MyClass(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
	public virtual   void Update()
	{
		unchecked 
		{
			if (( this.speed == 0 )) 
			{
				return ;
			}
			
			((UnityEngine.Transform) (haxe.lang.Runtime.getField(this, "transform", 1167273324, true)) ).position = UnityEngine.Vector3.MoveTowards(((UnityEngine.Transform) (haxe.lang.Runtime.getField(this, "transform", 1167273324, true)) ).position, this.target.transform.position, ((float) (( UnityEngine.Time.deltaTime * this.speed )) ));
		}
	}
	
	
	public virtual   void Start()
	{
		unchecked 
		{
			this.speed = ((float) (5) );
			if (( this.target == default(UnityEngine.GameObject) )) 
			{
				this.target = UnityEngine.GameObject.Find("/Target");
			}
			
			haxe.Log.trace.__hx_invoke2_o(default(double), default(double), "Hll wrld!", new haxe.lang.DynamicObject(new Array<int>(new int[]{302979532, 1547539107, 1648581351}), new Array<object>(new object[]{"Start", "MyClass", "MyClass.hx"}), new Array<int>(new int[]{1981972957}), new Array<double>(new double[]{21})));
		}
	}
	
	
	public  float speed;
	
	public  UnityEngine.GameObject target;
	
	public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
	{
		unchecked 
		{
			switch (hash)
			{
				case 23697287:
				{
					return ((double) (this.speed = ((float) (@value) )) );
				}
				
				
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
				case 1224700491:
				{
					return this.name = haxe.lang.Runtime.toString(@value);
				}
				
				
				case 1575675685:
				{
					return this.hideFlags = ((UnityEngine.HideFlags) (@value) );
				}
				
				
				case 5790298:
				{
					return this.tag = haxe.lang.Runtime.toString(@value);
				}
				
				
				case 2117141633:
				{
					return this.enabled = ((bool) (@value) );
				}
				
				
				case 896046654:
				{
					return this.useGUILayout = ((bool) (@value) );
				}
				
				
				case 116192081:
				{
					return this.target = ((UnityEngine.GameObject) (@value) );
				}
				
				
				case 23697287:
				{
					return this.speed = ((float) (haxe.lang.Runtime.toDouble(@value)) );
				}
				
				
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
				case 1224700491:
				{
					return this.name;
				}
				
				
				case 1575675685:
				{
					return this.hideFlags;
				}
				
				
				case 276486854:
				{
					return new haxe.lang.Closure(this, "GetInstanceID", 276486854);
				}
				
				
				case 304123084:
				{
					return new haxe.lang.Closure(this, "ToString", 304123084);
				}
				
				
				case 1909937370:
				{
					return new haxe.lang.Closure(this, "Destroy", 1909937370);
				}
				
				
				case 1003238327:
				{
					return new haxe.lang.Closure(this, "DestroyImmediate", 1003238327);
				}
				
				
				case 1635357710:
				{
					return new haxe.lang.Closure(this, "DontDestroyOnLoad", 1635357710);
				}
				
				
				case 5790298:
				{
					return this.tag;
				}
				
				
				case 1723652455:
				{
					return new haxe.lang.Closure(this, "GetComponent", 1723652455);
				}
				
				
				case 1328964235:
				{
					return new haxe.lang.Closure(this, "GetComponentInChildren", 1328964235);
				}
				
				
				case 967979664:
				{
					return new haxe.lang.Closure(this, "GetComponentsInChildren", 967979664);
				}
				
				
				case 2122408236:
				{
					return new haxe.lang.Closure(this, "GetComponents", 2122408236);
				}
				
				
				case 89600725:
				{
					return new haxe.lang.Closure(this, "CompareTag", 89600725);
				}
				
				
				case 294420221:
				{
					return new haxe.lang.Closure(this, "SendMessageUpwards", 294420221);
				}
				
				
				case 139469119:
				{
					return new haxe.lang.Closure(this, "SendMessage", 139469119);
				}
				
				
				case 2134927590:
				{
					return new haxe.lang.Closure(this, "BroadcastMessage", 2134927590);
				}
				
				
				case 2117141633:
				{
					return this.enabled;
				}
				
				
				case 896046654:
				{
					return this.useGUILayout;
				}
				
				
				case 1416948632:
				{
					return new haxe.lang.Closure(this, "Invoke", 1416948632);
				}
				
				
				case 1641152943:
				{
					return new haxe.lang.Closure(this, "InvokeRepeating", 1641152943);
				}
				
				
				case 757431474:
				{
					return new haxe.lang.Closure(this, "CancelInvoke", 757431474);
				}
				
				
				case 602588383:
				{
					return new haxe.lang.Closure(this, "IsInvoking", 602588383);
				}
				
				
				case 987108662:
				{
					return new haxe.lang.Closure(this, "StartCoroutine", 987108662);
				}
				
				
				case 2084823382:
				{
					return new haxe.lang.Closure(this, "StopCoroutine", 2084823382);
				}
				
				
				case 1856815770:
				{
					return new haxe.lang.Closure(this, "StopAllCoroutines", 1856815770);
				}
				
				
				case 116192081:
				{
					return this.target;
				}
				
				
				case 23697287:
				{
					return this.speed;
				}
				
				
				case 389604418:
				{
					return new haxe.lang.Closure(this, "Start", 389604418);
				}
				
				
				case 999946793:
				{
					return new haxe.lang.Closure(this, "Update", 999946793);
				}
				
				
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
				case 23697287:
				{
					return ((double) (this.speed) );
				}
				
				
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
				case 1856815770:case 2084823382:case 987108662:case 602588383:case 757431474:case 1641152943:case 1416948632:case 2134927590:case 139469119:case 294420221:case 89600725:case 2122408236:case 967979664:case 1328964235:case 1723652455:case 1635357710:case 1003238327:case 1909937370:case 304123084:case 276486854:
				{
					return haxe.lang.Runtime.slowCallField(this, field, dynargs);
				}
				
				
				case 389604418:
				{
					this.Start();
					return default(object);
				}
				
				
				case 999946793:
				{
					this.Update();
					return default(object);
				}
				
				
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
			baseArr.push("name");
			baseArr.push("hideFlags");
			baseArr.push("tag");
			baseArr.push("enabled");
			baseArr.push("useGUILayout");
			baseArr.push("target");
			baseArr.push("speed");
		}
	}
	
	
}


