using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBlackHolesScript : MonoBehaviour
{
    public GameObject BlackHoles;
    public float timeToSpawn = 2f;
    private float cooldownTime = 0f;
    private float randX, randY;
    private Vector2 posBlackHoles;
    void Start()
    {
        
    }

    void Update()
    {
        if(cooldownTime > timeToSpawn)
        {
            randX = Random.Range(-8f, 8f);
            randY = Random.Range(-5f, 5f);
            posBlackHoles = new Vector2(randX, randY);
            Instantiate(BlackHoles, posBlackHoles, Quaternion.identity);
            cooldownTime = 0;
            
        }
        cooldownTime += Time.deltaTime;

    }
}
