using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBasketPosition : MonoBehaviour
{
    [SerializeField] private Transform _basket;
    [SerializeField] private float _posX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _basket.transform.position = new Vector2(_posX, _basket.position.y);

    }
}
