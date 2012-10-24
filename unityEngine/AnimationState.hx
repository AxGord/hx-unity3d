package unityEngine;
@:native("UnityEngine.AnimationState") extern class AnimationState {
	var enabled:Bool;
	var weight:Float;
	var wrapMode:unityEngine.WrapMode;
	var time:Float;
	var normalizedTime:Float;
	var speed:Float;
	var normalizedSpeed:Float;
	var length:Float;
	var layer:Int;
	var clip:unityEngine.AnimationClip;
	var name:String;
	var blendMode:unityEngine.AnimationBlendMode;
	function AddMixingTransform(mix:unityEngine.Transform, recursive:Bool = true):Void;
	function RemoveMixingTransform(mix:unityEngine.Transform):Void;
}