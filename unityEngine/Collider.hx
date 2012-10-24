package unityEngine;
@:native("UnityEngine.Collider") extern class Collider extends Component {
	var enabled:Bool;
	var attachedRigidbody:unityEngine.Rigidbody;
	var isTrigger:Bool;
	var material:unityEngine.PhysicMaterial;
	var sharedMaterial:unityEngine.PhysicMaterial;
	var bounds:unityEngine.Bounds;
	function ClosestPointOnBounds(position:unityEngine.Vector3):unityEngine.Vector3;
	function Raycast(ray:unityEngine.Ray, hitInfo:unityEngine.RaycastHit, distance:Float):Bool;
}