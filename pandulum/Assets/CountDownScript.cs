using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float Timer;
    private bool canCount = true;
    private bool doOnce = false;

    void satrt()
    {
        Timer = mainTimer;
    }

    void Update()
    {
        if ( Timer >= 0.0f && canCount )
        {
            Timer -= Time.deltaTime;
            uiText.text = Timer.ToString("F");
        }
        else if ( Timer <= 0.0f && !doOnce )
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            Timer = 0.0f;
        }
    }

    public void  ResetBtn()
    {
        Timer = mainTimer;
        canCount = true;
        doOnce = false;


    }

    void Gameover()
    {
        // Load a new scene
    }

}
