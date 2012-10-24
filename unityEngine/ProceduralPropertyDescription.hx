package unityEngine;
@:native("UnityEngine.ProceduralPropertyDescription") extern class ProceduralPropertyDescription {
	var name:String;
	var group:String;
	var type:unityEngine.ProceduralPropertyType;
	var hasRange:Bool;
	var minimum:Float;
	var maximum:Float;
	var step:Float;
	var enumOptions:unityEngine.Array<string>;
}