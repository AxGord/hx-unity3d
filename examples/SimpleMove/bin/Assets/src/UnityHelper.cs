
public  class UnityHelper : haxe.lang.HxObject 
{
	public    UnityHelper() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   Array<T> toArray<T>(T[] na)
	{
		unchecked 
		{
			Array<T> a = new Array<T>(new T[]{});
			{
				int _g1 = 0;
				int _g = na.Length;
				while (( _g1 < _g ))
				{
					int i = _g1++;
					a.push(na[i]);
				}
				
			}
			
			return a;
		}
	}
	
	
	public static   UnityEngine.Transform getTransform(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Transform) (haxe.lang.Runtime.getField(c, "transform", 1167273324, true)) );
		}
	}
	
	
	public static   UnityEngine.Renderer getRenderer(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Renderer) (haxe.lang.Runtime.getField(c, "renderer", 853263683, true)) );
		}
	}
	
	
	public static   UnityEngine.Rigidbody getRigidbody(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Rigidbody) (haxe.lang.Runtime.getField(c, "rigidbody", 1895479501, true)) );
		}
	}
	
	
	public static   UnityEngine.Camera getCamera(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Camera) (haxe.lang.Runtime.getField(c, "camera", 931940005, true)) );
		}
	}
	
	
	public static   UnityEngine.Light getLight(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Light) (haxe.lang.Runtime.getField(c, "light", 1962709206, true)) );
		}
	}
	
	
	public static   UnityEngine.Animation getAnimation(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Animation) (haxe.lang.Runtime.getField(c, "animation", 1261760260, true)) );
		}
	}
	
	
	public static   UnityEngine.ConstantForce getConstantForce(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.ConstantForce) (haxe.lang.Runtime.getField(c, "constantForce", 1431885287, true)) );
		}
	}
	
	
	public static   UnityEngine.GameObject getGameObject(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.GameObject) (haxe.lang.Runtime.getField(c, "gameObject", 1471506513, true)) );
		}
	}
	
	
	public static   UnityEngine.GUITexture getGuiTexture(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.GUITexture) (haxe.lang.Runtime.getField(c, "guiTexture", 674101152, true)) );
		}
	}
	
	
	public static   UnityEngine.Renderer chRenderer(UnityEngine.Component c)
	{
		unchecked 
		{
			return ((UnityEngine.Renderer) (c.GetComponentInChildren(typeof(UnityEngine.Renderer))) );
		}
	}
	
	
	public static   Array<object> chsRenderers(UnityEngine.Component c)
	{
		unchecked 
		{
			return UnityHelper.toArray<object>(((object[]) (c.GetComponentsInChildren(typeof(UnityEngine.Renderer))) ));
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new UnityHelper(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new UnityHelper();
		}
	}
	
	
	public    UnityHelper(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
}



public  class UnityHelperGO : haxe.lang.HxObject 
{
	public    UnityHelperGO() : base()
	{
		unchecked 
		{
		}
	}
	
	
	public static   UnityEngine.Transform getTransform(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.transform;
		}
	}
	
	
	public static   UnityEngine.Renderer getRenderer(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.renderer;
		}
	}
	
	
	public static   UnityEngine.Rigidbody getRigidbody(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.rigidbody;
		}
	}
	
	
	public static   UnityEngine.Camera getCamera(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.camera;
		}
	}
	
	
	public static   UnityEngine.Light getLight(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.light;
		}
	}
	
	
	public static   UnityEngine.Animation getAnimation(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.animation;
		}
	}
	
	
	public static   UnityEngine.ConstantForce getConstantForce(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.constantForce;
		}
	}
	
	
	public static   UnityEngine.GameObject getGameObject(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c;
		}
	}
	
	
	public static   UnityEngine.GUITexture getGuiTexture(UnityEngine.GameObject c)
	{
		unchecked 
		{
			return c.guiTexture;
		}
	}
	
	
	public static   object __hx_createEmpty()
	{
		unchecked 
		{
			return new UnityHelperGO(haxe.lang.EmptyObject.EMPTY);
		}
	}
	
	
	public static   object __hx_create(Array arr)
	{
		unchecked 
		{
			return new UnityHelperGO();
		}
	}
	
	
	public    UnityHelperGO(haxe.lang.EmptyObject empty) : base()
	{
		unchecked 
		{
		}
	}
	
	
}


