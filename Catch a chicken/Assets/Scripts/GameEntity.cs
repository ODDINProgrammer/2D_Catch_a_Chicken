using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntity : MonoBehaviour
{
    private float _fallSpeed;
    [Range(2f, 5f)] [SerializeField] private float _maxFallSpeed;
    [Range(0.2f, 2f)] [SerializeField] private float _minFallSpeed;

    virtual public void Interact() { Destroy(gameObject); }
    virtual public void MissCatched() { Destroy(gameObject); }
    virtual internal void Awake()
    {
        _fallSpeed = Random.Range(_minFallSpeed, _maxFallSpeed);
    }
    virtual internal void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - _fallSpeed * Time.deltaTime);
    }
}
