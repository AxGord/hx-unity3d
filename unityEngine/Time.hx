package unityEngine;
@:native("UnityEngine.Time") extern class Time {
	static var time:Float;
	static var timeSinceLevelLoad:Float;
	static var deltaTime:Float;
	static var fixedTime:Float;
	static var fixedDeltaTime:Float;
	static var maximumDeltaTime:Float;
	static var smoothDeltaTime:Float;
	static var timeScale:Float;
	static var frameCount:Int;
	static var realtimeSinceStartup:Float;
	static var captureFramerate:Int;
}