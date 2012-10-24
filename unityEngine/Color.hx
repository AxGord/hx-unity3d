package unityEngine;
@:native("UnityEngine.Color") extern class Color {
	var r:Float;
	var g:Float;
	var b:Float;
	var a:Float;
	var grayscale:Float;
	function new(r:Float, g:Float, b:Float):Void;
	function ToString(format:String):String;
	static var red:unityEngine.Color;
	static var green:unityEngine.Color;
	static var blue:unityEngine.Color;
	static var white:unityEngine.Color;
	static var black:unityEngine.Color;
	static var yellow:unityEngine.Color;
	static var cyan:unityEngine.Color;
	static var magenta:unityEngine.Color;
	static var gray:unityEngine.Color;
	static var grey:unityEngine.Color;
	static var clear:unityEngine.Color;
	function Lerp(a:unityEngine.Color, b:unityEngine.Color, t:Float):unityEngine.Color;
}