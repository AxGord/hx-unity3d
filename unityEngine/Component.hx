package unityEngine;
@:native("UnityEngine.Component") extern class Component extends Object, implements Dynamic {
	//var transform(default,null):unityEngine.Transform;
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
	function GetComponentInChildren():Dynamic;
	function GetComponentsInChildren():unityEngine.Array<Dynamic>;
	function GetComponents():unityEngine.Array<Dynamic>;
	function CompareTag(tag:String):Bool;
	function SendMessageUpwards(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function SendMessage(methodName:String, value:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
	function BroadcastMessage(methodName:String, parameter:unityEngine.Object = null, options:unityEngine.SendMessageOptions = SendMessageOptions.RequireReceiver):Void;
}