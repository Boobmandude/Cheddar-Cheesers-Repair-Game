using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeCountdownScript : MonoBehaviour
{
    TextMeshProUGUI textCoundown;
    private float timeCounter = 0;
    private int countDown = 30;
    private int counter = 1;
    private string timeShowString;
    void Start()
    {
        textCoundown = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter >= counter)
        {
            countDown -= 1;
            timeCounter = 0;
        }

        if (countDown <= 0) Defeat();

        if (countDown % 60 < 10)
        timeShowString = (countDown / 60).ToString() + ":0" + (countDown % 60).ToString();
        else
        timeShowString = (countDown / 60).ToString() + ":" + (countDown % 60).ToString();
        
        if (countDown > 0) textCoundown.text = timeShowString;
    }
    public void Defeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
