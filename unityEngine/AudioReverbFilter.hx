package unityEngine;
@:native("UnityEngine.AudioReverbFilter") extern class AudioReverbFilter extends Behaviour {
	var reverbPreset:unityEngine.AudioReverbPreset;
	var dryLevel:Float;
	var room:Float;
	var roomHF:Float;
	var roomRolloff:Float;
	var decayTime:Float;
	var decayHFRatio:Float;
	var reflectionsLevel:Float;
	var reflectionsDelay:Float;
	var reverbLevel:Float;
	var hfReference:Float;
	var roomLF:Float;
	var lFReference:Float;
}