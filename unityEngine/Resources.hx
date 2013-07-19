package unityEngine;
@:native("UnityEngine.Resources") extern class Resources {
	//function FindObjectsOfTypeAll(type:unityEngine.Type):unityEngine.Array<Object>;
	static function Load(path:String):unityEngine.Object;
	//function Load(path:String, type:unityEngine.Type):unityEngine.Object;
	//function LoadAll(path:String):unityEngine.Array<Object>;
	//function LoadAssetAtPath(assetPath:String, type:unityEngine.Type):unityEngine.Object;
	static function UnloadAsset(assetToUnload:unityEngine.Object):Void;
	static function UnloadUnusedAssets():unityEngine.AsyncOperation;
}