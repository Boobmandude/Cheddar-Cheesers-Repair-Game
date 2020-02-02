using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElipseMovement : MonoBehaviour
{
    Rigidbody2D sateliteRigidBody;
    private float angle;
    public float velocityangule = 0.5f;
    public float velocityCentrifuge = 1f;
    Vector2 velT = new Vector2();
    public float damage;

    void Start()
    {
        sateliteRigidBody = GetComponent<Rigidbody2D>();
    }

  
    void FixedUpdate()
    {     
        angle = sateliteRigidBody.rotation * Mathf.PI / 180;
        velT = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        velT = velT * velocityCentrifuge * Time.deltaTime;
        sateliteRigidBody.AddForce(velT);
        transform.Rotate(0, 0, -velocityangule);
    }
}
