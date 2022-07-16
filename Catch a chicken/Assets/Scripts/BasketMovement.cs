using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    [Range(0.1f, 0.5f)] [SerializeField] private float _basketSpeed;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float posX = Input.GetAxis("Mouse X");
        posX = Mathf.Clamp(posX, -8f, 8f);
        transform.Translate(posX * _basketSpeed, 0f, 0f);
    }
}
