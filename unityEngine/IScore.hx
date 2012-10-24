package unityEngine;
@:native("UnityEngine.IScore") extern class IScore {
	var leaderboardID:String;
	var value:unityEngine.Int64;
	var date:unityEngine.DateTime;
	var formattedValue:String;
	var userID:String;
	var rank:Int;
	function ReportScore(callback:unityEngine.System.Action&lt;bool&gt;):Void;
}