package unityEngine;
@:native("UnityEngine.AssetBundle") extern class AssetBundle extends Object {
	var mainAsset:unityEngine.Object;
	function Contains(name:String):Bool;
	function Load(name:String, type:unityEngine.Type):unityEngine.Object;
	function LoadAsync(name:String, type:unityEngine.Type):unityEngine.AssetBundleRequest;
	function LoadAll():unityEngine.Array<Object>;
	function Unload(unloadAllLoadedObjects:Bool):Void;
	function CreateFromMemory(binary:unityEngine.Array<byte>):unityEngine.AssetBundleCreateRequest;
	function CreateFromFile(path:String):unityEngine.AssetBundle;
}