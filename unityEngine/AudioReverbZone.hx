package unityEngine;
@:native("UnityEngine.AudioReverbZone") extern class AudioReverbZone extends Behaviour {
	var minDistance:Float;
	var maxDistance:Float;
	var reverbPreset:unityEngine.AudioReverbPreset;
	var room:Int;
	var roomHF:Int;
	var roomLF:Int;
	var decayTime:Float;
	var decayHFRatio:Float;
	var reflections:Int;
	var reflectionsDelay:Float;
	var reverb:Int;
	var reverbDelay:Float;
	var roomRolloffFactor:Float;
	var diffusion:Float;
	var density:Float;
}