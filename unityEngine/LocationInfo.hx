package unityEngine;
@:native("UnityEngine.LocationInfo") extern class LocationInfo {
	var latitude:Float;
	var longitude:Float;
	var altitude:Float;
	var horizontalAccuracy:Float;
	var verticalAccuracy:Float;
	var timestamp:unityEngine.double;
}