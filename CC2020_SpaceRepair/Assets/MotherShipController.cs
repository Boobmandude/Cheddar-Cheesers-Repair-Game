using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShipController : MonoBehaviour
{

    public float maxHealth;
    float currentHealth;
    private SpriteRenderer spriteR;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        //currentHealth = maxHealth / 4;
        //print(currentHealth);

        //gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];
        ////sprites = Resources.LoadAll<Sprite>(Mothersheet_0,Mothersheet_1,Mothersheet_2);
    }

    // Update is called once per frame
    void Update()
    {
        //while (currentHealth <= 40) {

        //    spriteR.sprite = sprites[0];

        //}
        //while (currentHealth >= 50)
        //{

        //    spriteR.sprite = sprites[1];

        //}
        //while(currentHealth >= 80)
        //{

        //    spriteR.sprite = sprites[2];

        //}
    }
}
