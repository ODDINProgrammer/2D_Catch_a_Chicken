﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region //Object amount
    [SerializeField] private int _maxObjectCount;
    private int _currentObjectCount;

    public int CurrentObjectCount
    {
        set => _currentObjectCount = value;
        get => _currentObjectCount;
    }
    public int MaxObjectCount
    {
        get => _maxObjectCount;
    }
    #endregion

    #region //Score
    [SerializeField] private int _playerScore;
    public int PlayerScore
    {
        set => _playerScore = value; 
        get => _playerScore;
    }
    #endregion
}
