using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController: MonoBehaviour
{

    int[] widthArray = new int[] { 720, 1280, 1920 };
    int[] heightArray = new int[] { 480, 720, 1080};
    public int resolutionOption;

    double widthSpawnPointPercentage = 0.10;
    double heightSpawnPointPercentage = 0.33;

    double spawnPointX;
    double spawnPointY;

    public Transform spawnpoint;
    public GameObject obstacle;
    Transform spawnTransform;

    double damageDealt = 5;
    double DamageRate = 1000000f;
    double nextDamage;

    double playerHealth = 100;
    double timer;
    // Start is called before the first frame update

    void setResolution() {


        print("Width" + widthArray[resolutionOption] + "Height" + heightArray[resolutionOption]);
        Screen.SetResolution(widthArray[0], heightArray[0], true);

    }


    void setSpawnPoints() {
       
        GameObject spawner = GameObject.Find("house");
      
        if (spawner != null)
        {
            spawnTransform = spawner.transform;
            Debug.Log("Spawnpoint not found");
        }
        else
        {
            Debug.Log("Spawnpoint not found");
        }


    }


    void spawn() {



    }

    //void dealDamageOT(double health) {

    //    nextDamage = Time.DeltaTime + DamageRate;
    


    
    //}



    void Start()
    {
        setResolution();
        setSpawnPoints();
        

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        nextDamage = timer + DamageRate;
        if (nextDamage > timer)
        {
            nextDamage = Time.deltaTime + DamageRate;
            // Remove the recorded 2 seconds.
            Instantiate(obstacle, transform.position, transform.rotation);
            

        }
    }
}
