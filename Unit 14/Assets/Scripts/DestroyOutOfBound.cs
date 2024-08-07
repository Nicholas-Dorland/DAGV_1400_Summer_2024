using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float topBound = 30.0f;
    public float bottomBound = -25.0f;
    public ScoreManager scoreManager;


    // Start is called before the first frame update
    void Awake()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            scoreManager.LosePoints(this.gameObject.name);
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
