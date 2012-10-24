package unityEngine;
@:native("UnityEngine.GL") extern class GL {
	static var modelview:unityEngine.Matrix4x4;
	function Vertex3(x:Float, y:Float, z:Float):Void;
	function Vertex(v:unityEngine.Vector3):Void;
	function Color(c:unityEngine.Color):Void;
	function TexCoord(v:unityEngine.Vector3):Void;
	function TexCoord2(x:Float, y:Float):Void;
	function TexCoord3(x:Float, y:Float, z:Float):Void;
	function MultiTexCoord2(unit:Int, x:Float, y:Float):Void;
	function MultiTexCoord3(unit:Int, x:Float, y:Float, z:Float):Void;
	function MultiTexCoord(unit:Int, v:unityEngine.Vector3):Void;
	function Begin(mode:Int):Void;
	function End():Void;
	function LoadOrtho():Void;
	function LoadPixelMatrix(left:Float, right:Float, bottom:Float, top:Float):Void;
	function Viewport(pixelRect:unityEngine.Rect):Void;
	function LoadProjectionMatrix(mat:unityEngine.Matrix4x4):Void;
	function LoadIdentity():Void;
	function MultMatrix(mat:unityEngine.Matrix4x4):Void;
	function PushMatrix():Void;
	function PopMatrix():Void;
	function GetGPUProjectionMatrix(proj:unityEngine.Matrix4x4, renderIntoTexture:Bool):unityEngine.Matrix4x4;
	function SetRevertBackfacing(revertBackFaces:Bool):Void;
	function Clear(clearDepth:Bool, clearColor:Bool, backgroundColor:unityEngine.Color):Void;
	function ClearWithSkybox(clearDepth:Bool, camera:unityEngine.Camera):Void;
	function InvalidateState():Void;
	function IssuePluginEvent(eventID:Int):Void;
}