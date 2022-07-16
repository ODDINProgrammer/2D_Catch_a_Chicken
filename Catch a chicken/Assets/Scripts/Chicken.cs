using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : GameEntity
{
    internal override void Awake()
    {
        base.Awake();
        _sound.Play_chickenSpawn();
    }

    internal override void Update()
    {
        base.Update();
    }

    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<GameManager>().PlayerScore += _scorePoints;
        GlobalEventManager.ObjectCatched();
        _sound.Play_chickenCatch();
    }
    public override void MissCatched()
    {
        base.MissCatched();
        FindObjectOfType<GameManager>().PlayerScore -= _scorePoints / 2;
        GlobalEventManager.ObjectCatched();
    }
}
