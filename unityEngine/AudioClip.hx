package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.AudioClip") extern class AudioClip extends Object {
	var length:Float;
	var samples:Int;
	var channels:Int;
	var frequency:Int;
	var isReadyToPlay:Bool;
	function GetData(data:NativeArray<Float>, offsetSamples:Int):Void;
	function SetData(data:NativeArray<Float>, offsetSamples:Int):Void;
	function Create(name:String, lengthSamples:Int, channels:Int, frequency:Int, _3D:Bool, stream:Bool, pcmreadercallback:Dynamic, pcmsetpositioncallback:Dynamic):unityEngine.AudioClip;
}