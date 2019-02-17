using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{

    Animator anim;
    public float explodeRadius;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        waitForShip();
        bombDestroy();
    }

    //delays bombs until the hand has moved a certain amount
    void waitForShip()
    {
        if (transform.position.x > 20)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    //destorys objects after the explosions
    void bombDestroy()
    {
        //waits till th end of the explosion animation
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("bombDead"))
        {
            //destroy all objects in the explosions
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explodeRadius);

            foreach (Collider2D col in colliders)
            {
                if (col.tag != "Player" && col.tag != "Ship")
                {
                    Destroy(col.gameObject); 
                }
            }
            Destroy(this.gameObject);
        }
    }
}
