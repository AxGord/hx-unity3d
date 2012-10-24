package unityEngine;
@:native("UnityEngine.GUIText") extern class GUIText extends GUIElement {
	var text:String;
	var material:unityEngine.Material;
	var pixelOffset:unityEngine.Vector2;
	var font:unityEngine.Font;
	var alignment:unityEngine.TextAlignment;
	var anchor:unityEngine.TextAnchor;
	var lineSpacing:Float;
	var tabSize:Float;
	var fontSize:Int;
	var fontStyle:unityEngine.FontStyle;
}