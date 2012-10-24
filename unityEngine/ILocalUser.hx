package unityEngine;
@:native("UnityEngine.ILocalUser") extern class ILocalUser extends IUserProfile {
	var friends:unityEngine.Array<IUserProfile>;
	var authenticated:Bool;
	var underage:Bool;
	function Authenticate(callback:unityEngine.System.Action&lt;bool&gt;):Void;
	function LoadFriends(callback:unityEngine.System.Action&lt;bool&gt;):Void;
}