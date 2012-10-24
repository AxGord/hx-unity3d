package unityEngine;
@:native("UnityEngine.SkinnedCloth") extern class SkinnedCloth extends Cloth {
	var coefficients:unityEngine.Array<ClothSkinningCoefficient>;
	var worldVelocityScale:Float;
	var worldAccelerationScale:Float;
	function SetEnabledFading(enabled:Bool, interpolationTime:unityEngine.float = 0.5f):Void;
}