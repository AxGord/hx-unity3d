package unityEngine;
@:native("UnityEngine.ADBannerView") extern class ADBannerView {
	var requiredSizeIdentifiers:unityEngine.Array<ADSizeIdentifier>;
	var currentSizeIdentifier:unityEngine.ADSizeIdentifier;
	var autoSize:Bool;
	var position:unityEngine.Vector2;
	var autoPosition:unityEngine.ADPosition;
	var visible:Bool;
	var loaded:Bool;
	var actionInProgress:Bool;
	var error:unityEngine.ADError;
	function new():Void;
	function Show():Void;
	function Hide():Void;
	function CancelAction():Void;
	function GetSizeFromSizeIdentifier(identifier:unityEngine.ADSizeIdentifier):unityEngine.Vector2;
}