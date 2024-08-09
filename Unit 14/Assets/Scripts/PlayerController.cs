using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform blaster;
    public GameObject lazerBolt;
    public GameObject powerupIndicator;
    public AudioClip shootSound;
    public float horizontalInput;

    private float speed = 25;
    private float xRange = 30;
    private bool hasPowerup;
    private GameManager gameManager;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        hasPowerup = false;
        powerupIndicator.SetActive(false);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        powerupIndicator.transform.position = transform.position;

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !gameManager.isGameOver)
        {
            playerAudio.PlayOneShot(shootSound, 1.0f);
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shield"))
        {
            Destroy(other.gameObject);
            hasPowerup = true;
            powerupIndicator.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            if (hasPowerup)
            {
                gameManager.PlayDestroy();
                hasPowerup = false;
                powerupIndicator.SetActive(false);
                Destroy(other.gameObject);
            }
            else
            {
                gameManager.PlayExplode();
                Debug.Log("Game Over!");
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
