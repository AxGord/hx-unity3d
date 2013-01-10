
namespace haxe.lang
{
	public  interface Iterator<T> : haxe.lang.IHxObject, haxe.lang.Iterator 
	{
		   T next();
		
		   bool hasNext();
		
	}
}



namespace haxe.lang
{
	public  interface Iterator : haxe.lang.IHxObject, haxe.lang.IGenericObject 
	{
		   object cast<T>();
		
	}
}



namespace haxe.lang
{
	public  interface Iterable<T> : haxe.lang.IHxObject, haxe.lang.Iterable 
	{
		   object iterator();
		
	}
}



namespace haxe.lang
{
	public  interface Iterable : haxe.lang.IHxObject, haxe.lang.IGenericObject 
	{
		   object cast<T>();
		
	}
}


