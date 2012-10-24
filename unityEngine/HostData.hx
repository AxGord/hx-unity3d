package unityEngine;
@:native("UnityEngine.HostData") extern class HostData {
	var useNat:Bool;
	var gameType:String;
	var gameName:String;
	var connectedPlayers:Int;
	var playerLimit:Int;
	var ip:unityEngine.Array<string>;
	var port:Int;
	var passwordProtected:Bool;
	var comment:String;
	var guid:String;
}