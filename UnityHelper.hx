package ;
import unityEngine.Component;
import unityEngine.GameObject;
import unityEngine.Renderer;
import cs.NativeArray;
class UnityHelper {
	public static function toArray<T>(na:NativeArray<T>):Array<T> {
		var a:Array<T> = [];
		for (i in 0...na.Length) a.push(na[i]);
		return a;
	}
	
	public static inline function getTransform(c:Component):unityEngine.Transform return untyped c.transform;
	public static inline function getRenderer(c:Component):Renderer return untyped c.renderer;
	public static inline function getRigidbody(c:Component):unityEngine.Rigidbody return untyped c.rigidbody;
	public static inline function getCamera(c:Component):unityEngine.Camera return untyped c.camera;
	public static inline function getLight(c:Component):unityEngine.Light return untyped c.light;
	public static inline function getAnimation(c:Component):unityEngine.Animation return untyped c.animation;
	public static inline function getConstantForce(c:Component):unityEngine.ConstantForce return untyped c.constantForce;
	public static inline function getGameObject(c:Component):unityEngine.GameObject return untyped c.gameObject;
	public static inline function getGuiTexture(c:Component):unityEngine.GUITexture return untyped c.guiTexture;
	
	public static inline function chRenderer(c:Component):Renderer return c.GetComponentInChildren(Renderer);
	
	@:extern public static inline function getComponentsInChildren<T>(c:Component, cl:Class<T>):Array<T> return toArray(c.GetComponentsInChildren(cl));
	
	public static inline function chsRenderers(c:Component):Array<Renderer> return getComponentsInChildren(c, Renderer);
}

class UnityHelperGO {
	public static inline function getTransform(c:GameObject):unityEngine.Transform return c.transform;
	public static inline function getRenderer(c:GameObject):unityEngine.Renderer return c.renderer;
	public static inline function getRigidbody(c:GameObject):unityEngine.Rigidbody return c.rigidbody;
	public static inline function getCamera(c:GameObject):unityEngine.Camera return c.camera;
	public static inline function getLight(c:GameObject):unityEngine.Light return c.light;
	public static inline function getAnimation(c:GameObject):unityEngine.Animation return c.animation;
	public static inline function getConstantForce(c:GameObject):unityEngine.ConstantForce return c.constantForce;
	public static inline function getGameObject(c:GameObject):unityEngine.GameObject return c;
	public static inline function getGuiTexture(c:GameObject):unityEngine.GUITexture return c.guiTexture;
	
	
}