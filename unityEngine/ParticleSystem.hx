package unityEngine;
import cs.NativeArray;
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
	function SetParticles(particles:NativeArray<ParticleSystem_Particle>, size:Int):Void;
	function GetParticles(particles:NativeArray<ParticleSystem_Particle>):Int;
	function Simulate(t:Float, withChildren:Bool = true):Void;
	@:overload(function():Void{})
	function Play(withChildren:Bool):Void;
	@:overload(function():Void{})
	function Stop(withChildren:Bool):Void;
	function Pause(withChildren:Bool = true):Void;
	function Clear(withChildren:Bool = true):Void;
	function IsAlive(withChildren:Bool = true):Bool;
	function Emit(count:Int):Void;
}