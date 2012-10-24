package unityEngine;
@:native("UnityEngine.AsyncOperation") extern class AsyncOperation extends YieldInstruction {
	var isDone:Bool;
	var progress:Float;
	var priority:Int;
}