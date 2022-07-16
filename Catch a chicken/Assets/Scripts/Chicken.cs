﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : GameEntity
{
    [SerializeField] private int _scorePoints;
    internal override void Awake()
    {
        base.Awake();
    }

    internal override void Update()
    {
        base.Update();
    }

    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<GameManager>().PlayerScore += _scorePoints;
        GlobalEventManager.SendChickenCatched();
    }
    public override void MissCatched()
    {
        base.MissCatched();
        FindObjectOfType<GameManager>().PlayerScore -= _scorePoints / 2;
        GlobalEventManager.SendChickenCatched();
    }
}
