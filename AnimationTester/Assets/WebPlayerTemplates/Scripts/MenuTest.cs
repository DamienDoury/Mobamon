using UnityEditor;
using UnityEngine;
public class MenuTest : MonoBehaviour {
	// Add a menu item named "Do Something" to MyMenu in the menu bar.
	[MenuItem ("MyMenu/Do Something")]
	static void DoSomething () {
		Debug.Log ("Doing Something...");
	}
	
	// Validated menu item.
	// Add a menu item named "Log Selected Transform Name" to MyMenu in the menu bar.
	// We use a second function to validate the menu item
	// so it will only be enabled if we have a transform selected.
	[MenuItem ("MyMenu/Log Selected Transform Name")]
	static void LogSelectedTransformName ()
	{
		Debug.Log ("Selected Transform is on " + Selection.activeTransform.gameObject.name + ".");
	}
	// Validate the menu item defined by the function above.
	// The menu item will be disabled if this function returns false.
	[MenuItem ("MyMenu/Log Selected Transform Name", true)]
	static bool ValidateLogSelectedTransformName () {
		// Return false if no transform is selected.
		return Selection.activeTransform != null;
	}
	
	// Add a menu item named "Do Something with a Shortcut Key" to MyMenu in the menu bar
	// and give it a shortcut (ctrl-g on Windows, cmd-g on OS X).
	[MenuItem ("MyMenu/Do Something with a Shortcut Key %g")]
	static void DoSomethingWithAShortcutKey () {
		Debug.Log ("Doing something with a Shortcut Key...");
	}
	// Add a menu item called "Double Mass" to a Rigidbody's context menu.
	[MenuItem ("CONTEXTRigidbodyDouble Mass")]
	static void DoubleMass (MenuCommand command) {
		Rigidbody body = (Rigidbody)command.context;
		body.mass = body.mass * 2;
		Debug.Log ("Doubled Rigidbody's Mass to " + body.mass + " from Context Menu.");
	}
}