package unityEngine;
@:native("UnityEngine.WWWForm") extern class WWWForm {
	var headers:unityEngine.Hashtable;
	var data:unityEngine.Array<byte>;
	function new():Void;
	function AddField(fieldName:String, i:Int):Void;
	function AddBinaryData(fieldName:String, contents:unityEngine.Array<byte>, fileName:unityEngine.String = null, mimeType:unityEngine.String = null):Void;
}