using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody2D))]
public class BlackHolesScript : MonoBehaviour
{
    private bool destroyBH = false;
    private float blackHoleCooldown = 2f;
    private float blackHoleCooldownLive = 4f;
    private float blackHoleTime = 0f;
    private float blackHoleTimeLive = 0f;
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
            if (blackHoleTime > blackHoleCooldown)
            {
                //FadeImage(true);
                Destroy(gameObject);
                destroyBH = false;
            }

        }
        else
        {
            blackHoleTimeLive += Time.deltaTime;
            if (blackHoleTimeLive > blackHoleCooldownLive)
            {
                //FadeImage(true);
                Destroy(gameObject);
                destroyBH = false;
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        playercontroler bird = collision.gameObject.GetComponent<playercontroler>();
        try
        {
            if (playerRigidBody.position != null)
            {
                bird.blackHoleInteraction(playerRigidBody.position); //call the interaction and send the position to the bird
            }
        }
        catch
        {

        }
        
        destroyBH = true;
    }

    //public Image img;

    // public IEnumerator FadeImage(bool fadeAway)
    //{
    //    // fade from opaque to transparent
    //    if (fadeAway)
    //    {
    //        // loop over 1 second backwards
    //        for (float i = 1; i >= 0; i -= Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //    // fade from transparent to opaque
    //    else
    //    {
    //        // loop over 1 second
    //        for (float i = 0; i <= 1; i += Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //}
}
