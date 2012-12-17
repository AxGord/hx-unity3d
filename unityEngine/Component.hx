package unityEngine;
import cs.NativeArray;
/*
class Component extends _Component {
	public var transform(getTransform, null):Transform;
	private function getTransform():Transform return untyped transform
	public var renderer(getRenderer, null):Renderer;
	private function getRenderer():Renderer return untyped renderer
	public var rigidbody(getRigidbody, null):Rigidbody;
	private function getRigidbody():Rigidbody return untyped rigidbody
	public var camera(getCamera, null):Camera;
	private function getCamera():Camera return untyped camera
	public var light(getLight, null):Light;
	private function getLight():Light return untyped light
	public var animation(getAnimation, null):Animation;
	private function getAnimation():Animation return untyped animation
	public var constantForce(getConstantForce, null):ConstantForce;
	private function getConstantForce():ConstantForce return untyped constantForce
	public var gameObject(getGameObject, null):GameObject;
	private function getGameObject():GameObject return untyped gameObject
	public var guiTexture(getGuiTexture, null):GUITexture;
	private function getGuiTexture():GUITexture return untyped guiTexture
	
}*/
@:native("UnityEngine.Component") extern class Component extends Object {
	//var transform:Transform;
	//var _transform(getTransform,null):unityEngine.Transform;
	//var rigidbody(default,null):unityEngine.Rigidbody;
	//var camera(default,null):unityEngine.Camera;
	//var light(default,null):unityEngine.Light;
	//var animation(default,null):unityEngine.Animation;
	//var constantForce(default,null):unityEngine.ConstantForce;
	//var renderer(default,null):unityEngine.Renderer;
	//var audio(default,null):unityEngine.AudioSource;
	//var guiText(default,null):unityEngine.GUIText;
	//var networkView(default,null):unityEngine.NetworkView;
	//var guiTexture(default,null):unityEngine.GUITexture;
	//var collider(default,null):unityEngine.Collider;
	//var hingeJoint(default,null):unityEngine.HingeJoint;
	//var particleEmitter(default,null):unityEngine.ParticleEmitter;
	//var particleSystem(default,null):unityEngine.ParticleSystem;
	//var gameObject(default,null):unityEngine.GameObject;
	var tag:String;
	function GetComponent(type:String):unityEngine.Component;
	function GetComponentInChildren(d:Dynamic):Dynamic;
	function GetComponentsInChildren(d:Dynamic):NativeArray<Dynamic>;
	function GetComponents():NativeArray<Dynamic>;
	function CompareTag(tag:String):Bool;
	function SendMessageUpwards(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function SendMessage(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function BroadcastMessage(methodName:String, parameter:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
}