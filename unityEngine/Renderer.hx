package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.Renderer") extern class Renderer extends Component {
	var isPartOfStaticBatch:Bool;
	var worldToLocalMatrix:unityEngine.Matrix4x4;
	var localToWorldMatrix:unityEngine.Matrix4x4;
	var enabled:Bool;
	var castShadows:Bool;
	var receiveShadows:Bool;
	var material:unityEngine.Material;
	var sharedMaterial:unityEngine.Material;
	var sharedMaterials:NativeArray<Material>;
	var materials:NativeArray<Material>;
	var bounds:unityEngine.Bounds;
	var lightmapIndex:Int;
	var lightmapTilingOffset:unityEngine.Vector4;
	var isVisible:Bool;
	var useLightProbes:Bool;
	var lightProbeAnchor:unityEngine.Transform;
	function SetPropertyBlock(properties:unityEngine.MaterialPropertyBlock):Void;
}