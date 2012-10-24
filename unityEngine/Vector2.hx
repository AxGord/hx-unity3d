package unityEngine;
@:native("UnityEngine.Vector2") extern class Vector2 {
	var x:Float;
	var y:Float;
	function new(x:Float, y:Float):Void;
	function Set(new_x:Float, new_y:Float):Void;
	function Scale(a:unityEngine.Vector2, b:unityEngine.Vector2):unityEngine.Vector2;
	function Normalize():Void;
	function ToString(format:String):String;
	static var zero:unityEngine.Vector2;
	static var one:unityEngine.Vector2;
	static var up:unityEngine.Vector2;
	static var right:unityEngine.Vector2;
	function Lerp(from:unityEngine.Vector2, to:unityEngine.Vector2, t:Float):unityEngine.Vector2;
	function MoveTowards(current:unityEngine.Vector2, target:unityEngine.Vector2, maxDistanceDelta:Float):unityEngine.Vector2;
	//function Scale(a:unityEngine.Vector2, b:unityEngine.Vector2):unityEngine.Vector2;
	function Dot(lhs:unityEngine.Vector2, rhs:unityEngine.Vector2):Float;
	function Angle(from:unityEngine.Vector2, to:unityEngine.Vector2):Float;
	function Distance(a:unityEngine.Vector2, b:unityEngine.Vector2):Float;
	function ClampMagnitude(vector:unityEngine.Vector2, maxLength:Float):unityEngine.Vector2;
	function Min(lhs:unityEngine.Vector2, rhs:unityEngine.Vector2):unityEngine.Vector2;
	function Max(lhs:unityEngine.Vector2, rhs:unityEngine.Vector2):unityEngine.Vector2;
}