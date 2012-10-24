package unityEngine;
@:native("UnityEngine.Shader") extern class Shader extends Object {
	var isSupported:Bool;
	var maximumLOD:Int;
	var renderQueue:Int;
	static var globalMaximumLOD:Int;
	function Find(name:String):unityEngine.Shader;
	function SetGlobalColor(propertyName:String, color:unityEngine.Color):Void;
	function SetGlobalVector(propertyName:String, vec:unityEngine.Vector4):Void;
	function SetGlobalFloat(propertyName:String, value:Float):Void;
	function SetGlobalTexture(propertyName:String, tex:unityEngine.Texture):Void;
	function SetGlobalMatrix(propertyName:String, mat:unityEngine.Matrix4x4):Void;
	function PropertyToID(name:String):Int;
	function WarmupAllShaders():Void;
}