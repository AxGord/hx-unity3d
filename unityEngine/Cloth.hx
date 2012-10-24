package unityEngine;
@:native("UnityEngine.Cloth") extern class Cloth extends Component {
	var bendingStiffness:Float;
	var stretchingStiffness:Float;
	var damping:Float;
	var thickness:Float;
	var externalAcceleration:unityEngine.Vector3;
	var randomAcceleration:unityEngine.Vector3;
	var useGravity:Bool;
	var selfCollision:Bool;
	var enabled:Bool;
	var vertices:unityEngine.Array<Vector3>;
	var normals:unityEngine.Array<Vector3>;
}