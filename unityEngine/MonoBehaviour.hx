package unityEngine;
@:native("UnityEngine.MonoBehaviour") extern class MonoBehaviour extends Behaviour {
	var useGUILayout:Bool;
	function Invoke(methodName:String, time:Float):Void;
	function InvokeRepeating(methodName:String, time:Float, repeatRate:Float):Void;
	function CancelInvoke(methodName:String):Void;
	function IsInvoking():Bool;
	function StartCoroutine(methodName:String, value:unityEngine.Object = null):unityEngine.Coroutine;
	function StopCoroutine(methodName:String):Void;
	function StopAllCoroutines():Void;
}