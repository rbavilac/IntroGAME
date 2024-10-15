using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmove : MonoBehaviour
{
    public Rigidbody2D RB;
    //public  int score; 
    // Update is called once per frame
    void Update()
    {

        if (PlayerScript.Score >= 5)
        { 
            RB.velocity = new Vector2(0, -7.8f);

            if (transform.position.y < -7.5f)
            {
                transform.position = new Vector2(transform.position.x, 7.5f);
            } 
        }
        else
        {
            RB.velocity = new Vector2(0,0);
        } 
    }

}


    
