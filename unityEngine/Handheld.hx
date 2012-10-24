package unityEngine;
@:native("UnityEngine.Handheld") extern class Handheld {
	static var use32BitDisplayBuffer:Bool;
	function PlayFullScreenMovie(path:String, bgColor:unityEngine.Color = Color.black, controlMode:unityEngine.FullScreenMovieControlMode = FullScreenMovieControlMode.Full, scalingMode:unityEngine.FullScreenMovieScalingMode = FullScreenMovieScalingMode.AspectFit):Bool;
	function Vibrate():Void;
}