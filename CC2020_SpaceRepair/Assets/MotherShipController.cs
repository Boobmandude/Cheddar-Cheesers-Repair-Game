using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MotherShipController : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;
    public SpriteRenderer spriteR;
    public Sprite[] sprites;
    float addingHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 5;
        print(currentHealth);

        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[3];

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            playercontroler repairFuel = collision.gameObject.GetComponent<playercontroler>();

            currentHealth += repairFuel.subtractFuel(repairFuel.repairFuelMax);

           // Helthbar helthbar = helthbar.gameObject.Get<Helthbar>;

         

            print("You win");

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 40)
        {

            spriteR.sprite = sprites[0];

        }
        if (currentHealth >= 50)
        {

            spriteR.sprite = sprites[1];

        }
        if (currentHealth >= 100)
        {

            spriteR.sprite = sprites[2];
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

        //this is where win condition
        if (currentHealth >= maxHealth)
        {



        }
    }
}