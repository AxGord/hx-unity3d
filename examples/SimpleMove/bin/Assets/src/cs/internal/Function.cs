
namespace haxe.lang
{
	public  class Function 
	{
		public    Function(int arity, int type)
		{
			unchecked 
			{
				this.__fn_type = type;
				this.__hx_arity = arity;
			}
		}
		
		
		public virtual   object __hx_invokeDynamic(Array __fn_dynargs)
		{
			unchecked 
			{
				switch (( (( __fn_dynargs == default(Array) )) ? (0) : (((int) (haxe.lang.Runtime.getField_f(__fn_dynargs, "length", 520590566, true)) )) ))
				{
					case 0:
					{
						return this.__hx_invoke0_o();
					}
					
					
					case 1:
					{
						return this.__hx_invoke1_o(0.0, ((object) (__fn_dynargs[0]) ));
					}
					
					
					case 2:
					{
						return this.__hx_invoke2_o(0.0, 0.0, ((object) (__fn_dynargs[0]) ), ((object) (__fn_dynargs[1]) ));
					}
					
					
					case 3:
					{
						return this.__hx_invoke3_o(0.0, 0.0, 0.0, ((object) (__fn_dynargs[0]) ), ((object) (__fn_dynargs[1]) ), ((object) (__fn_dynargs[2]) ));
					}
					
					
					case 4:
					{
						return this.__hx_invoke4_o(0.0, 0.0, 0.0, 0.0, ((object) (__fn_dynargs[0]) ), ((object) (__fn_dynargs[1]) ), ((object) (__fn_dynargs[2]) ), ((object) (__fn_dynargs[3]) ));
					}
					
					
					case 5:
					{
						return this.__hx_invoke5_o(0.0, 0.0, 0.0, 0.0, 0.0, ((object) (__fn_dynargs[0]) ), ((object) (__fn_dynargs[1]) ), ((object) (__fn_dynargs[2]) ), ((object) (__fn_dynargs[3]) ), ((object) (__fn_dynargs[4]) ));
					}
					
					
					case 6:
					{
						return this.__hx_invoke6_o(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, ((object) (__fn_dynargs[0]) ), ((object) (__fn_dynargs[1]) ), ((object) (__fn_dynargs[2]) ), ((object) (__fn_dynargs[3]) ), ((object) (__fn_dynargs[4]) ), ((object) (__fn_dynargs[5]) ));
					}
					
					
					default:
					{
						throw haxe.lang.HaxeException.wrap("Too many arguments");
					}
					
				}
				
			}
		}
		
		
		public  int __fn_type;
		
		public  int __hx_arity;
		
		public virtual   object __hx_invoke6_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, double __fn_float6, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5, object __fn_dyn6)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke6_f(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_float5, __fn_float6, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4, __fn_dyn5, __fn_dyn6);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke6_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, double __fn_float6, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5, object __fn_dyn6)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke6_o(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_float5, __fn_float6, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4, __fn_dyn5, __fn_dyn6));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke5_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke5_f(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_float5, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4, __fn_dyn5);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke5_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke5_o(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_float5, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4, __fn_dyn5));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke4_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke4_f(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke4_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke4_o(__fn_float1, __fn_float2, __fn_float3, __fn_float4, __fn_dyn1, __fn_dyn2, __fn_dyn3, __fn_dyn4));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke3_o(double __fn_float1, double __fn_float2, double __fn_float3, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke3_f(__fn_float1, __fn_float2, __fn_float3, __fn_dyn1, __fn_dyn2, __fn_dyn3);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke3_f(double __fn_float1, double __fn_float2, double __fn_float3, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke3_o(__fn_float1, __fn_float2, __fn_float3, __fn_dyn1, __fn_dyn2, __fn_dyn3));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke2_o(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke2_f(__fn_float1, __fn_float2, __fn_dyn1, __fn_dyn2);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke2_f(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke2_o(__fn_float1, __fn_float2, __fn_dyn1, __fn_dyn2));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke1_f(__fn_float1, __fn_dyn1);
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke1_f(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke1_o(__fn_float1, __fn_dyn1));
				}
				
			}
		}
		
		
		public virtual   object __hx_invoke0_o()
		{
			unchecked 
			{
				if (( this.__fn_type != 1 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return this.__hx_invoke0_f();
				}
				
			}
		}
		
		
		public virtual   double __hx_invoke0_f()
		{
			unchecked 
			{
				if (( this.__fn_type != 0 )) 
				{
					throw haxe.lang.HaxeException.wrap("Wrong number of arguments");
				}
				 else 
				{
					return haxe.lang.Runtime.toDouble(this.__hx_invoke0_o());
				}
				
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class VarArgsBase : haxe.lang.Function 
	{
		public    VarArgsBase(int arity, int type) : base(arity, type)
		{
			unchecked 
			{
			}
		}
		
		
		public override   object __hx_invokeDynamic(Array dynArgs)
		{
			unchecked 
			{
				throw haxe.lang.HaxeException.wrap("Abstract implementation");
			}
		}
		
		
		public override   object __hx_invoke6_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, double __fn_float6, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5, object __fn_dyn6)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) ), ((object) (( (( __fn_dyn5 == haxe.lang.Runtime.undefined )) ? (__fn_float5) : (((object) (__fn_dyn5) )) )) ), ((object) (( (( __fn_dyn6 == haxe.lang.Runtime.undefined )) ? (__fn_float6) : (((object) (__fn_dyn6) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke6_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, double __fn_float6, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5, object __fn_dyn6)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) ), ((object) (( (( __fn_dyn5 == haxe.lang.Runtime.undefined )) ? (__fn_float5) : (((object) (__fn_dyn5) )) )) ), ((object) (( (( __fn_dyn6 == haxe.lang.Runtime.undefined )) ? (__fn_float6) : (((object) (__fn_dyn6) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke5_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) ), ((object) (( (( __fn_dyn5 == haxe.lang.Runtime.undefined )) ? (__fn_float5) : (((object) (__fn_dyn5) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke5_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, double __fn_float5, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4, object __fn_dyn5)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) ), ((object) (( (( __fn_dyn5 == haxe.lang.Runtime.undefined )) ? (__fn_float5) : (((object) (__fn_dyn5) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke4_o(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke4_f(double __fn_float1, double __fn_float2, double __fn_float3, double __fn_float4, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3, object __fn_dyn4)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) ), ((object) (( (( __fn_dyn4 == haxe.lang.Runtime.undefined )) ? (__fn_float4) : (((object) (__fn_dyn4) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke3_o(double __fn_float1, double __fn_float2, double __fn_float3, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke3_f(double __fn_float1, double __fn_float2, double __fn_float3, object __fn_dyn1, object __fn_dyn2, object __fn_dyn3)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) ), ((object) (( (( __fn_dyn3 == haxe.lang.Runtime.undefined )) ? (__fn_float3) : (((object) (__fn_dyn3) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke2_o(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke2_f(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) ), ((object) (( (( __fn_dyn2 == haxe.lang.Runtime.undefined )) ? (__fn_float2) : (((object) (__fn_dyn2) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke1_o(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) )}));
			}
		}
		
		
		public override   double __hx_invoke1_f(double __fn_float1, object __fn_dyn1)
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(new Array<object>(new object[]{((object) (( (( __fn_dyn1 == haxe.lang.Runtime.undefined )) ? (__fn_float1) : (((object) (__fn_dyn1) )) )) )})));
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				return this.__hx_invokeDynamic(default(Array<object>));
			}
		}
		
		
		public override   double __hx_invoke0_f()
		{
			unchecked 
			{
				return haxe.lang.Runtime.toDouble(this.__hx_invokeDynamic(default(Array<object>)));
			}
		}
		
		
	}
}



namespace haxe.lang
{
	public  class VarArgsFunction : haxe.lang.VarArgsBase 
	{
		public    VarArgsFunction(haxe.lang.Function fun) : base(-1, -1)
		{
			unchecked 
			{
				this.fun = fun;
			}
		}
		
		
		public override   object __hx_invokeDynamic(Array dynArgs)
		{
			unchecked 
			{
				return ((object) (this.fun.__hx_invoke1_o(default(double), dynArgs)) );
			}
		}
		
		
		public  haxe.lang.Function fun;
		
	}
}



namespace haxe.lang
{
	public  class Closure : haxe.lang.VarArgsBase 
	{
		public    Closure(object obj, string field, int hash) : base(-1, -1)
		{
			unchecked 
			{
				this.obj = obj;
				this.field = field;
				this.hash = hash;
			}
		}
		
		
		public override   object __hx_invokeDynamic(Array dynArgs)
		{
			unchecked 
			{
				return haxe.lang.Runtime.callField(this.obj, this.field, this.hash, dynArgs);
			}
		}
		
		
		public  int hash;
		
		public  string field;
		
		public  object obj;
		
	}
}


