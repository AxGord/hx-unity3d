package unityEngine;
@:native("UnityEngine.Debug") extern class Debug {
	static var isDebugBuild:Bool;
	function DrawLine(start:unityEngine.Vector3, end:unityEngine.Vector3, color:unityEngine.Color = Color.white, duration:unityEngine.float = 0.0f, depthTest:unityEngine.boolean = true):Void;
	function DrawRay(start:unityEngine.Vector3, dir:unityEngine.Vector3, color:unityEngine.Color = Color.white, duration:unityEngine.float = 0.0f, depthTest:unityEngine.boolean = true;):Void;
	function Break():Void;
	function Log(message:unityEngine.object, context:unityEngine.Object):Void;
	function LogError(message:unityEngine.object, context:unityEngine.Object):Void;
	function LogWarning(message:unityEngine.object, context:unityEngine.Object):Void;
}