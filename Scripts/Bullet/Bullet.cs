using EnemyData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] AudioSource hit;
    [SerializeField] AudioSource target;
    [SerializeField] ParticleSystem ef;
    [SerializeField] Sprite condition1;
    [SerializeField] Sprite condition2;
    [SerializeField] Sprite condition3;
    Rigidbody2D rb;
    float speed = 2f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(Random.Range(1f, 4f), Random.Range(2f, 4f)) * speed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy1"))
        {
            hit.Play();
            ef.Play();
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = condition1;
            collision.gameObject.tag = "Enemy";
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            hit.Play();
            ef.Play();
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = condition2;
            collision.gameObject.tag = "Enemy1";
        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = condition3;
            hit.Play();
            ef.Play();
        }
        if (collision.gameObject.tag == "Platform")
        {
            target.Play();
        }
    }
}
