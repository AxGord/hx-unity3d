package unityEngine;
@:native("UnityEngine.CharacterJoint") extern class CharacterJoint extends Joint {
	var swingAxis:unityEngine.Vector3;
	var lowTwistLimit:unityEngine.SoftJointLimit;
	var highTwistLimit:unityEngine.SoftJointLimit;
	var swing1Limit:unityEngine.SoftJointLimit;
	var swing2Limit:unityEngine.SoftJointLimit;
}