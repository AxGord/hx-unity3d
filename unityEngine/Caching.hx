package unityEngine;
@:native("UnityEngine.Caching") extern class Caching {
	static var spaceFree:unityEngine.long;
	static var maximumAvailableDiskSpace:unityEngine.long;
	static var spaceOccupied:unityEngine.long;
	static var expirationDelay:Int;
	static var enabled:Bool;
	static var ready:Bool;
	function Authorize(name:String, domain:String, size:unityEngine.long, expiration:Int, signature:String):Bool;
	function CleanCache():Bool;
	function IsVersionCached(url:String, version:Int):Bool;
	function MarkAsUsed(url:String, version:Int):Bool;
	function SetNoBackupFlag(url:String, version:Int):Void;
	function ResetNoBackupFlag(url:String, version:Int):Void;
}