package unityEngine;
@:native("UnityEngine.PhysicMaterial") extern class PhysicMaterial extends Object {
	var dynamicFriction:Float;
	var staticFriction:Float;
	var bounciness:Float;
	var frictionDirection2:unityEngine.Vector3;
	var dynamicFriction2:Float;
	var staticFriction2:Float;
	var frictionCombine:unityEngine.PhysicMaterialCombine;
	var bounceCombine:unityEngine.PhysicMaterialCombine;
	function new(name:String):Void;
}