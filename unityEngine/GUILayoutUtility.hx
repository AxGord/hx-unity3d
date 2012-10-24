package unityEngine;
@:native("UnityEngine.GUILayoutUtility") extern class GUILayoutUtility {
	function GetRect(minWidth:Float, maxWidth:Float, minHeight:Float, maxHeight:Float, style:unityEngine.GUIStyle, params options:unityEngine.Array<GUILayoutOption>):unityEngine.Rect;
	function GetLastRect():unityEngine.Rect;
	function GetAspectRect(aspect:Float, style:unityEngine.GUIStyle, params options:unityEngine.Array<GUILayoutOption>):unityEngine.Rect;
}