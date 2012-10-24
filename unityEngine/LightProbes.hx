package unityEngine;
@:native("UnityEngine.LightProbes") extern class LightProbes extends Object {
	var positions:unityEngine.Array<Vector3>;
	var coefficients:unityEngine.Array<float>;
	var count:Int;
	var cellCount:Int;
	function GetInterpolatedLightProbe(position:unityEngine.Vector3, renderer:unityEngine.Renderer, coefficients:unityEngine.Array<float>):Void;
}