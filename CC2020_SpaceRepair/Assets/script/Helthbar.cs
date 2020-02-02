using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
public class Helthbar : MonoBehaviour
{ 
    public float CurrentHealth { get; set; }
    public float maxHealth { get; set; }
    public UnityEngine.UI.Slider healthBar;
    float obstacleDamage;

    public GameObject Satalite;
    public GameObject Meteor;
    public GameObject ShootingStar;
    public GameObject Ship;
    public GameObject SmallMeteor;

    public GameObject RefuilStation;
    public GameObject ReleaseStation;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100f;
        CurrentHealth = maxHealth;

        healthBar.value = 100;
        StartCoroutine("LosingHealth");
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Refuel")
        {
            playercontroler repairFuel = other.gameObject.GetComponent<playercontroler>();
            healthBar.value += repairFuel.addFuel(repairFuel.repairFuelMax);
        }
        else if (other.gameObject.tag == "DoesDamage")
        {

            // obstacleDamage = other.gameObject.GetComponent<>();
            healthBar.value -= 5;
        }
        else if (other.gameObject.tag == "Mothership") {

            healthBar.value = 0;

        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private IEnumerator LosingHealth  ()
    {

        while (true)
        { yield return new WaitForSeconds(0.5f);
            healthBar.value -= 1;
        }


    }


}
