package unityEngine;
@:native("UnityEngine.Color32") extern class Color32 {
	var r:Int;
	var g:Int;
	var b:Int;
	var a:Int;
	function new(r:Int, g:Int, b:Int, a:Int):Void;
	function ToString(format:String):String;
	function Lerp(a:unityEngine.Color32, b:unityEngine.Color32, t:Float):unityEngine.Color32;
}