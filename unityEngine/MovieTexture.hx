package unityEngine;
@:native("UnityEngine.MovieTexture") extern class MovieTexture extends Texture {
	var audioClip:unityEngine.AudioClip;
	var loop:Bool;
	var isPlaying:Bool;
	var isReadyToPlay:Bool;
	var duration:Float;
	function Play():Void;
	function Stop():Void;
	function Pause():Void;
}