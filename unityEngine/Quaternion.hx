package unityEngine;
@:native("UnityEngine.Quaternion") extern class Quaternion {
	var x:Float;
	var y:Float;
	var z:Float;
	var w:Float;
	var eulerAngles:unityEngine.Vector3;
	function new(x:Float, y:Float, z:Float, w:Float):Void;
	function Set(new_x:Float, new_y:Float, new_z:Float, new_w:Float):Void;
	function ToAngleAxis(angle:Float, axis:unityEngine.Vector3):Void;
	function SetFromToRotation(fromDirection:unityEngine.Vector3, toDirection:unityEngine.Vector3):Void;
	function SetLookRotation(view:unityEngine.Vector3, up:unityEngine.Vector3 = Vector3.up):Void;
	function ToString(format:String):String;
	static var identity:unityEngine.Quaternion;
	function Dot(a:unityEngine.Quaternion, b:unityEngine.Quaternion):Float;
	function AngleAxis(angle:Float, axis:unityEngine.Vector3):unityEngine.Quaternion;
	function FromToRotation(fromDirection:unityEngine.Vector3, toDirection:unityEngine.Vector3):unityEngine.Quaternion;
	static function LookRotation(forward:unityEngine.Vector3, upwards:unityEngine.Vector3 = Vector3.up):unityEngine.Quaternion;
	static function Slerp(from:unityEngine.Quaternion, to:unityEngine.Quaternion, t:Single):unityEngine.Quaternion;
	static function Lerp(from:unityEngine.Quaternion, to:unityEngine.Quaternion, t:Single):unityEngine.Quaternion;
	function RotateTowards(from:unityEngine.Quaternion, to:unityEngine.Quaternion, maxDegreesDelta:Float):unityEngine.Quaternion;
	function Inverse(rotation:unityEngine.Quaternion):unityEngine.Quaternion;
	function Angle(a:unityEngine.Quaternion, b:unityEngine.Quaternion):Float;
	function Euler(euler:unityEngine.Vector3):unityEngine.Quaternion;
}