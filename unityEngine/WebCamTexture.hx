package unityEngine;
@:native("UnityEngine.WebCamTexture") extern class WebCamTexture extends Texture {
	var isPlaying:Bool;
	var deviceName:String;
	var requestedFPS:Float;
	var requestedWidth:Int;
	var requestedHeight:Int;
	var didUpdateThisFrame:Bool;
	function new():Void;
	function Play():Void;
	function Pause():Void;
	function Stop():Void;
	function GetPixel(x:Int, y:Int):unityEngine.Color;
	function GetPixels(x:Int, y:Int, blockWidth:Int, blockHeight:Int):unityEngine.Array<Color>;
	function GetPixels32(colors:unityEngine.Array<Color32 = null>):unityEngine.Array<Color32>;
	static var devices:unityEngine.Array<WebCamDevice>;
}