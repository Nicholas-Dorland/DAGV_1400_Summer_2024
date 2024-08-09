using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public AudioClip playerExplode;
    public AudioClip enemyExplode;
    public AudioClip gameOver;

    private GameObject gameOverText;
    private AudioSource gameAudio;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("Game Over Text");
        gameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayExplode()
    {
        gameAudio.PlayOneShot(playerExplode, 1.0f);
    }

    public void PlayDestroy()
    {
        gameAudio.PlayOneShot(enemyExplode, 1.0f);
    }

    public void PlayEnd()
    {
        gameAudio.PlayOneShot(gameOver, 1.0f);
    }
}
