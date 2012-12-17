package unityEngine;
@:native("UnityEngine.Time") extern class Time {
	static var time:Single;
	static var timeSinceLevelLoad:Single;
	static var deltaTime:Single;
	static var fixedTime:Single;
	static var fixedDeltaTime:Single;
	static var maximumDeltaTime:Single;
	static var smoothDeltaTime:Single;
	static var timeScale:Single;
	static var frameCount:Int;
	static var realtimeSinceStartup:Single;
	static var captureFramerate:Int;
}