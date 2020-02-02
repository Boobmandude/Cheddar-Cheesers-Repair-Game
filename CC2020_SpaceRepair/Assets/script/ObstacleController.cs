using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject spawner;
    float mass;
    float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("SpawnPoint");
        mass = spawner.GetComponent<ObstacleSpawner>().fMass;
        gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(speed * 10 * Vector2.down);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
