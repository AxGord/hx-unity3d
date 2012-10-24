package unityEngine;
@:native("UnityEngine.AudioSource") extern class AudioSource extends Behaviour {
	var volume:Float;
	var pitch:Float;
	var isPlaying:Bool;
	var loop:Bool;
	var ignoreListenerVolume:Bool;
	var playOnAwake:Bool;
	var velocityUpdateMode:unityEngine.AudioVelocityUpdateMode;
	var panLevel:Float;
	var bypassEffects:Bool;
	var dopplerLevel:Float;
	var spread:Float;
	var priority:Int;
	var mute:Bool;
	var minDistance:Float;
	var maxDistance:Float;
	var pan:Float;
	var rolloffMode:unityEngine.AudioRolloffMode;
	function PlayOneShot(clip:unityEngine.AudioClip, volumeScale:Float = 1.0):Void;
	function GetOutputData(samples:unityEngine.Array<Float>, channel:Int):Void;
	function GetSpectrumData(samples:unityEngine.Array<Float>, channel:Int, window:unityEngine.FFTWindow):Void;
	function PlayClipAtPoint(clip:unityEngine.AudioClip, position:unityEngine.Vector3, volume:Float = 1.0):Void;
}