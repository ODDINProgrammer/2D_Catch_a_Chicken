using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<GameEntity>() == null) return;
        GameEntity entity = collision.gameObject.GetComponent<GameEntity>();
        entity.MissCatched();
    }
}
