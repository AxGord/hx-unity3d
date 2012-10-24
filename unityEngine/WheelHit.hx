package unityEngine;
@:native("UnityEngine.WheelHit") extern class WheelHit {
	var collider:unityEngine.Collider;
	var point:unityEngine.Vector3;
	var normal:unityEngine.Vector3;
	var forwardDir:unityEngine.Vector3;
	var sidewaysDir:unityEngine.Vector3;
	var force:Float;
	var forwardSlip:Float;
	var sidewaysSlip:Float;
}