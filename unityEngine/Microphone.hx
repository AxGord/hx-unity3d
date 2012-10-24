package unityEngine;
@:native("UnityEngine.Microphone") extern class Microphone {
	static var devices:unityEngine.Array<string>;
	function Start(deviceName:String, loop:Bool, lengthSec:Int, frequency:Int):unityEngine.AudioClip;
	function End(deviceName:String):Void;
	function IsRecording(deviceName:String):Bool;
	function GetPosition(deviceName:String):Int;
	function GetDeviceCaps(deviceName:String, out minFreq:Int, out maxFreq:Int):Void;
}