using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 move;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        rb.AddForce(move * speed);
    }

}
