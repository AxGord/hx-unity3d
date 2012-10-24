package unityEngine;
@:native("UnityEngine.GUIUtility") extern class GUIUtility {
	static var hotControl:Int;
	static var keyboardControl:Int;
	function GetControlID(contents:unityEngine.GUIContent, focus:unityEngine.FocusType, position:unityEngine.Rect):Int;
	function GetStateObject(t:unityEngine.Type, controlID:Int):unityEngine.object;
	function QueryStateObject(t:unityEngine.Type, controlID:Int):unityEngine.object;
	function GUIToScreenPoint(guiPoint:unityEngine.Vector2):unityEngine.Vector2;
	function ScreenToGUIPoint(screenPoint:unityEngine.Vector2):unityEngine.Vector2;
	function RotateAroundPivot(angle:Float, pivotPoint:unityEngine.Vector2):Void;
	function ScaleAroundPivot(scale:unityEngine.Vector2, pivotPoint:unityEngine.Vector2):Void;
}