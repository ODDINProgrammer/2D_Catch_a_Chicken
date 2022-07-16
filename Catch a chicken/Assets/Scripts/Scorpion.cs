using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion : GameEntity
{
    [SerializeField] private int _scorePoints;
    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<GameManager>().PlayerScore -= _scorePoints;
        GlobalEventManager.SendChickenCatched();
    }
}
