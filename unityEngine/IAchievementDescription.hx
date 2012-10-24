package unityEngine;
@:native("UnityEngine.IAchievementDescription") extern class IAchievementDescription {
	var id:String;
	var title:String;
	var image:unityEngine.Texture2D;
	var achievedDescription:String;
	var unachievedDescription:String;
	var hidden:Bool;
	var points:Int;
}