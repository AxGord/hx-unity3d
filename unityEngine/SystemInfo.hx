package unityEngine;
@:native("UnityEngine.SystemInfo") extern class SystemInfo {
	static var operatingSystem:String;
	static var processorType:String;
	static var processorCount:Int;
	static var systemMemorySize:Int;
	static var graphicsMemorySize:Int;
	static var graphicsDeviceName:String;
	static var graphicsDeviceVendor:String;
	static var graphicsDeviceID:Int;
	static var graphicsDeviceVendorID:Int;
	static var graphicsDeviceVersion:String;
	static var graphicsShaderLevel:Int;
	static var graphicsPixelFillrate:Int;
	static var supportsShadows:Bool;
	static var supportsRenderTextures:Bool;
	static var supportsImageEffects:Bool;
	static var supportedRenderTargetCount:Int;
	static var deviceUniqueIdentifier:String;
	static var deviceName:String;
	static var deviceModel:String;
	static var supportsAccelerometer:Bool;
	static var supportsGyroscope:Bool;
	static var supportsLocationService:Bool;
	static var supportsVibration:Bool;
	static var deviceType:unityEngine.DeviceType;
	function SupportsRenderTextureFormat(format:unityEngine.RenderTextureFormat):Bool;
}