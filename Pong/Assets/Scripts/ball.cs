using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    Rigidbody2D bal;
    Vector2 dir;
    public float speed;
    public Score sc1,sc2;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        bal = GetComponent<Rigidbody2D>();
        dir = Vector2.one.normalized;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Time.timeScale = 1;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        bal.velocity = dir * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            dir.x = -dir.x;
        if (collision.gameObject.CompareTag("Wall"))
            dir.y = -dir.y;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("P1Score"))
        {
            sc1.scoreup1();
            
        }
        if (collision.gameObject.CompareTag("P2Score"))
        {
            sc2.scoreup2();
           
        }

        
    }
}
