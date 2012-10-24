package unityEngine;
@:native("UnityEngine.RemoteNotification") extern class RemoteNotification {
	var alertBody:String;
	var hasAction:Bool;
	var applicationIconBadgeNumber:Int;
	var soundName:String;
	var userInfo:unityEngine.IDictionary;
}