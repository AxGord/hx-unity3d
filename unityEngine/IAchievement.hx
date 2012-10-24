package unityEngine;
@:native("UnityEngine.IAchievement") extern class IAchievement {
	var id:String;
	var percentCompleted:unityEngine.double;
	var completed:Bool;
	var hidden:Bool;
	var lastReportedDate:unityEngine.DateTime;
	function ReportProgress(callback:unityEngine.System.Action&lt;bool&gt;):Void;
}