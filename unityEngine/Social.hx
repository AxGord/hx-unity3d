package unityEngine;
@:native("UnityEngine.Social") extern class Social {
	static var localUser:unityEngine.ILocalUser;
	function CreateAchievement():unityEngine.IAchievement;
	function CreateLeaderboard():unityEngine.ILeaderboard;
	function LoadAchievementDescriptions(callback:unityEngine.Array<System.Action&lt;IAchievementDescription&gt;>):Void;
	function ReportProgress(id:String, progress:unityEngine.double, callback:unityEngine.System.Action&lt;bool&gt;):Void;
	function LoadAchievements(callback:unityEngine.Array<System.Action&lt;IAchievement&gt;>):Void;
	function ReportScore(score:unityEngine.Int64, board:String, callback:unityEngine.System.Action&lt;bool&gt;):Void;
	function LoadScores(leaderboardID:String, callback:unityEngine.Array<System.Action&lt;Score&gt;>):Void;
	function LoadUsers(userIds:unityEngine.Array<string>, callback:unityEngine.Array<Action&lt;IUserProfile&gt;>):Void;
	function ShowAchievementsUI():Void;
	function ShowLeaderboardUI():Void;
}