package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.GUILayout") extern class GUILayout {
	static function Label(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Void;
	@:overload(function(text:String):Void{})
	static function Box(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Void;
	static function Button(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Bool;
	static function RepeatButton(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Bool;
	static function TextField(text:String, maxLength:Int, style:unityEngine.GUIStyle):String;
	//static function PasswordField(password:String, maskChar:unityEngine.char, maxLength:Int, style:unityEngine.GUIStyle):String;
	static function TextArea(text:String, maxLength:Int, style:unityEngine.GUIStyle):String;
	static function Toggle(value:Bool, content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Bool;
	static function Toolbar(selected:Int, contents:NativeArray<GUIContent>, style:unityEngine.GUIStyle):Int;
	static function SelectionGrid(selected:Int, contents:NativeArray<GUIContent>, xCount:Int, style:unityEngine.GUIStyle):Int;
	static function HorizontalSlider(value:Float, leftValue:Float, rightValue:Float, slider:unityEngine.GUIStyle, thumb:unityEngine.GUIStyle):Float;
	static function VerticalSlider(value:Float, leftValue:Float, rightValue:Float, slider:unityEngine.GUIStyle, thumb:unityEngine.GUIStyle):Float;
	static function HorizontalScrollbar(value:Float, size:Float, leftValue:Float, rightValue:Float, style:unityEngine.GUIStyle):Float;
	static function VerticalScrollbar(value:Float, size:Float, topValue:Float, bottomValue:Float, style:unityEngine.GUIStyle):Float;
	static function Space(pixels:Float):Void;
	static function FlexibleSpace():Void;
	static function BeginHorizontal(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Void;
	static function EndHorizontal():Void;
	static function BeginVertical(content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Void;
	static function EndVertical():Void;
	@:overload(function(screenRect:unityEngine.Rect):Void{})
	static function BeginArea(screenRect:unityEngine.Rect, content:unityEngine.GUIContent, style:unityEngine.GUIStyle):Void;
	static function EndArea():Void;
	static function BeginScrollView(scrollPosition:unityEngine.Vector2, alwaysShowHorizontal:Bool, alwaysShowVertical:Bool, horizontalScrollbar:unityEngine.GUIStyle, verticalScrollbar:unityEngine.GUIStyle, background:unityEngine.GUIStyle):unityEngine.Vector2;
	static function EndScrollView():Void;
	//static function Window(id:Int, screenRect:unityEngine.Rect, func:unityEngine.GUI.WindowFunction, content:unityEngine.GUIContent, style:unityEngine.GUIStyle):unityEngine.Rect;
	static function Width(width:Float):unityEngine.GUILayoutOption;
	static function MinWidth(minWidth:Float):unityEngine.GUILayoutOption;
	static function MaxWidth(maxWidth:Float):unityEngine.GUILayoutOption;
	static function Height(height:Float):unityEngine.GUILayoutOption;
	static function MinHeight(minHeight:Float):unityEngine.GUILayoutOption;
	static function MaxHeight(maxHeight:Float):unityEngine.GUILayoutOption;
	static function ExpandWidth(expand:Bool):unityEngine.GUILayoutOption;
	static function ExpandHeight(expand:Bool):unityEngine.GUILayoutOption;
}