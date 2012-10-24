package unityEngine;
@:native("UnityEngine.ILeaderboard") extern class ILeaderboard {
	var id:String;
	var userScope:unityEngine.UserScope;
	var range:unityEngine.Range;
	var timeScope:unityEngine.TimeScope;
	var loading:Bool;
	var localUserScore:unityEngine.Score;
	var maxRange:UInt;
	var scores:unityEngine.Array<Score>;
	var title:String;
	function SetUserFilter(userIDs:unityEngine.Array<string>):Void;
	function LoadScores(callback:unityEngine.Action&lt;bool&gt;):Void;
}