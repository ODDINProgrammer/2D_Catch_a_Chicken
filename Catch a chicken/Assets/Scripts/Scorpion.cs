using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion : GameEntity
{
    [SerializeField] private int _scorePoints;
    internal override void Awake()
    {
        base.Awake();
        _sound.Play_scorpionSpawn();
    }
    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<GameManager>().PlayerScore -= _scorePoints;
        GlobalEventManager.SendChickenCatched();
        _sound.Play_scorpionCatch();
    }
}
