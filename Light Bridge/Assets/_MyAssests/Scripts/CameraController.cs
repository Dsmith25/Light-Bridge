using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    float yDir = 0f;
    public GameObject player;
    public Text scoreNum;
    public float playerScore = 0;
    public static CameraController instance;

    void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        panCamera();
        changeScore();
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(playerScore));
    }
    //moves the camera to the right
    void panCamera()
    {
        //check to see if player exits
        if (player)
        {
            //moves the camera right if the player passes the x threshold
            if (player.transform.position.x > -1)
            {
                //sets the score value based on how long the player has stayed alive.
                playerScore += Time.deltaTime;

                float randY = 0f;
                randY = Random.Range(0f, 100f);
                if (randY < 20)
                {
                    yDir = yDir + .00125f;
                }
                else if (randY > 20 && randY < 40)
                {
                    yDir = yDir - .00125f;
                }
                else if (randY > 80)
                {
                    yDir = 0f;
                }

                transform.position = new Vector3(transform.position.x + 0.003f, transform.position.y + yDir, -10);
            }
        }
    }

    //changes the score text
    void changeScore()
    {
        scoreNum.text = ((int)(playerScore * 10)).ToString();
    }
}
