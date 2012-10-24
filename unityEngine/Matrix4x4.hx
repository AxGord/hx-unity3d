package unityEngine;
@:native("UnityEngine.Matrix4x4") extern class Matrix4x4 {
	var inverse:unityEngine.Matrix4x4;
	var transpose:unityEngine.Matrix4x4;
	var isIdentity:Bool;
	function GetColumn(i:Int):unityEngine.Vector4;
	function GetRow(i:Int):unityEngine.Vector4;
	function SetColumn(i:Int, v:unityEngine.Vector4):Void;
	function SetRow(i:Int, v:unityEngine.Vector4):Void;
	function MultiplyPoint(v:unityEngine.Vector3):unityEngine.Vector3;
	function MultiplyPoint3x4(v:unityEngine.Vector3):unityEngine.Vector3;
	function MultiplyVector(v:unityEngine.Vector3):unityEngine.Vector3;
	function SetTRS(pos:unityEngine.Vector3, q:unityEngine.Quaternion, s:unityEngine.Vector3):Void;
	function ToString(format:String):String;
	static var zero:unityEngine.Matrix4x4;
	static var identity:unityEngine.Matrix4x4;
	function Scale(v:unityEngine.Vector3):unityEngine.Matrix4x4;
	function TRS(pos:unityEngine.Vector3, q:unityEngine.Quaternion, s:unityEngine.Vector3):unityEngine.Matrix4x4;
	function Ortho(left:Float, right:Float, bottom:Float, top:Float, zNear:Float, zFar:Float):unityEngine.Matrix4x4;
	function Perspective(fov:Float, aspect:Float, zNear:Float, zFar:Float):unityEngine.Matrix4x4;
}