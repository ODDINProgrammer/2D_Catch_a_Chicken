using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
    public static Action OnChickenCatched;

    public static void SendChickenCatched()
    {
        if (OnChickenCatched != null) OnChickenCatched.Invoke();
    }
}
