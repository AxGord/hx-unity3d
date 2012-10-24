package unityEngine;
@:native("UnityEngine.AudioSettings") extern class AudioSettings {
	static var driverCaps:unityEngine.AudioSpeakerMode;
	static var speakerMode:unityEngine.AudioSpeakerMode;
	static var outputSampleRate:Int;
	function SetDSPBufferSize(bufferLength:Int, numBuffers:Int):Void;
	function GetDSPBufferSize(out bufferLength:Int, out numBuffers:Int):Void;
}