package unityEngine;
@:native("UnityEngine.HingeJoint") extern class HingeJoint extends Joint {
	var motor:unityEngine.JointMotor;
	var limits:unityEngine.JointLimits;
	var spring:unityEngine.JointSpring;
	var useMotor:Bool;
	var useLimits:Bool;
	var useSpring:Bool;
	var velocity:Float;
	var angle:Float;
}