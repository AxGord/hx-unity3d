package unityEngine;
@:native("UnityEngine.AndroidInput") extern class AndroidInput {
	static var touchCountSecondary:Int;
	static var secondaryTouchEnabled:Bool;
	static var secondaryTouchWidth:Int;
	static var secondaryTouchHeight:Int;
	function GetSecondaryTouch(index:Int):unityEngine.Touch;
}