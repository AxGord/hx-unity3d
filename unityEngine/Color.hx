package unityEngine;
@:native("UnityEngine.Color") extern class Color {
	var r:Single;
	var g:Single;
	var b:Single;
	var a:Single;
	var grayscale:Single;
	@:overload(function(r:Single, g:Single, b:Single, a:Single):Void{})
	function new(r:Single, g:Single, b:Single):Void;
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
	static function Lerp(a:unityEngine.Color, b:unityEngine.Color, t:Single):unityEngine.Color;
}