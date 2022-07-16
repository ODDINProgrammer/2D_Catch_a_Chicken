using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _maxObjectCount;
    private int _currentObjectCount;

    public int CurrentObjectCount
    {
        set => _currentObjectCount++;
        get => _currentObjectCount;
    }
    public int MaxObjectCount
    {
        get => _maxObjectCount;
    }

}
