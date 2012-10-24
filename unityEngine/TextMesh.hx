package unityEngine;
@:native("UnityEngine.TextMesh") extern class TextMesh extends Component {
	var text:String;
	var font:unityEngine.Font;
	var fontSize:Int;
	var fontStyle:unityEngine.FontStyle;
	var offsetZ:Float;
	var alignment:unityEngine.TextAlignment;
	var anchor:unityEngine.TextAnchor;
	var characterSize:Float;
	var lineSpacing:Float;
	var tabSize:Float;
}