using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownScrip : MonoBehaviour
{
    TextMeshProUGUI textCoundown;
    private float timeCounter = 0f;
    private float countDown = 3f;
    private float  counter = 0.8f;
    void Start()
    {
        textCoundown = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCounter += Time.deltaTime;
        if(timeCounter >= counter)
        {
            countDown -= 1;
            timeCounter = 0;
        }
        
        if (countDown <= 0) PlayGame();
        if(countDown > 0 )textCoundown.text = countDown.ToString();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
