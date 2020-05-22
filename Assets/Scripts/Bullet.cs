using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    private EnemyPathing enemyPathing;
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            EnemyPathing enemyPathing = collision.GetComponent<EnemyPathing>();
            Destroy(gameObject);
            Destroy(enemyPathing.gameObject);
            
        }
    }


}
