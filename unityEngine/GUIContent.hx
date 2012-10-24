package unityEngine;
@:native("UnityEngine.GUIContent") extern class GUIContent {
	var text:String;
	var image:unityEngine.Texture;
	var tooltip:String;
	function new(src:unityEngine.GUIContent):Void;
	static var none:unityEngine.GUIContent;
}