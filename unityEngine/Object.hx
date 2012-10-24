package unityEngine;
@:native("UnityEngine.Object") extern class Object {
	var name:String;
	var hideFlags:unityEngine.HideFlags;
	function GetInstanceID():Int;
	function ToString():String;
	//function Instantiate(original:unityEngine.T):unityEngine.T;
	function Destroy(obj:unityEngine.Object, t:Float = 0.0):Void;
	function DestroyImmediate(obj:unityEngine.Object, allowDestroyingAssets:Bool = false):Void;
	//function FindObjectsOfType(type:unityEngine.Type):unityEngine.Array<Object>;
	//function FindObjectOfType(type:unityEngine.Type):unityEngine.Object;
	function DontDestroyOnLoad(target:unityEngine.Object):Void;
}