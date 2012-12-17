package unityEngine;
import cs.NativeArray;
@:native("UnityEngine.ParticleEmitter") extern class ParticleEmitter extends Component {
	var emit:Bool;
	var minSize:Float;
	var maxSize:Float;
	var minEnergy:Float;
	var maxEnergy:Float;
	var minEmission:Float;
	var maxEmission:Float;
	var emitterVelocityScale:Float;
	var worldVelocity:unityEngine.Vector3;
	var localVelocity:unityEngine.Vector3;
	var rndVelocity:unityEngine.Vector3;
	var useWorldSpace:Bool;
	var rndRotation:Bool;
	var angularVelocity:Float;
	var rndAngularVelocity:Float;
	var particles:NativeArray<Particle>;
	var particleCount:Int;
	var enabled:Bool;
	function ClearParticles():Void;
	function Emit(pos:unityEngine.Vector3, velocity:unityEngine.Vector3, size:Float, energy:Float, color:unityEngine.Color, rotation:Float, angularVelocity:Float):Void;
	function Simulate(deltaTime:Float):Void;
}