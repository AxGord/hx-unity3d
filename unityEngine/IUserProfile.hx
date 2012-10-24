package unityEngine;
@:native("UnityEngine.IUserProfile") extern class IUserProfile {
	var userName:String;
	var userID:String;
	var isFriend:Bool;
	var state:unityEngine.UserState;
	var image:unityEngine.Texture2D;
}