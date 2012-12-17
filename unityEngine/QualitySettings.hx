package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.QualitySettings") extern class QualitySettings extends Object {
	static var names:NativeArray<String>;
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
	static function GetQualityLevel():Int;
	@:overload(function(index:Int, applyExpensiveChanges:Bool):Void{})
	static function SetQualityLevel(index:Int):Void;
	static function IncreaseLevel(applyExpensiveChanges:Bool = false):Void;
	static function DecreaseLevel(applyExpensiveChanges:Bool = false):Void;
}