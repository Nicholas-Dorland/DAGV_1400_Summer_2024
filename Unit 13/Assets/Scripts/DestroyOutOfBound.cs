using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float topBound = 30.0f;
    public float bottomBound = -25.0f;

    // Start is called before the first frame update
    void Awake()
    {
        //Time.timeScale = 1;
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
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
