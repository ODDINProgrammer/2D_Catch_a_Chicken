using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
    public static Action OnObjectCatched;

    public static void ObjectCatched()
    {
        if (OnObjectCatched != null) OnObjectCatched.Invoke();
    }
}
