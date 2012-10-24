package unityEngine;
@:native("UnityEngine.QualitySettings") extern class QualitySettings extends Object {
	static var names:unityEngine.Array<string>;
	static var pixelLightCount:Int;
	static var shadowProjection:unityEngine.ShadowProjection;
	static var shadowCascades:Int;
	static var shadowDistance:Float;
	static var masterTextureLimit:Int;
	static var anisotropicFiltering:unityEngine.AnisotropicFiltering;
	static var lodBias:Float;
	static var maximumLODLevel:Int;
	static var softVegetation:Bool;
	static var maxQueuedFrames:Int;
	static var vSyncCount:Int;
	static var antiAliasing:Int;
	static var desiredColorSpace:unityEngine.ColorSpace;
	static var activeColorSpace:unityEngine.ColorSpace;
	static var blendWeights:unityEngine.BlendWeights;
	function GetQualityLevel():Int;
	function SetQualityLevel(index:Int, applyExpensiveChanges:unityEngine.boolean = true):Void;
	function IncreaseLevel(applyExpensiveChanges:unityEngine.boolean = false):Void;
	function DecreaseLevel(applyExpensiveChanges:unityEngine.boolean = false):Void;
}