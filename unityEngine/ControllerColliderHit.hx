package unityEngine;
@:native("UnityEngine.ControllerColliderHit") extern class ControllerColliderHit {
	var controller:unityEngine.CharacterController;
	var collider:unityEngine.Collider;
	var rigidbody:unityEngine.Rigidbody;
	var gameObject:unityEngine.GameObject;
	var transform:unityEngine.Transform;
	var point:unityEngine.Vector3;
	var normal:unityEngine.Vector3;
	var moveDirection:unityEngine.Vector3;
	var moveLength:Float;
}