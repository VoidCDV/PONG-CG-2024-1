using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidBody2D;
    public float speed = 6f;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        SendBallinRandomDirection();
    }

    private void SendBallinRandomDirection()
    {
        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.isKinematic = true;
        transform.position = Vector2.zero;
        rigidBody2D.isKinematic = false;

        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-1f, 1f);
        newBallVector.y = Random.Range(-1f, 1f);
        rigidBody2D.velocity = newBallVector * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SendBallinRandomDirection();
        }    
    }
}
