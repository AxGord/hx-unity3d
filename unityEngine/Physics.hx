package unityEngine;
@:native("UnityEngine.Physics") extern class Physics {
	static var gravity:unityEngine.Vector3;
	static var minPenetrationForPenalty:Float;
	static var bounceThreshold:Float;
	static var sleepVelocity:Float;
	static var sleepAngularVelocity:Float;
	static var maxAngularVelocity:Float;
	static var solverIterationCount:Int;
	function Raycast(ray:unityEngine.Ray, out hitInfo:unityEngine.RaycastHit, distance:unityEngine.float = Mathf.Infinity, layerMask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function RaycastAll(origin:unityEngine.Vector3, direction:unityEngine.Vector3, distance:unityEngine.float = Mathf.Infinity, layermask:unityEngine.int = kDefaultRaycastLayers):unityEngine.Array<RaycastHit>;
	function Linecast(start:unityEngine.Vector3, end:unityEngine.Vector3, out hitInfo:unityEngine.RaycastHit, layerMask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function OverlapSphere(position:unityEngine.Vector3, radius:Float, layerMask:unityEngine.int = kAllLayers):unityEngine.Array<Collider>;
	function CapsuleCast(point1:unityEngine.Vector3, point2:unityEngine.Vector3, radius:Float, direction:unityEngine.Vector3, out hitInfo:unityEngine.RaycastHit, distance:unityEngine.float = Mathf.Infinity, layerMask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function SphereCast(ray:unityEngine.Ray, radius:Float, out hitInfo:unityEngine.RaycastHit, distance:unityEngine.float = Mathf.Infinity, layerMask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function CapsuleCastAll(point1:unityEngine.Vector3, point2:unityEngine.Vector3, radius:Float, direction:unityEngine.Vector3, distance:unityEngine.float = Mathf.Infinity, layermask:unityEngine.int = kDefaultRaycastLayers):unityEngine.Array<RaycastHit>;
	function SphereCastAll(ray:unityEngine.Ray, radius:Float, distance:unityEngine.float = Mathf.Infinity, layerMask:unityEngine.int = kDefaultRaycastLayers):unityEngine.Array<RaycastHit>;
	function CheckSphere(position:unityEngine.Vector3, radius:Float, layerMask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function CheckCapsule(start:unityEngine.Vector3, end:unityEngine.Vector3, radius:Float, layermask:unityEngine.int = kDefaultRaycastLayers):Bool;
	function IgnoreCollision(collider1:unityEngine.Collider, collider2:unityEngine.Collider, ignore:unityEngine.boolean = true):Void;
	function IgnoreLayerCollision(layer1:Int, layer2:Int, ignore:unityEngine.boolean = true):Void;
	function GetIgnoreLayerCollision(layer1:Int, layer2:Int):Bool;
}