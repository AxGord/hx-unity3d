package unityEngine;
@:native("UnityEngine.AndroidJNIHelper") extern class AndroidJNIHelper {
	static var debug:Bool;
	function GetConstructorID(jclass:unityEngine.System.IntPtr, args:unityEngine.Array<object>):unityEngine.System.IntPtr;
	function GetMethodID(jclass:unityEngine.System.IntPtr, methodName:String, args:unityEngine.Array<object>, isStatic:Bool):unityEngine.System.IntPtr;
	function GetFieldID(jclass:unityEngine.System.IntPtr, fieldName:String, isStatic:Bool):unityEngine.System.IntPtr;
	function CreateJavaRunnable(runnable:unityEngine.AndroidJavaRunnable):cs.Pointer<Int>;
	function ConvertToJNIArray(array:unityEngine.System.Array):cs.Pointer<Int>;
	function CreateJNIArgArray(args:unityEngine.Array<object>):unityEngine.Array<jvalue>;
	function GetConstructorID(jclass:unityEngine.System.IntPtr, args:unityEngine.Array<object>):unityEngine.System.IntPtr;
	function GetMethodID(jclass:unityEngine.System.IntPtr, methodName:String, args:unityEngine.Array<object>, isStatic:Bool):unityEngine.System.IntPtr;
	function GetSignature(args:unityEngine.Array<object>):String;
	function ConvertFromJNIArray(array:cs.Pointer<Int>):unityEngine.ArrayType;
	function GetMethodID(jclass:unityEngine.System.IntPtr, methodName:String, args:unityEngine.Array<object>, isStatic:Bool):unityEngine.System.IntPtr;
	function GetFieldID(jclass:unityEngine.System.IntPtr, fieldName:String, isStatic:Bool):unityEngine.System.IntPtr;
	function GetSignature(args:unityEngine.Array<object>):String;
}