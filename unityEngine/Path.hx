package unityEngine;
@:native("UnityEngine.Path") extern class Path {
	function GetDirectoryName(path:String):String;
	function GetExtension(path:String):String;
	function Combine(path1:String, path2:String):String;
	function GetFileNameWithoutExtension(path:String):String;
	function GetFileName(path:String):String;
}