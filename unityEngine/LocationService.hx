package unityEngine;
@:native("UnityEngine.LocationService") extern class LocationService {
	var isEnabledByUser:Bool;
	var status:unityEngine.LocationServiceStatus;
	var lastData:unityEngine.LocationInfo;
	function Start(desiredAccuracyInMeters:Float = 10, updateDistanceInMeters:Float = 10):Void;
	function Stop():Void;
}