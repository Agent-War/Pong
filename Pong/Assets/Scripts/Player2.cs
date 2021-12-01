using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D player2;

    // Start is called before the first frame update
    void Start()
    {
        player2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            if(transform.position.y<=3.76)
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.15f);
        if (Input.GetKey(KeyCode.DownArrow))
            if (transform.position.y >= -3.76)
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.15f);
        
    }
}
