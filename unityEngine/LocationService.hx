package unityEngine;
@:native("UnityEngine.LocationService") extern class LocationService {
	var isEnabledByUser:Bool;
	var status:unityEngine.LocationServiceStatus;
	var lastData:unityEngine.LocationInfo;
	function Start(desiredAccuracyInMeters:unityEngine.float = 10f, updateDistanceInMeters:unityEngine.float = 10f):Void;
	function Stop():Void;
}