using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeSpawn : MonoBehaviour
{

    public GameObject bridge;

    float lastx = 0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        drawLine();
    }

    //draws the line
    void drawLine()
    {
        //checks to see if it has moved far enough to draw more line
        if (transform.position.x > (lastx + 0.02f))
        {
            Instantiate(bridge, transform.position, Quaternion.identity);
            lastx = transform.position.x;

            lastx = transform.position.x;
        }
    }
}
