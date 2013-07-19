package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.GameObject") extern class GameObject extends Object {
	var isStatic:Bool;
	var transform:unityEngine.Transform;
	var rigidbody:unityEngine.Rigidbody;
	var camera:unityEngine.Camera;
	var light:unityEngine.Light;
	var animation:unityEngine.Animation;
	var constantForce:unityEngine.ConstantForce;
	var renderer:unityEngine.Renderer;
	var audio:unityEngine.AudioSource;
	var guiText:unityEngine.GUIText;
	var networkView:unityEngine.NetworkView;
	var guiTexture:unityEngine.GUITexture;
	var collider:unityEngine.Collider;
	var hingeJoint:unityEngine.HingeJoint;
	var particleEmitter:unityEngine.ParticleEmitter;
	var layer:Int;
	var active:Bool;
	var tag:String;
	@:overload(function(name:String):Void{})
	function new(name:String, components:NativeArray<Type>):Void;
	@:overload(function(type:String):unityEngine.Component { } )
	function GetComponent<T>(cl:Class<T>):T;
	@:overload(function(type:String):unityEngine.Component { } )
	function GetComponentInChildren<T>(d:Class<T>):T;
	function GetComponents():NativeArray<unityEngine.Component>;
	@:overload(function(type:String):NativeArray<unityEngine.Component> { } )
	function GetComponentsInChildren<T>(cl:Class<T>):NativeArray<T>;
	function SetActiveRecursively(state:Bool):Void;
	function CompareTag(tag:String):Bool;
	function SendMessageUpwards(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function SendMessage(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function BroadcastMessage(methodName:String, parameter:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function AddComponent(className : String):Dynamic;
	function SampleAnimation(animation:unityEngine.AnimationClip, time:Float):Void;
	static function CreatePrimitive(type:unityEngine.PrimitiveType):unityEngine.GameObject;
	static function FindWithTag(tag:String):unityEngine.GameObject;
	static function FindGameObjectsWithTag(tag:String):cs.NativeArray<GameObject>;
	static function Find(name:String):unityEngine.GameObject;
}