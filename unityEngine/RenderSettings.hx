package unityEngine;
@:native("UnityEngine.RenderSettings") extern class RenderSettings {
	static var fog:Bool;
	static var fogMode:unityEngine.FogMode;
	static var fogColor:unityEngine.Color;
	static var fogDensity:Float;
	static var fogStartDistance:Float;
	static var fogEndDistance:Float;
	static var ambientLight:unityEngine.Color;
	static var haloStrength:Float;
	static var flareStrength:Float;
	static var skybox:unityEngine.Material;
}