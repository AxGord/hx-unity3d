package unityEngine;
@:native("UnityEngine.Gizmos") extern class Gizmos {
	static var color:unityEngine.Color;
	static var matrix:unityEngine.Matrix4x4;
	function DrawRay(from:unityEngine.Vector3, direction:unityEngine.Vector3):Void;
	function DrawLine(from:unityEngine.Vector3, to:unityEngine.Vector3):Void;
	function DrawWireSphere(center:unityEngine.Vector3, radius:Float):Void;
	function DrawSphere(center:unityEngine.Vector3, radius:Float):Void;
	function DrawWireCube(center:unityEngine.Vector3, size:unityEngine.Vector3):Void;
	function DrawCube(center:unityEngine.Vector3, size:unityEngine.Vector3):Void;
	function DrawIcon(center:unityEngine.Vector3, name:String, allowScaling:unityEngine.boolean = true):Void;
	function DrawGUITexture(screenRect:unityEngine.Rect, texture:unityEngine.Texture, leftBorder:Int, rightBorder:Int, topBorder:Int, bottomBorder:Int, mat:unityEngine.Material = null):Void;
}