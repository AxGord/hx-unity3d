package unityEngine;
@:native("UnityEngine.NetworkConnectionError") extern class NetworkConnectionError {
	static var NoError;
	static var RSAPublicKeyMismatch;
	static var InvalidPassword;
	static var ConnectionFailed;
	static var TooManyConnectedPlayers;
	static var ConnectionBanned;
	static var AlreadyConnectedToServer;
	static var AlreadyConnectedToAnotherServer;
	static var CreateSocketOrThreadFailure;
	static var IncorrectParameters;
	static var EmptyConnectTarget;
	static var InternalDirectConnectFailed;
	static var NATTargetNotConnected;
	static var NATTargetConnectionLost;
	static var NATPunchthroughFailed;
}