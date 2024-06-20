using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{



    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigid;
    public float speed = 5f;
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;
    
    
    // Start is called before the first frame update
    void Start()
    {
        print("Hello from the start :)");
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y < 4.5f)
        {
            rigid.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey) && transform.position.y > -4.5f)
        {
            rigid.velocity = Vector2.down * speed;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }
    }

    private void OnMouseDown()
    {
        print("Click");
        spriteRenderer.color = Color.red;
    }
}
