using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLKinematic : MonoBehaviour
{
    public float speed = 2f;
    private void Update()
    {
        transform.Translate(speed * Vector2.right * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -8.96f, 8.96f), -4f);
    }
}
