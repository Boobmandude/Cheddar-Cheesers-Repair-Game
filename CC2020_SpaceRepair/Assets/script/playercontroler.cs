using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private float movimenty = 0f, movimentx = 0f;
    public float scale=1f;
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.velocity = new Vector2(movimentx * speed, rigidBody.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.Rotate(new Vector3(0,0,1)* Time.deltaTime * speed, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * speed, Space.World);
        }
        //movimenty = Input.GetAxis("Vertical");
        //movimentx = Input.GetAxis("Horizontal");

        //if (movimenty > 0 || movimentx > 0)
        //{            
        //    rigidBody.velocity = new Vector2(movimentx * speed, rigidBody.velocity.y);
        //    rigidBody.velocity = new Vector2(rigidBody.velocity.x, movimenty * speed);
        //    if (movimentx > 0)
        //    {
        //        transform.localScale = new Vector2(-scale, scale);
        //        rigidBody.AddRelativeForce(speed *10* Vector2.right);
        //    }
        //    if (movimenty > 0)
        //    {
        //        rigidBody.AddRelativeForce(speed *10* Vector2.up);
        //    }

        //}
        //if (movimenty < 0 || movimentx < 0)
        //{           
        //    rigidBody.velocity = new Vector3(movimentx * speed, rigidBody.velocity.y);          
        //    rigidBody.velocity = new Vector2(rigidBody.velocity.x, movimenty * speed);
        //    if (movimentx < 0)
        //    {
        //        transform.localScale = new Vector2(scale, scale);
        //        rigidBody.AddRelativeForce(speed *10* Vector2.left);
        //    }
        //    if (movimenty < 0)
        //    {
        //        rigidBody.AddRelativeForce(speed *10* Vector2.down);
        //    }

        //  }

    }  
    
}