package unityEngine;
@:native("UnityEngine.LayerMask") extern class LayerMask {
	var value:Int;
	function LayerToName(layer:Int):String;
	function NameToLayer(layerName:String):Int;
}