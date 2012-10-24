package unityEngine;
@:native("UnityEngine.Array") extern class Array<T> {
	var length:Int;
	function new():Void;
	function Concat(array:unityEngine.Array<T>, optionalArray0:unityEngine.Array<T>, optionalArray1:unityEngine.Array<T>):unityEngine.Array<T>;
	function Join(seperator:String):String;
	function Push(value:unityEngine.Object):Int;
	function Add(value:unityEngine.Object):Void;
	function Pop():unityEngine.Object;
	function Shift():unityEngine.Object;
	function RemoveAt(index:Int):Void;
	function Unshift(newElement:unityEngine.Object, optionalElement:unityEngine.Object):Int;
	function Clear():Void;
	function Reverse():unityEngine.Array<T>;
	function Sort():unityEngine.Array<T>;
}