package unityEngine;
@:native("UnityEngine.InteractiveCloth") extern class InteractiveCloth extends Cloth {
	var mesh:unityEngine.Mesh;
	var friction:Float;
	var density:Float;
	var pressure:Float;
	var collisionResponse:Float;
	var tearFactor:Float;
	var attachmentTearFactor:Float;
	var attachmentResponse:Float;
	var isTeared:Bool;
	function AddForceAtPosition(force:unityEngine.Vector3, position:unityEngine.Vector3, radius:Float, mode:unityEngine.ForceMode = ForceMode.Force):Void;
}