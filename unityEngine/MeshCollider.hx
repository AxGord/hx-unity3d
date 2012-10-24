package unityEngine;
@:native("UnityEngine.MeshCollider") extern class MeshCollider extends Collider {
	var sharedMesh:unityEngine.Mesh;
	var convex:Bool;
	var smoothSphereCollisions:Bool;
}