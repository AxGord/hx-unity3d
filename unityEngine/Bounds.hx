package unityEngine;
@:native("UnityEngine.Bounds") extern class Bounds {
	var center:unityEngine.Vector3;
	var size:unityEngine.Vector3;
	var extents:unityEngine.Vector3;
	var min:unityEngine.Vector3;
	var max:unityEngine.Vector3;
	function new(center:unityEngine.Vector3, size:unityEngine.Vector3):Void;
	function SetMinMax(min:unityEngine.Vector3, max:unityEngine.Vector3):Void;
	function Encapsulate(bounds:unityEngine.Bounds):Void;
	function Expand(amount:unityEngine.Vector3):Void;
	function Intersects(bounds:unityEngine.Bounds):Bool;
	function Contains(point:unityEngine.Vector3):Bool;
	function SqrDistance(point:unityEngine.Vector3):Float;
	function IntersectRay(ray:unityEngine.Ray, distance:Float):Bool;
	function ToString(format:String):String;
}