package unityEngine;
@:native("UnityEngine.NavMeshPath") extern class NavMeshPath {
	var corners:unityEngine.Array<Vector3>;
	var status:unityEngine.NavMeshPathStatus;
	function new():Void;
	function ClearCorners():Void;
}