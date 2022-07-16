using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<GameEntity>() == null) return;
        Debug.Log("Object found");
        GameEntity entity = collision.gameObject.GetComponent<GameEntity>();
        entity.Interact();

    }
}
