package unityEngine;
@:native("UnityEngine.Compass") extern class Compass {
	var magneticHeading:Float;
	var trueHeading:Float;
	var rawVector:unityEngine.Vector3;
	var timestamp:Float;
	var enabled:Bool;
}