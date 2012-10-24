package unityEngine;
@:native("UnityEngine.WWW") extern class WWW {
	var text:String;
	var bytes:unityEngine.Array<byte>;
	var error:String;
	var texture:unityEngine.Texture2D;
	var textureNonReadable:unityEngine.Texture2D;
	var movie:unityEngine.MovieTexture;
	var isDone:Bool;
	var progress:Float;
	var uploadProgress:Float;
	var url:String;
	var assetBundle:unityEngine.AssetBundle;
	var threadPriority:unityEngine.ThreadPriority;
	function new(url:String, postData:unityEngine.Array<byte>, headers:unityEngine.Hashtable):Void;
	function GetAudioClip(threeD:Bool, stream:Bool, audioType:unityEngine.AudioType):unityEngine.AudioClip;
	function LoadImageIntoTexture(tex:unityEngine.Texture2D):Void;
	function LoadUnityWeb():Void;
	function EscapeURL(s:String, e:unityEngine.Encoding = System.Text.Encoding.UTF8):String;
	function UnEscapeURL(s:String, e:unityEngine.Encoding = System.Text.Encoding.UTF8):String;
	function LoadFromCacheOrDownload(url:String, version:Int):unityEngine.WWW;
}