using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource _chickenSpawn;
    [SerializeField] private AudioSource _chickenCatch;
    [SerializeField] private AudioSource _scorpionSpawn;
    [SerializeField] private AudioSource _scorpionCatch;

    public void Play_chickenSpawn() { _chickenSpawn.Play(); }
    public void Play_chickenCatch() { _chickenCatch.Play(); }
    public void Play_scorpionSpawn() { _scorpionSpawn.Play(); }
    public void Play_scorpionCatch() { _scorpionCatch.Play(); }

}
