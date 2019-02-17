using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    int score = 0;
    public Text playerScore;

    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        score = score * 10;
        playerScore.text = score.ToString();
    }

    //void OnGUI()
    //{
    //    set our text to our score
    //    playerScore.text = score.ToString();
    //    if retry button is pressed load scene 0 the game
    //    if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 150, 100, 40), "Retry?"))
    //    {
    //        SceneManager.LoadScene("Game Scene");
    //    }
    //    and quit button
    //    if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 200, 100, 40), "Quit"))
    //    {
    //        Application.Quit();
    //    }
    //}

    public void retryButton()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
