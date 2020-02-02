using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class BlackHolesScript : MonoBehaviour
{
    private bool destroyBH = false;
    private float blackHoleCooldown = 2f;
    private float blackHoleTime = 0f;
    private Rigidbody2D playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyBH) //if there is collition, we wait blackholecooldown to destroy the black hole.
        {
            blackHoleTime += Time.deltaTime;
            if (blackHoleTime > blackHoleCooldown) Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        playercontroler bird = collision.gameObject.GetComponent<playercontroler>();
        bird.blackHoleInteraction(playerRigidBody.position); //call the interaction and send the position to the bird
        destroyBH = true;
    }
}
