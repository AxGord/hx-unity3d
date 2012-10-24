package unityEngine;
@:native("UnityEngine.LocalNotification") extern class LocalNotification {
	var fireDate:unityEngine.DateTime;
	var timeZone:String;
	var repeatInterval:unityEngine.CalendarUnit;
	var repeatCalendar:unityEngine.CalendarIdentifier;
	var alertBody:String;
	var alertAction:String;
	var hasAction:Bool;
	var alertLaunchImage:String;
	var applicationIconBadgeNumber:Int;
	var soundName:String;
	var userInfo:unityEngine.IDictionary;
	function new():Void;
	static var defaultSoundName:String;
}