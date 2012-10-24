package unityEngine;
@:native("UnityEngine.Resources") extern class Resources {
	function FindObjectsOfTypeAll(type:unityEngine.Type):unityEngine.Array<Object>;
	function Load(path:String, type:unityEngine.Type):unityEngine.Object;
	function LoadAll(path:String):unityEngine.Array<Object>;
	function LoadAssetAtPath(assetPath:String, type:unityEngine.Type):unityEngine.Object;
	function UnloadAsset(assetToUnload:unityEngine.Object):Void;
	function UnloadUnusedAssets():unityEngine.AsyncOperation;
}