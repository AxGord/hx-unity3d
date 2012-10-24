package unityEngine;
@:native("UnityEngine.Joint") extern class Joint extends Component {
	var connectedBody:unityEngine.Rigidbody;
	var axis:unityEngine.Vector3;
	var anchor:unityEngine.Vector3;
	var breakForce:Float;
	var breakTorque:Float;
}