package unityEngine;
@:native("UnityEngine.MasterServer") extern class MasterServer {
	static var ipAddress:String;
	static var port:Int;
	static var updateRate:Int;
	static var dedicatedServer:Bool;
	function RequestHostList(gameTypeName:String):Void;
	function PollHostList():unityEngine.Array<HostData>;
	function RegisterHost(gameTypeName:String, gameName:String, comment:unityEngine.String = ""):Void;
	function UnregisterHost():Void;
	function ClearHostList():Void;
}