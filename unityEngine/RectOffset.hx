package unityEngine;
@:native("UnityEngine.RectOffset") extern class RectOffset {
	var left:Int;
	var right:Int;
	var top:Int;
	var bottom:Int;
	var horizontal:Int;
	var vertical:Int;
	function new(left:Int, right:Int, top:Int, bottom:Int):Void;
	function Add(rect:unityEngine.Rect):unityEngine.Rect;
	function Remove(rect:unityEngine.Rect):unityEngine.Rect;
}