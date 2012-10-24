package unityEngine;
@:native("UnityEngine.AnimationEvent") extern class AnimationEvent {
	var stringParameter:String;
	var floatParameter:Float;
	var intParameter:Int;
	var objectReferenceParameter:unityEngine.Object;
	var functionName:String;
	var time:Float;
	var messageOptions:unityEngine.SendMessageOptions;
	var animationState:unityEngine.AnimationState;
	function new():Void;
}