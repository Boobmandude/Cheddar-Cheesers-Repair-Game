using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class playercontroler : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    public float playerSpeed = 1f; //you can change this in the interface
    private readonly float SPEEDCONSTANT = 1000f; //constant velocity multiplyer
    public float SPEEDBLACKHOLE = 500f;
    public float ROTATIONSPEED = 5f;
    private bool blackHoleActivated = false;
    private float blackHoleCooldown = 2f;
    private float blackHoleTime = 3f;
    private Vector2 posBlackHole;



    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>(); //needed everytime to get the rigidbody2d components and mofify them
        playerRigidBody.drag = 5;
    }

    void FixedUpdate()
    {
        blackHoleTime += Time.deltaTime;
        InputAxis(); // calling the function that we created;
    }

    public void InputAxis()
    {
        if (!blackHoleActivated && blackHoleTime > blackHoleCooldown)
        {
            float rotationBody = 0;
            Vector2 forces = new Vector2();
            float xInput = Input.GetAxis("Horizontal");
            if (xInput != 0)
            {
                if (xInput > 0)
                    transform.Rotate(0, 0, -ROTATIONSPEED);
                else transform.Rotate(0, 0, ROTATIONSPEED);
            }
            float yInput = Input.GetAxis("Vertical");
            if (yInput != 0)
            {
                rotationBody = playerRigidBody.rotation * Mathf.PI / 180;
                forces = new Vector2(Mathf.Cos(rotationBody), Mathf.Sin(rotationBody));
                if (yInput > 0)
                    forces = -forces * SPEEDCONSTANT * playerSpeed * Time.deltaTime;
                else forces = forces * SPEEDCONSTANT * playerSpeed * Time.deltaTime;

                playerRigidBody.AddForce(forces);
            }





        }
        else
        {
            Vector2 posC = playerRigidBody.position;
            Vector2 forces = posBlackHole - posC;

            forces = forces.normalized; // vector normalized.
            forces = forces * SPEEDBLACKHOLE * Time.deltaTime;
            playerRigidBody.AddForce(forces);
            blackHoleActivated = false;
            Debug.Log("SUCKING...");
        }

    }
    public void blackHoleInteraction(Vector2 vec)
    {
        posBlackHole = vec;
        if (blackHoleTime > blackHoleCooldown)
        {
            blackHoleTime = 0f;
            Debug.Log("BLACKHOLEEEE");
            blackHoleActivated = true;
        }
    }

}
