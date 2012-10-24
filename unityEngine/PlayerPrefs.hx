package unityEngine;
@:native("UnityEngine.PlayerPrefs") extern class PlayerPrefs {
	function SetInt(key:String, value:Int):Void;
	function GetInt(key:String, defaultValue:unityEngine.int = 0):Int;
	function SetFloat(key:String, value:Float):Void;
	function GetFloat(key:String, defaultValue:unityEngine.float = 0.0F):Float;
	function SetString(key:String, value:String):Void;
	function GetString(key:String, defaultValue:unityEngine.String = ""):String;
	function HasKey(key:String):Bool;
	function DeleteKey(key:String):Void;
	function DeleteAll():Void;
	function Save():Void;
}