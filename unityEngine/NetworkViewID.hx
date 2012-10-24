package unityEngine;
@:native("UnityEngine.NetworkViewID") extern class NetworkViewID {
	var isMine:Bool;
	var owner:unityEngine.NetworkPlayer;
	function ToString():String;
	static var unassigned:unityEngine.NetworkViewID;
}