package unityEngine;
@:native("UnityEngine.CharacterController") extern class CharacterController extends Collider {
	var isGrounded:Bool;
	var velocity:unityEngine.Vector3;
	var collisionFlags:unityEngine.CollisionFlags;
	var radius:Float;
	var stepOffset:Float;
	var detectCollisions:Bool;
	function SimpleMove(speed:unityEngine.Vector3):Bool;
	function Move(motion:unityEngine.Vector3):unityEngine.CollisionFlags;
}