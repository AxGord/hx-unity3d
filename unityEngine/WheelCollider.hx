package unityEngine;
@:native("UnityEngine.WheelCollider") extern class WheelCollider extends Collider {
	var center:unityEngine.Vector3;
	var radius:Float;
	var suspensionDistance:Float;
	var suspensionSpring:unityEngine.JointSpring;
	var mass:Float;
	var forwardFriction:unityEngine.WheelFrictionCurve;
	var sidewaysFriction:unityEngine.WheelFrictionCurve;
	var motorTorque:Float;
	var brakeTorque:Float;
	var steerAngle:Float;
	var isGrounded:Bool;
	var rpm:Float;
	function GetGroundHit(out hit:unityEngine.WheelHit):Bool;
}