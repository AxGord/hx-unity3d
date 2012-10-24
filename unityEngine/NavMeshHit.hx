package unityEngine;
@:native("UnityEngine.NavMeshHit") extern class NavMeshHit {
	var position:unityEngine.Vector3;
	var normal:unityEngine.Vector3;
	var distance:Float;
	var mask:Int;
	var hit:Bool;
}