
namespace cs
{
	public  class Boot : haxe.lang.HxObject 
	{
		public    Boot() : base()
		{
			unchecked 
			{
			}
		}
		
		
		public static   void init()
		{
			unchecked 
			{
				cs.Lib.applyCultureChanges();
			}
		}
		
		
		public static   object __hx_createEmpty()
		{
			unchecked 
			{
				return new cs.Boot(haxe.lang.EmptyObject.EMPTY);
			}
		}
		
		
		public static   object __hx_create(Array arr)
		{
			unchecked 
			{
				return new cs.Boot();
			}
		}
		
		
		public    Boot(haxe.lang.EmptyObject empty) : base()
		{
			unchecked 
			{
			}
		}
		
		
	}
}


