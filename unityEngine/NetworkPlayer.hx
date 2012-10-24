package unityEngine;
@:native("UnityEngine.NetworkPlayer") extern class NetworkPlayer {
	var ipAddress:String;
	var port:Int;
	var guid:String;
	var externalIP:String;
	var externalPort:Int;
	function ToString():String;
}