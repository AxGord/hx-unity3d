package unityEngine;
@:native("UnityEngine.Event") extern class Event {
	var type:unityEngine.EventType;
	var mousePosition:unityEngine.Vector2;
	var delta:unityEngine.Vector2;
	var button:Int;
	var modifiers:unityEngine.EventModifiers;
	var clickCount:Int;
	var character:unityEngine.char;
	var commandName:String;
	var keyCode:unityEngine.KeyCode;
	var shift:Bool;
	var control:Bool;
	var alt:Bool;
	var command:Bool;
	var capsLock:Bool;
	var numeric:Bool;
	var functionKey:Bool;
	var isKey:Bool;
	var isMouse:Bool;
	function GetTypeForControl(controlID:Int):unityEngine.EventType;
	function Use():Void;
	static var current:unityEngine.Event;
	function KeyboardEvent(key:String):unityEngine.Event;
}