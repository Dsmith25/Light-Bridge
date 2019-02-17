using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class titleCrawl : MonoBehaviour
{
    public float scrollSpeed;
    RectTransform text;

    // Use this for initialization
    void Start ()
    {
        text = this.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        scrollText();
        skipStroy();
	}

    //scrolls the text upwards
    void scrollText()
    {
        Vector3 pos = text.localPosition;

        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        text.localPosition = pos;
    }

    //Press any key to skip the story and go to the main Menu
    void skipStroy()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
