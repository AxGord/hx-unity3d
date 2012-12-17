package unityEngine;
@:native("UnityEngine.Object") extern class Object {
	var name:String;
	var hideFlags:unityEngine.HideFlags;
	function GetInstanceID():Int;
	function ToString():String;
	static function Instantiate(original:Dynamic, ?position:Vector3, ?rotation:Quaternion):Dynamic;
	@:overload(function(obj:unityEngine.Object):Void{})
	function Destroy(obj:unityEngine.Object, t:Single):Void;
	function DestroyImmediate(obj:unityEngine.Object, allowDestroyingAssets:Bool = false):Void;
	//function FindObjectsOfType(type:unityEngine.Type):unityEngine.Array<Object>;
	//function FindObjectOfType(type:unityEngine.Type):unityEngine.Object;
	function DontDestroyOnLoad(target:unityEngine.Object):Void;
}