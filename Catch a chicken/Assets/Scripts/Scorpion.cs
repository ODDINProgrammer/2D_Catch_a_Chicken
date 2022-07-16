using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion : GameEntity
{
    internal override void Awake()
    {
        base.Awake();
        _sound.Play_scorpionSpawn();
    }
    public override void Interact()
    {
        base.Interact();
        FindObjectOfType<GameManager>().PlayerScore -= _scorePoints;
        GlobalEventManager.ObjectCatched();
        _sound.Play_scorpionCatch();
    }
}
