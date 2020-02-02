using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject spawner;
    GameObject obstacleObject;
    float mass;
   public float speed;
    public float speedMultiplier;

    //public float meteorSpeed;
    //public float meteorDamage;
    //public float meteorSpeedMultiplier;

    //public float ufoSpeed;
    //public float ufoDamage;
    //public float ufoSpeedMultiplier;

    //public float shootingStarSpeed;
    //public float shootingStarDamage;
    //public float shootingStarSpeedMultiplier;

    //public float sataliteSpeed;
    //public float sataliteDamage;
    //public float sataliteSpeedMultiplier;

    //public float obsatcleDamage;
    //float obstacleSpeed;
    //float obstacleSpeedMultiplier;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //if (gameObject.tag == "Meteor")
        //{

        //    obsatcleDamage = meteorDamage;
        //    obstacleSpeed = meteorSpeed;
        //    obstacleSpeedMultiplier = meteorSpeedMultiplier;


        //    print("Meteor");
        //}
        //if (gameObject.tag == "UFO")
        //{

        //    obsatcleDamage = ufoDamage;
        //    obstacleSpeed = ufoSpeed;
        //    obstacleSpeedMultiplier = ufoSpeedMultiplier;
        //    print("UFO");

        //}
        //if (gameObject.tag == "ShootingStar")
        //{

        //    obsatcleDamage = ufoDamage;
        //    obstacleSpeed = ufoSpeed;
        //    obstacleSpeedMultiplier = ufoSpeedMultiplier;

        //    mass = spawner.GetComponent<ObstacleSpawner>().fMass;
        //    gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(obstacleSpeed * obstacleSpeedMultiplier * Vector2.down);
        //    print("ShootingStar");

        //}
        //if (gameObject.tag == "Satalite")
        //{

        //    obsatcleDamage = sataliteDamage;
        //    obstacleSpeed = sataliteSpeed;
        //    obstacleSpeedMultiplier = sataliteSpeedMultiplier;
        //    print("Satalite");

        //}

        spawner = GameObject.FindGameObjectWithTag("SpawnPoint");
        mass = spawner.GetComponent<ObstacleSpawner>().fMass;
        gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(speed * speedMultiplier * Vector2.down);
    }
}
