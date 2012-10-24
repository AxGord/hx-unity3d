package unityEngine;
@:native("UnityEngine.ParticleRenderer") extern class ParticleRenderer extends Renderer {
	var particleRenderMode:unityEngine.ParticleRenderMode;
	var lengthScale:Float;
	var velocityScale:Float;
	var cameraVelocityScale:Float;
	var maxParticleSize:Float;
	var uvAnimationXTile:Int;
	var uvAnimationYTile:Int;
	var uvAnimationCycles:Float;
}