package unityEngine;
@:native("UnityEngine.MaterialPropertyBlock") extern class MaterialPropertyBlock {
	function AddFloat(nameID:Int, value:Float):Void;
	function AddVector(nameID:Int, value:unityEngine.Vector4):Void;
	function AddColor(nameID:Int, value:unityEngine.Color):Void;
	function AddMatrix(nameID:Int, value:unityEngine.Matrix4x4):Void;
	function Clear():Void;
}