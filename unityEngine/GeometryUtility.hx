package unityEngine;
@:native("UnityEngine.GeometryUtility") extern class GeometryUtility {
	function CalculateFrustumPlanes(worldToProjectionMatrix:unityEngine.Matrix4x4):unityEngine.Array<Plane>;
	function TestPlanesAABB(planes:unityEngine.Array<Plane>, bounds:unityEngine.Bounds):Bool;
}