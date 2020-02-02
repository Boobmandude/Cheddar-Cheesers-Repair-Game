using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MovementBird : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    public float playerSpeed = 1f; //you can change this in the interface
    private readonly float SPEEDCONSTANT = 1000f; //constant velocity multiplyer
    public float SPEEDBLACKHOLE = 500f;
    private bool blackHoleActivated = false;
    private float blackHoleCooldown = 2f;
    private float blackHoleTime= 3f;
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
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");

            float xForce = xInput * SPEEDCONSTANT * playerSpeed * Time.deltaTime;
            float yForce = yInput * SPEEDCONSTANT * playerSpeed * Time.deltaTime;

            Vector2 forces = new Vector2(xForce, yForce);

            playerRigidBody.AddForce(forces);

        }else
        {
            //Vector2 forces = new Vector2(0f, 0f);
            //Vector2 posBH = GameObject.Find("BlackHoles").transform.position;
            Vector2 posC = GameObject.Find("MainCharacter").transform.position;
            Vector2 forces = posBlackHole - posC;
           
            forces = forces.normalized;
            forces = forces * SPEEDBLACKHOLE * Time.deltaTime;
            playerRigidBody.AddForce(forces);
            blackHoleActivated = false;
            Debug.Log("SUCKING...");
        }

    }
    public void blackHoleInteraction(Vector2 vec)
    {
        posBlackHole = vec;
        if(blackHoleTime > blackHoleCooldown)
        {
            blackHoleTime = 0f;
            Debug.Log("BLACKHOLEEEE");
            blackHoleActivated = true;
        }
    }
    
}
