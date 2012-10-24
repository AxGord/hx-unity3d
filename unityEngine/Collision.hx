package unityEngine;
@:native("UnityEngine.Collision") extern class Collision {
	var relativeVelocity:unityEngine.Vector3;
	var rigidbody:unityEngine.Rigidbody;
	var collider:unityEngine.Collider;
	var transform:unityEngine.Transform;
	var gameObject:unityEngine.GameObject;
	var contacts:unityEngine.Array<ContactPoint>;
}