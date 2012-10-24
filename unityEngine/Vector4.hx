package unityEngine;
@:native("UnityEngine.Vector4") extern class Vector4 {
	var x:Float;
	var y:Float;
	var z:Float;
	var w:Float;
	var normalized:unityEngine.Vector4;
	var magnitude:Float;
	var sqrMagnitude:Float;
	function new(x:Float, y:Float):Void;
	function Set(new_x:Float, new_y:Float, new_z:Float, new_w:Float):Void;
	function Scale(a:unityEngine.Vector4, b:unityEngine.Vector4):unityEngine.Vector4;
	function Normalize():Void;
	function ToString(format:String):String;
	static var zero:unityEngine.Vector4;
	static var one:unityEngine.Vector4;
	function Lerp(from:unityEngine.Vector4, to:unityEngine.Vector4, t:Float):unityEngine.Vector4;
	function MoveTowards(current:unityEngine.Vector4, target:unityEngine.Vector4, maxDistanceDelta:Float):unityEngine.Vector4;
	//function Scale(a:unityEngine.Vector4, b:unityEngine.Vector4):unityEngine.Vector4;
	function Dot(a:unityEngine.Vector4, b:unityEngine.Vector4):Float;
	function Project(a:unityEngine.Vector4, b:unityEngine.Vector4):unityEngine.Vector4;
	function Distance(a:unityEngine.Vector4, b:unityEngine.Vector4):Float;
	function Min(lhs:unityEngine.Vector4, rhs:unityEngine.Vector4):unityEngine.Vector4;
	function Max(lhs:unityEngine.Vector4, rhs:unityEngine.Vector4):unityEngine.Vector4;
}