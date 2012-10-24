package unityEngine;
@:native("UnityEngine.Touch") extern class Touch {
	var fingerId:Int;
	var position:unityEngine.Vector2;
	var deltaPosition:unityEngine.Vector2;
	var deltaTime:Float;
	var tapCount:Int;
	var phase:unityEngine.TouchPhase;
}