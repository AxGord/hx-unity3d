package unityEngine;
@:native("UnityEngine.TouchScreenKeyboard") extern class TouchScreenKeyboard {
	var text:String;
	var active:Bool;
	var done:Bool;
	static var hideInput:Bool;
	static var autorotateToPortrait:Bool;
	static var autorotateToPortraitUpsideDown:Bool;
	static var autorotateToLandscapeLeft:Bool;
	static var autorotateToLandscapeRight:Bool;
	static var area:unityEngine.Rect;
	static var visible:Bool;
	function Open(text:String, keyboardType:unityEngine.TouchScreenKeyboardType = TouchScreenKeyboardType.Default, autocorrection:unityEngine.boolean = true, multiline:unityEngine.boolean = false, secure:unityEngine.boolean = false, alert:unityEngine.boolean = false, textPlaceholder:unityEngine.String = ""):unityEngine.TouchScreenKeyboard;
}