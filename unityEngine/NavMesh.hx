package unityEngine;
@:native("UnityEngine.NavMesh") extern class NavMesh extends Object {
	function Raycast(sourcePosition:unityEngine.Vector3, targetPosition:unityEngine.Vector3, out hit:unityEngine.NavMeshHit, passableMask:Int):Bool;
	function CalculatePath(sourcePosition:unityEngine.Vector3, targetPosition:unityEngine.Vector3, passableMask:Int, path:unityEngine.NavMeshPath):Bool;
	function FindClosestEdge(sourcePosition:unityEngine.Vector3, out hit:unityEngine.NavMeshHit, passableMask:Int):Bool;
	function SamplePosition(sourcePosition:unityEngine.Vector3, out hit:unityEngine.NavMeshHit, maxDistance:Float, allowedMask:Int):Bool;
	function SetLayerCost(layer:Int, cost:Float):Void;
	function GetLayerCost(layer:Int):Float;
	function GetNavMeshLayerFromName(layerName:String):Int;
}