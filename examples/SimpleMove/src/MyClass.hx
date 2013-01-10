package ;

import unityEngine.MonoBehaviour;
import unityEngine.Time;
import unityEngine.Vector3;
import unityEngine.GameObject;
using UnityHelper;

/**
 * ...
 * @author AxGord
 */

class MyClass extends MonoBehaviour {

	private var target:GameObject;
    private var speed:Single;
    private function Start():Void {
        speed = 5;
        if (target == null) target = GameObject.Find('/Target');
		trace('Hll wrld!');
    }
    private function Update():Void {
        if (speed == 0) return;
        getTransform().position = Vector3.MoveTowards(getTransform().position, target.transform.position, Time.deltaTime * speed);
    }
	
}