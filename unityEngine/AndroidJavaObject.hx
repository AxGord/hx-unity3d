package unityEngine;
@:native("UnityEngine.AndroidJavaObject") extern class AndroidJavaObject {
	function new(className:String, params args:unityEngine.Array<object>):Void;
	function Call(methodName:String, params args:unityEngine.Array<object>):unityEngine.ReturnType;
	function CallStatic(methodName:String, params args:unityEngine.Array<object>):unityEngine.ReturnType;
	function Get(fieldName:String):unityEngine.FieldType;
	function Set(fieldName:String, val:unityEngine.FieldType):Void;
	function GetStatic(fieldName:String):unityEngine.FieldType;
	function SetStatic(fieldName:String, val:unityEngine.FieldType):Void;
	function GetRawObject():cs.Pointer<Int>;
	function GetRawClass():cs.Pointer<Int>;
	function Call(methodName:String, params args:unityEngine.Array<object>):unityEngine.ReturnType;
	function CallStatic(methodName:String, params args:unityEngine.Array<object>):unityEngine.ReturnType;
}