package unityEngine;
@:native("UnityEngine.RenderTexture") extern class RenderTexture extends Texture {
	//var width:Int;
	//var height:Int;
	var depth:Int;
	var sRGB:Bool;
	var format:unityEngine.RenderTextureFormat;
	var useMipMap:Bool;
	var isCubemap:Bool;
	var colorBuffer:unityEngine.RenderBuffer;
	var depthBuffer:unityEngine.RenderBuffer;
	function new(width:Int, height:Int, depth:Int):Void;
	function Create():Bool;
	function Release():Void;
	function IsCreated():Bool;
	function DiscardContents():Void;
	function SetGlobalShaderProperty(propertyName:String):Void;
	static var active:unityEngine.RenderTexture;
	function GetTemporary(width:Int, height:Int, depthBuffer:Int = 0, format:unityEngine.RenderTextureFormat = RenderTextureFormat.Default, readWrite:unityEngine.RenderTextureReadWrite = RenderTextureReadWrite.Default):unityEngine.RenderTexture;
	function ReleaseTemporary(temp:unityEngine.RenderTexture):Void;
}