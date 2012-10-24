package unityEngine;
@:native("UnityEngine.Profiler") extern class Profiler {
	static var logFile:String;
	static var enableBinaryLog:Bool;
	static var enabled:Bool;
	static var usedHeapSize:UInt;
	function AddFramesFromFile(file:String):Void;
	function BeginSample(name:String, targetObject:unityEngine.Object):Void;
	function EndSample():Void;
	function GetRuntimeMemorySize(o:unityEngine.Object):Int;
}