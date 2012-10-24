package unityEngine;
@:native("UnityEngine.iPhone") extern class iPhone {
	static var generation:unityEngine.iPhoneGeneration;
	function SetNoBackupFlag(path:String):Void;
	function ResetNoBackupFlag(path:String):Void;
}