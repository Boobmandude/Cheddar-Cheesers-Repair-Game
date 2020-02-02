using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private float movimenty = 0f, movimentx = 0f;
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimenty = Input.GetAxis("Vertical");
        movimentx = Input.GetAxis("Horizontal");

        if (movimenty > 0 || movimentx > 0)
        {            
            rigidBody.velocity = new Vector2(movimentx * speed, rigidBody.velocity.y);
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movimenty * speed);
            if (movimentx > 0)
            {
                transform.localScale = new Vector2(-1f, 1f);
                rigidBody.AddRelativeForce(speed *10* Vector2.right);
            }
            if (movimenty > 0)
            {
                rigidBody.AddRelativeForce(speed *10* Vector2.up);
            }

        }
        if (movimenty < 0 || movimentx < 0)
        {           
            rigidBody.velocity = new Vector2(movimentx * speed, rigidBody.velocity.y);          
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movimenty * speed);
            if (movimentx < 0)
            {
                transform.localScale = new Vector2(1f, 1f);
                rigidBody.AddRelativeForce(speed *10* Vector2.left);
            }
            if (movimenty < 0)
            {
                rigidBody.AddRelativeForce(speed *10* Vector2.down);
            }
        }
       
    }
        

}