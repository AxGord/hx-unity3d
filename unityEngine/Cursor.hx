package unityEngine;

@:native("UnityEngine.Cursor") extern class Cursor {
	static function SetCursor(texture: Texture2D, hotspot: Vector2, cursorMode: CursorMode):Void;
}