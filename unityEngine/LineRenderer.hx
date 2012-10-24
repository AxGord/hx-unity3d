package unityEngine;
@:native("UnityEngine.LineRenderer") extern class LineRenderer extends Renderer {
	var useWorldSpace:Bool;
	function SetWidth(start:Float, end:Float):Void;
	function SetColors(start:unityEngine.Color, end:unityEngine.Color):Void;
	function SetVertexCount(count:Int):Void;
	function SetPosition(index:Int, position:unityEngine.Vector3):Void;
}