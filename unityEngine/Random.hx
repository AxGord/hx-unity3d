package unityEngine;
@:native("UnityEngine.Random") extern class Random {
	static var seed:Int;
	static var value:Float;
	static var insideUnitSphere:unityEngine.Vector3;
	static var insideUnitCircle:unityEngine.Vector2;
	static var onUnitSphere:unityEngine.Vector3;
	static var rotation:unityEngine.Quaternion;
	function Range(min:Int, max:Int):Int;
}