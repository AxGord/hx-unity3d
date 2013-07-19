package unityEngine;
@:native("UnityEngine.Rect") extern class Rect {
	var x:Single;
	var y:Single;
	var center:unityEngine.Vector2;
	var width:Single;
	var height:Single;
	var xMin:Single;
	var yMin:Single;
	var xMax:Single;
	var yMax:Single;
	function new(left:Single, top:Single, width:Single, height:Single):Void;
	function Set(left:Single, top:Single, width:Single, height:Single):Void;
	function ToString(format:String):String;
	function Contains(point:unityEngine.Vector3):Bool;
	function MinMaxRect(left:Single, top:Single, right:Single, bottom:Single):unityEngine.Rect;
}