package unityEngine;
@:native("UnityEngine.SkinnedMeshRenderer") extern class SkinnedMeshRenderer extends Renderer {
	var bones:unityEngine.Array<Transform>;
	var quality:unityEngine.SkinQuality;
	var sharedMesh:unityEngine.Mesh;
	var updateWhenOffscreen:Bool;
	var localBounds:unityEngine.Bounds;
}