using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public ScoreManager scoreManager;


    void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();

        string name = this.gameObject.name;
        switch (name)
        {
            case "Mothership(Clone)":
                speed = 10.0f;
                break;
            case "UFO(Clone)":
                speed = 15.0f;
                break;
            case "Scout(Clone)":
                speed = 20.0f;
                break;
            case "Powerup_Shell(Clone)":
                speed = 20.0f;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.CompareTag("Bullet") && other.gameObject.CompareTag("Enemy"))
        {
            scoreManager.GetPoints(other.gameObject.name);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
