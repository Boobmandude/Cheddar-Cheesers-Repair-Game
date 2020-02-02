using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBlackHolesScript : MonoBehaviour
{
    public GameObject BlackHoles;
    public float timeToSpawn = 3f;
    private float cooldownTime = 1f;
    private float randX, randY;
    private Vector2 posBlackHoles;
    void Start()
    {
        
    }

    void Update()
    {
        if(cooldownTime > timeToSpawn)
        {
            randX = Random.Range(-6f, 6f);
            randY = Random.Range(-4f, 4f);
            posBlackHoles = new Vector2(randX, randY);
            Instantiate(BlackHoles, posBlackHoles, Quaternion.identity);
            cooldownTime = 0;
            
        }
        cooldownTime += Time.deltaTime;

    }
}
