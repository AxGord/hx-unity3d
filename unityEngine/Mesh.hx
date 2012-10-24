package unityEngine;
@:native("UnityEngine.Mesh") extern class Mesh extends Object {
	var vertices:unityEngine.Array<Vector3>;
	var normals:unityEngine.Array<Vector3>;
	var tangents:unityEngine.Array<Vector4>;
	var uv:unityEngine.Array<Vector2>;
	var uv2:unityEngine.Array<Vector2>;
	var bounds:unityEngine.Bounds;
	var colors:unityEngine.Array<Color>;
	var colors32:unityEngine.Array<Color32>;
	var triangles:unityEngine.Array<int>;
	var vertexCount:Int;
	var subMeshCount:Int;
	var boneWeights:unityEngine.Array<BoneWeight>;
	var bindposes:unityEngine.Array<Matrix4x4>;
	function new():Void;
	function Clear(keepVertexLayout:unityEngine.boolean = true):Void;
	function RecalculateBounds():Void;
	function RecalculateNormals():Void;
	function Optimize():Void;
	function GetTriangles(submesh:Int):unityEngine.Array<int>;
	function SetTriangles(triangles:unityEngine.Array<int>, submesh:Int):Void;
	function CombineMeshes(combine:unityEngine.Array<CombineInstance>, mergeSubMeshes:unityEngine.boolean = true, useMatrices:unityEngine.boolean = true):Void;
}