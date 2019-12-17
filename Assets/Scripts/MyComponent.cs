using UnityEngine;

public class MyComponent : MonoBehaviour
{
    internal void CallTestWithCheck()
    {
        if (this)
        {
            name += "";
        }
        else
        {
            Debug.Log("'this' is false!");
        }
    }

    internal void CallTest()
    {
        name += "";
    }
}
