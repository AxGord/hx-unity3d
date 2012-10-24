package unityEngine;
@:native("UnityEngine.Projector") extern class Projector extends Behaviour {
	var nearClipPlane:Float;
	var farClipPlane:Float;
	var fieldOfView:Float;
	var aspectRatio:Float;
	var orthographic:Bool;
	var orthographicSize:Float;
	var ignoreLayers:Int;
	var material:unityEngine.Material;
}