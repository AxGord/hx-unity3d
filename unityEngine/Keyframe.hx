package unityEngine;
@:native("UnityEngine.Keyframe") extern class Keyframe {
	var time:Float;
	var value:Float;
	var inTangent:Float;
	var outTangent:Float;
	function new(time:Float, value:Float, inTangent:Float, outTangent:Float):Void;
}