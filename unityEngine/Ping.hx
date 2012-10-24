package unityEngine;
@:native("UnityEngine.Ping") extern class Ping {
	var isDone:Bool;
	var time:Int;
	var ip:String;
	function new(address:String):Void;
}