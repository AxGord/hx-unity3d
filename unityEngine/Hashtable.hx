package unityEngine;
@:native("UnityEngine.Hashtable") extern class Hashtable {
	function Clear():Void;
	function Remove(key:unityEngine.object):Void;
	function ContainsValue(value:unityEngine.object):Void;
	function ContainsKey(key:unityEngine.object):Bool;
	function Contains(key:unityEngine.object):Bool;
	function Add(key:unityEngine.Object, value:unityEngine.Object):Void;
}