package unityEngine;
@:native("UnityEngine.Cubemap") extern class Cubemap extends Texture {
	var format:unityEngine.TextureFormat;
	function new(size:Int, format:unityEngine.TextureFormat, mipmap:Bool):Void;
	function SetPixel(face:unityEngine.CubemapFace, x:Int, y:Int, color:unityEngine.Color):Void;
	function GetPixel(face:unityEngine.CubemapFace, x:Int, y:Int):unityEngine.Color;
	function GetPixels(face:unityEngine.CubemapFace, miplevel:unityEngine.int = 0):unityEngine.Array<Color>;
	function SetPixels(colors:unityEngine.Array<Color>, face:unityEngine.CubemapFace, miplevel:unityEngine.int = 0):Void;
	function Apply(updateMipmaps:unityEngine.boolean = true):Void;
}