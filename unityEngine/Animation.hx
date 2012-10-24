package unityEngine;
@:native("UnityEngine.Animation") extern class Animation extends Behaviour {
	var clip:unityEngine.AnimationClip;
	var playAutomatically:Bool;
	var wrapMode:unityEngine.WrapMode;
	var isPlaying:Bool;
	var animatePhysics:Bool;
	var cullingType:unityEngine.AnimationCullingType;
	var localBounds:unityEngine.Bounds;
	function Stop(name:String):Void;
	function Rewind():Void;
	function Sample():Void;
	function IsPlaying(name:String):Bool;
	function Play(animation:String, mode:unityEngine.PlayMode = PlayMode.StopSameLayer):Bool;
	function CrossFade(animation:String, fadeLength:Float = 0.3, mode:unityEngine.PlayMode = PlayMode.StopSameLayer):Void;
	function Blend(animation:String, targetWeight:Float = 1.0, fadeLength:Float = 0.3):Void;
	function CrossFadeQueued(animation:String, fadeLength:Float = 0.3, queue:unityEngine.QueueMode = QueueMode.CompleteOthers, mode:unityEngine.PlayMode = PlayMode.StopSameLayer):unityEngine.AnimationState;
	function PlayQueued(animation:String, queue:unityEngine.QueueMode = QueueMode.CompleteOthers, mode:unityEngine.PlayMode = PlayMode.StopSameLayer):unityEngine.AnimationState;
	function AddClip(clip:unityEngine.AnimationClip, newName:String, firstFrame:Int, lastFrame:Int, addLoopFrame:Bool = false):Void;
	function RemoveClip(clipName:String):Void;
	function GetClipCount():Int;
	function SyncLayer(layer:Int):Void;
}