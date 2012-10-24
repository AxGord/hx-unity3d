package unityEngine;
@:native("UnityEngine.GameCenterPlatform") extern class GameCenterPlatform extends ISocialPlatform {
	function ResetAllAchievements(callback:unityEngine.Action&lt;bool&gt;):Void;
	function ShowDefaultAchievementCompletionBanner(value:Bool):Void;
}