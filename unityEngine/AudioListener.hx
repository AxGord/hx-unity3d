package unityEngine;
@:native("UnityEngine.AudioListener") extern class AudioListener extends Behaviour {
	var velocityUpdateMode:unityEngine.AudioVelocityUpdateMode;
	static var volume:Float;
	static var pause:Bool;
	function GetOutputData(samples:unityEngine.Array<float>, channel:Int):Void;
	function GetSpectrumData(samples:unityEngine.Array<float>, channel:Int, window:unityEngine.FFTWindow):Void;
}