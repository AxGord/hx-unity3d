package unityEngine;
@:native("UnityEngine.Security") extern class Security {
	function PrefetchSocketPolicy(ip:String, atPort:Int, timeout:unityEngine.int = 3000):Bool;
}