package unityEngine;
@:native("UnityEngine.ParticleAnimator") extern class ParticleAnimator extends Component {
	var doesAnimateColor:Bool;
	var worldRotationAxis:unityEngine.Vector3;
	var localRotationAxis:unityEngine.Vector3;
	var sizeGrow:Float;
	var rndForce:unityEngine.Vector3;
	var force:unityEngine.Vector3;
	var damping:Float;
	var autodestruct:Bool;
	var colorAnimation:unityEngine.Array<Color>;
}