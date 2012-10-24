package unityEngine;
@:native("UnityEngine.ADInterstitialAd") extern class ADInterstitialAd {
	var loaded:Bool;
	var actionInProgress:Bool;
	var visible:Bool;
	var error:unityEngine.ADError;
	function new():Void;
	function CancelAction():Void;
	function Present():Bool;
}