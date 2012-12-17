<h1>hx-unity3d</h1>
HaXe Unity3d target
<p><small>v0.0.3</small></p>

<h2>Installation</h2>
<pre>haxelib install unity3d</pre>

<h2>Compile project example</h2>
<pre>haxe -main Main -cp src -cs bin -D no-compilation -lib unity3d {+required classes}</pre>
And then, use the .cs files in the unity3d editor

<h2>Tips and Tricks</h2>
<p>You can use <a href="https://github.com/AxGord/FlashDevelop-HaXe-Projects-Templates">FlashDevelop-HaXe-Projects-Templates</a></p>
<p>You can use <a href="https://github.com/AxGord/hx-dotnet">.NET Library</a> for additional function</p>
<p>You can use <a href="https://github.com/AxGord/Pony">Pony</a> for building event-oriented system and use some magic</p>

<h2>Example</h2>
<pre>package ;
import unityEngine.MonoBehaviour;
import unityEngine.Time;
import unityEngine.Vector3;
using UnityHelper;
class MyClass extends MonoBehaviour {
	private var target:GameObject;
	private var speed:Single;
	private function Start():Void {
		speed = 5;
	}
	public function Update():Void {
		if (speed == 0) return;
		getTransform().position = Vector3.MoveTowards(getTransform().position, target.position, Time.deltaTime * speed);
	}
}
</pre>