package unityEngine;
@:native("UnityEngine.Rect") extern class Rect {
	var x:Float;
	var y:Float;
	var center:unityEngine.Vector2;
	var width:Float;
	var height:Float;
	var xMin:Float;
	var yMin:Float;
	var xMax:Float;
	var yMax:Float;
	function new(left:Float, top:Float, width:Float, height:Float):Void;
	function Set(left:Float, top:Float, width:Float, height:Float):Void;
	function ToString(format:String):String;
	function Contains(point:unityEngine.Vector3):Bool;
	function MinMaxRect(left:Float, top:Float, right:Float, bottom:Float):unityEngine.Rect;
}