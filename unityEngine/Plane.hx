package unityEngine;
@:native("UnityEngine.Plane") extern class Plane {
	var normal:unityEngine.Vector3;
	var distance:Float;
	function new(a:unityEngine.Vector3, b:unityEngine.Vector3, c:unityEngine.Vector3):Void;
	function SetNormalAndPosition(inNormal:unityEngine.Vector3, inPoint:unityEngine.Vector3):Void;
	function Set3Points(a:unityEngine.Vector3, b:unityEngine.Vector3, c:unityEngine.Vector3):Void;
	function GetDistanceToPoint(inPt:unityEngine.Vector3):Float;
	function GetSide(inPt:unityEngine.Vector3):Bool;
	function SameSide(inPt0:unityEngine.Vector3, inPt1:unityEngine.Vector3):Bool;
	function Raycast(ray:unityEngine.Ray, out enter:Float):Bool;
}