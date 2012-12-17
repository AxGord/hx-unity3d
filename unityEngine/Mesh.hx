package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.Mesh") extern class Mesh extends Object {
	var vertices:NativeArray<Vector3>;
	var normals:NativeArray<Vector3>;
	var tangents:NativeArray<Vector4>;
	var uv:NativeArray<Vector2>;
	var uv2:NativeArray<Vector2>;
	var bounds:unityEngine.Bounds;
	var colors:NativeArray<Color>;
	var colors32:NativeArray<Color32>;
	var triangles:NativeArray<Int>;
	var vertexCount:Int;
	var subMeshCount:Int;
	var boneWeights:NativeArray<BoneWeight>;
	var bindposes:NativeArray<Matrix4x4>;
	function new():Void;
	function Clear(keepVertexLayout:Bool = true):Void;
	function RecalculateBounds():Void;
	function RecalculateNormals():Void;
	function Optimize():Void;
	function GetTriangles(submesh:Int):NativeArray<Int>;
	function SetTriangles(triangles:NativeArray<Int>, submesh:Int):Void;
	function CombineMeshes(combine:NativeArray<CombineInstance>, mergeSubMeshes:Bool = true, useMatrices:Bool = true):Void;
}