package unityEngine;
@:native("UnityEngine.ParticleSystemRenderer") extern class ParticleSystemRenderer extends Renderer {
	var renderMode:unityEngine.ParticleSystemRenderMode;
	var lengthScale:Float;
	var velocityScale:Float;
	var cameraVelocityScale:Float;
	var maxParticleSize:Float;
	var mesh:unityEngine.Mesh;
}