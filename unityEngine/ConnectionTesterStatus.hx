package unityEngine;
@:native("UnityEngine.ConnectionTesterStatus") extern class ConnectionTesterStatus {
	static var Error;
	static var Undetermined;
	static var PublicIPIsConnectable;
	static var PublicIPPortBlocked;
	static var PublicIPNoServerStarted;
	static var LimitedNATPunchthroughPortRestricted;
	static var LimitedNATPunchthroughSymmetric;
	static var NATpunchthroughFullCone;
	static var NATpunchthroughAddressRestrictedCone;
}