package unityEngine;
@:native("UnityEngine.AnimationCurve") extern class AnimationCurve {
	var keys:unityEngine.Array<Keyframe>;
	var length:Int;
	var preWrapMode:unityEngine.WrapMode;
	var postWrapMode:unityEngine.WrapMode;
	function new():Void;
	function Evaluate(time:Float):Float;
	function AddKey(key:unityEngine.Keyframe):Int;
	function MoveKey(index:Int, key:unityEngine.Keyframe):Int;
	function RemoveKey(index:Int):Void;
	function SmoothTangents(index:Int, weight:Float):Void;
	function Linear(timeStart:Float, valueStart:Float, timeEnd:Float, valueEnd:Float):unityEngine.AnimationCurve;
	function EaseInOut(timeStart:Float, valueStart:Float, timeEnd:Float, valueEnd:Float):unityEngine.AnimationCurve;
}