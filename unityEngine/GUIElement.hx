package unityEngine;
@:native("UnityEngine.GUIElement") extern class GUIElement extends Behaviour {
	function HitTest(screenPosition:unityEngine.Vector3, camera:unityEngine.Camera = null):Bool;
	function GetScreenRect(camera:unityEngine.Camera = null):unityEngine.Rect;
}