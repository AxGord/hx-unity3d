package unityEngine;
@:native("UnityEngine.Light") extern class Light extends Behaviour {
	var type:unityEngine.LightType;
	var color:unityEngine.Color;
	var intensity:Float;
	var shadows:unityEngine.LightShadows;
	var shadowStrength:Float;
	var shadowBias:Float;
	var shadowSoftness:Float;
	var shadowSoftnessFade:Float;
	var range:Float;
	var spotAngle:Float;
	var cookie:unityEngine.Texture;
	var flare:unityEngine.Flare;
	var renderMode:unityEngine.LightRenderMode;
	var cullingMask:Int;
}