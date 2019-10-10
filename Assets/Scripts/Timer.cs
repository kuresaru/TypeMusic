using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;

    private float time = 0;
    private bool lastState;

	// Use this for initialization
	void Start ()
    {
        bool gameOver = GameControl.instance.gameOver;
        lastState = gameOver;
    }
	
	// Update is called once per frame
	void Update () {
        bool gameOver = GameControl.instance.gameOver;
        if (!gameOver)
        {
            if (lastState)
            {
                time = 0;
            }
            time += Time.deltaTime;
            timerText.text = time.ToString("F2") + " s";
        }
        lastState = gameOver;
	}
}
