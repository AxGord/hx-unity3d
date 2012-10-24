package unityEngine;
@:native("UnityEngine.GUISkin") extern class GUISkin extends ScriptableObject {
	var font:unityEngine.Font;
	var box:unityEngine.GUIStyle;
	var label:unityEngine.GUIStyle;
	var textField:unityEngine.GUIStyle;
	var textArea:unityEngine.GUIStyle;
	var button:unityEngine.GUIStyle;
	var toggle:unityEngine.GUIStyle;
	var window:unityEngine.GUIStyle;
	var horizontalSlider:unityEngine.GUIStyle;
	var horizontalSliderThumb:unityEngine.GUIStyle;
	var verticalSlider:unityEngine.GUIStyle;
	var verticalSliderThumb:unityEngine.GUIStyle;
	var horizontalScrollbar:unityEngine.GUIStyle;
	var horizontalScrollbarThumb:unityEngine.GUIStyle;
	var horizontalScrollbarLeftButton:unityEngine.GUIStyle;
	var horizontalScrollbarRightButton:unityEngine.GUIStyle;
	var verticalScrollbar:unityEngine.GUIStyle;
	var verticalScrollbarThumb:unityEngine.GUIStyle;
	var verticalScrollbarUpButton:unityEngine.GUIStyle;
	var verticalScrollbarDownButton:unityEngine.GUIStyle;
	var scrollView:unityEngine.GUIStyle;
	var customStyles:unityEngine.Array<GUIStyle>;
	var settings:unityEngine.GUISettings;
	function GetStyle(styleName:String):unityEngine.GUIStyle;
	function FindStyle(styleName:String):unityEngine.GUIStyle;
}