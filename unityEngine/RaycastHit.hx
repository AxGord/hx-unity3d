package unityEngine;
@:native("UnityEngine.RaycastHit") extern class RaycastHit {
	var point:unityEngine.Vector3;
	var normal:unityEngine.Vector3;
	var barycentricCoordinate:unityEngine.Vector3;
	var distance:Float;
	var triangleIndex:Int;
	var textureCoord:unityEngine.Vector2;
	var textureCoord2:unityEngine.Vector2;
	var lightmapCoord:unityEngine.Vector2;
	var collider:unityEngine.Collider;
	var rigidbody:unityEngine.Rigidbody;
	var transform:unityEngine.Transform;
}