using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform blaster;
    public GameObject lazerBolt;
    public GameObject powerupIndicator;
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;
    public bool hasPowerup;

    // Start is called before the first frame update
    void Start()
    {
        hasPowerup = false;
        powerupIndicator.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
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
                hasPowerup = false;
                powerupIndicator.SetActive(false);
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("Game Over!");
                Destroy(gameObject);
            }
        }
    }
}