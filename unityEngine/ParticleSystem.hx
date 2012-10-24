package unityEngine;
@:native("UnityEngine.ParticleSystem") extern class ParticleSystem extends Component {
	var startDelay:Float;
	var isPlaying:Bool;
	var loop:Bool;
	var playOnAwake:Bool;
	var time:Float;
	var duration:Float;
	var playbackSpeed:Float;
	var particleCount:Int;
	var enableEmission:Bool;
	var emissionRate:Float;
	var startSpeed:Float;
	var startSize:Float;
	var startColor:unityEngine.Color;
	var startRotation:Float;
	var startLifetime:Float;
	var gravityModifier:Float;
	function SetParticles(particles:unityEngine.Array<ParticleSystem_Particle>, size:Int):Void;
	function GetParticles(particles:unityEngine.Array<ParticleSystem_Particle>):Int;
	function Simulate(t:Float, withChildren:Bool = true):Void;
	function Play(withChildren:Bool = true):Void;
	function Stop(withChildren:Bool = true):Void;
	function Pause(withChildren:Bool = true):Void;
	function Clear(withChildren:Bool = true):Void;
	function IsAlive(withChildren:Bool = true):Bool;
	function Emit(count:Int):Void;
}