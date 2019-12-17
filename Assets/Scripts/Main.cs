using UnityEngine;

public class Main : MonoBehaviour
{
	private void Start()
	{
		var testGameObject = new GameObject("test");
		var component = testGameObject.AddComponent<MyComponent>();
		DestroyImmediate(testGameObject);

		try
		{
			component.CallTest();
			Debug.Log($"{nameof(MyComponent.CallTest)}: No exception was thrown.");
		}
		catch (MissingReferenceException ex)
		{
			Debug.LogException(ex);
		}

		try
		{
			component.CallTestWithCheck();
			Debug.Log($"{nameof(MyComponent.CallTestWithCheck)}: No exception was thrown.");
		}
		catch (MissingReferenceException ex)
		{
			Debug.LogException(ex);
		}
	}
}
