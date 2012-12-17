package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.NetworkView") extern class NetworkView extends Behaviour {
	var observed:unityEngine.Component;
	var stateSynchronization:unityEngine.NetworkStateSynchronization;
	var viewID:unityEngine.NetworkViewID;
	var group:Int;
	var isMine:Bool;
	var owner:unityEngine.NetworkPlayer;
	function RPC(name:String, target:unityEngine.NetworkPlayer, args:NativeArray<Dynamic>):Void;
	function SetScope(player:unityEngine.NetworkPlayer, relevancy:Bool):Bool;
	function Find(viewID:unityEngine.NetworkViewID):unityEngine.NetworkView;
}