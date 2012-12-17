package unityEngine;
@:native("UnityEngine.Screen") extern class Screen {
	static var resolutions:cs.NativeArray<Resolution>;
	static var currentResolution:unityEngine.Resolution;
	static var showCursor:Bool;
	static var lockCursor:Bool;
	static var width:Int;
	static var height:Int;
	static var dpi:Float;
	static var fullScreen:Bool;
	static var autorotateToPortrait:Bool;
	static var autorotateToPortraitUpsideDown:Bool;
	static var autorotateToLandscapeLeft:Bool;
	static var autorotateToLandscapeRight:Bool;
	static var orientation:unityEngine.ScreenOrientation;
	static var sleepTimeout:Int;
	@:overload(function(width:Int, height:Int, fullscreen:Bool, preferredRefreshRate:Int):Void{})
	static function SetResolution(width:Int, height:Int, fullscreen:Bool):Void;
}