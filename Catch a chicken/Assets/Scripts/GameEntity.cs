﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    private float _fallSpeed;
    [SerializeField] private float _maxFallSpeed;
    [SerializeField] private float _minFallSpeed;

    [SerializeField] internal Sound _sound;

    [SerializeField] internal int _scorePoints;

    virtual public void Interact() { Destroy(gameObject); FindObjectOfType<GameManager>().CurrentObjectCount--; }
    virtual public void MissCatched() { Destroy(gameObject); FindObjectOfType<GameManager>().CurrentObjectCount--; }
    virtual internal void Awake()
    {
        _fallSpeed = Random.Range(_minFallSpeed, _maxFallSpeed);
        _sound = FindObjectOfType<Sound>();
    }
    virtual internal void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - _fallSpeed * Time.deltaTime);
    }
}
