using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimerX : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private GameManagerX gameManagerX;
    public GameObject timer;
    public float totalTime = 60;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        timer.SetActive(false);
    }

    void Update()
    {
        totalTime -= Time.deltaTime;

        if (totalTime > 0)
        {
            Debug.Log(totalTime);
            timerText.text = "Time: " + Mathf.Round(totalTime);
        }
        else
        {
            totalTime = 0;
            timerText.text = "Time: 0";
            gameManagerX.GameOver();
        }
    }

    public void StartTimer()
    {
        timer.SetActive(true);
    }

    public void StopTimer()
    {
        timer.SetActive(false);
    }
}
