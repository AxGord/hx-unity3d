
namespace haxe.lang
{
	public  class HaxeException : System.Exception 
	{
		public    HaxeException(object obj) : base()
		{
			unchecked 
			{
				if (( obj is haxe.lang.HaxeException )) 
				{
					haxe.lang.HaxeException _obj = ((haxe.lang.HaxeException) (obj) );
					obj = _obj.getObject();
				}
				
				this.obj = obj;
			}
		}
		
		
		public static   System.Exception wrap(object obj)
		{
			unchecked 
			{
				if (( obj is System.Exception )) 
				{
					return ((System.Exception) (obj) );
				}
				
				return new haxe.lang.HaxeException(obj);
			}
		}
		
		
		public virtual   string toString()
		{
			unchecked 
			{
				return haxe.lang.Runtime.concat("Haxe Exception: ", Std.@string(this.obj));
			}
		}
		
		
		public virtual   object getObject()
		{
			unchecked 
			{
				return this.obj;
			}
		}
		
		
		public  object obj;
		
		public override string ToString()
		{
			return this.toString();
		}
		
		
	}
}


