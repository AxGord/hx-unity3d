package unityEngine;
@:native("UnityEngine.Graphics") extern class Graphics {
	static var activeColorBuffer:unityEngine.RenderBuffer;
	static var activeDepthBuffer:unityEngine.RenderBuffer;
	function DrawMesh(mesh:unityEngine.Mesh, matrix:unityEngine.Matrix4x4, material:unityEngine.Material, layer:Int, camera:unityEngine.Camera = null, submeshIndex:unityEngine.int = 0, properties:unityEngine.MaterialPropertyBlock = null):Void;
	function DrawMeshNow(mesh:unityEngine.Mesh, matrix:unityEngine.Matrix4x4, materialIndex:Int):Void;
	function DrawTexture(screenRect:unityEngine.Rect, texture:unityEngine.Texture, sourceRect:unityEngine.Rect, leftBorder:Int, rightBorder:Int, topBorder:Int, bottomBorder:Int, color:unityEngine.Color, mat:unityEngine.Material = null):Void;
	function Blit(source:unityEngine.Texture, mat:unityEngine.Material, pass:unityEngine.int = -1):Void;
	function BlitMultiTap(source:unityEngine.Texture, dest:unityEngine.RenderTexture, mat:unityEngine.Material, params offsets:unityEngine.Array<Vector2>):Void;
	function SetRenderTarget(colorBuffers:unityEngine.Array<RenderBuffer>, depthBuffer:unityEngine.RenderBuffer):Void;
}