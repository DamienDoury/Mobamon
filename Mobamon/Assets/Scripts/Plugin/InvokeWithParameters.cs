/*
 * https://gist.github.com/cbaltzer/6196131
 */ 
using UnityEngine;
using System;
using System.Reflection;
using System.Collections;

namespace UnityEngine {

	public static class ExtensionMethods {

		public static void Invoke(this MonoBehaviour behaviour, string method, object options, float delay) {
			behaviour.StartCoroutine(_invoke(behaviour, method, delay, options));
		}
		
		private static IEnumerator _invoke(this MonoBehaviour behaviour, string method, float delay, object options) {
			if (delay > 0f) {
				yield return new WaitForSeconds(delay);
			}

			Type instance = behaviour.GetType();
			MethodInfo mthd = instance.GetMethod(method);
			mthd.Invoke(behaviour, new object[]{options});

			yield return null;
		}

	}
	
}