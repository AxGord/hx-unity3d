package unityEngine;
@:native("UnityEngine.Texture") extern class Texture extends Object {
	var width:Int;
	var height:Int;
	var filterMode:unityEngine.FilterMode;
	var anisoLevel:Int;
	var wrapMode:unityEngine.TextureWrapMode;
	var mipMapBias:Float;
	function GetNativeTextureID():Int;
}