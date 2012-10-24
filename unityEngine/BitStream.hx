package unityEngine;
@:native("UnityEngine.BitStream") extern class BitStream {
	var isReading:Bool;
	var isWriting:Bool;
	function Serialize(ref viewID:unityEngine.NetworkViewID):Void;
}