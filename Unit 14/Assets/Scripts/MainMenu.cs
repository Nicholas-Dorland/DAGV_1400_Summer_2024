using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioClip pressStart;
    public AudioClip pressQuit;

    private AudioSource buttonPress;

    // Start is called before the first frame update
    private void Start()
    {
        buttonPress = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        buttonPress.PlayOneShot(pressStart, 1.0f);
        Invoke("ChangeScene", 0.5f);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        buttonPress.PlayOneShot(pressQuit, 1.0f);
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
