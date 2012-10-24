package unityEngine;
@:native("UnityEngine.Gyroscope") extern class Gyroscope {
	var rotationRate:unityEngine.Vector3;
	var rotationRateUnbiased:unityEngine.Vector3;
	var gravity:unityEngine.Vector3;
	var userAcceleration:unityEngine.Vector3;
	var attitude:unityEngine.Quaternion;
	var enabled:Bool;
	var updateInterval:Float;
}