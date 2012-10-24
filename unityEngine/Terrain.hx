package unityEngine;
@:native("UnityEngine.Terrain") extern class Terrain extends MonoBehaviour {
	var terrainData:unityEngine.TerrainData;
	var treeDistance:Float;
	var treeBillboardDistance:Float;
	var treeCrossFadeLength:Float;
	var treeMaximumFullLODCount:Int;
	var detailObjectDistance:Float;
	var detailObjectDensity:Float;
	var heightmapPixelError:Float;
	var heightmapMaximumLOD:Int;
	var basemapDistance:Float;
	function SampleHeight(worldPosition:unityEngine.Vector3):Float;
	function AddTreeInstance(instance:unityEngine.TreeInstance):Void;
	function SetNeighbors(left:unityEngine.Terrain, top:unityEngine.Terrain, right:unityEngine.Terrain, bottom:unityEngine.Terrain):Void;
	function GetPosition():unityEngine.Vector3;
	function Flush():Void;
	static var activeTerrain:unityEngine.Terrain;
	function CreateTerrainGameObject(assignTerrain:unityEngine.TerrainData):unityEngine.GameObject;
}