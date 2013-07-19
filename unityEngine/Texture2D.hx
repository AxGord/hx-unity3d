package unityEngine;
@:native("UnityEngine.Texture2D") extern class Texture2D extends Texture {
	var mipmapCount:Int;
	var format:unityEngine.TextureFormat;
	function new(width:Int, height:Int, format:unityEngine.TextureFormat, mipmap:Bool, linear:Bool):Void;
	function SetPixel(x:Int, y:Int, color:unityEngine.Color):Void;
	function GetPixel(x:Int, y:Int):unityEngine.Color;
	function GetPixelBilinear(u:Float, v:Float):unityEngine.Color;
	//function SetPixels(x:Int, y:Int, blockWidth:Int, blockHeight:Int, colors:unityEngine.Array<Color>, miplevel:unityEngine.int = 0):Void;
	//function SetPixels32(colors:unityEngine.Array<Color32>, miplevel:unityEngine.int = 0):Void;
	//function LoadImage(data:unityEngine.Array<byte>):Bool;
	//function GetPixels(x:Int, y:Int, blockWidth:Int, blockHeight:Int, miplevel:unityEngine.int = 0):unityEngine.Array<Color>;
	//function GetPixels32(miplevel:unityEngine.int = 0):unityEngine.Array<Color32>;
	//function Apply(updateMipmaps:unityEngine.boolean = true, makeNoLongerReadable:unityEngine.boolean = false):Void;
	function Resize(width:Int, height:Int):Bool;
	//function EncodeToPNG():unityEngine.Array<byte>;
}