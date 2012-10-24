package unityEngine;
@:native("UnityEngine.Ray") extern class Ray {
	var origin:unityEngine.Vector3;
	var direction:unityEngine.Vector3;
	function new(origin:unityEngine.Vector3, direction:unityEngine.Vector3):Void;
	function GetPoint(distance:Float):unityEngine.Vector3;
	function ToString(format:String):String;
}