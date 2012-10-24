package unityEngine;
@:native("UnityEngine.AnimationClip") extern class AnimationClip extends Object {
	var length:Float;
	var frameRate:Float;
	var wrapMode:unityEngine.WrapMode;
	var localBounds:unityEngine.Bounds;
	function new():Void;
	function SetCurve(relativePath:String, type:Dynamic, propertyName:String, curve:unityEngine.AnimationCurve):Void;
	function ClearCurves():Void;
	function AddEvent(evt:unityEngine.AnimationEvent):Void;
}