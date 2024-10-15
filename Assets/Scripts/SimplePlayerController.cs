using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them
    
    //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public Rigidbody2D RB;
    
    //This will control how fast the player moves
    public float Speed = 5;
    public SpriteRenderer Square;
    //Start automatically gets triggered once when the objects turns on/the game starts
    void Start()
    {
        //This is empty for now.
    }

    //Update is a lot like Start, but it automatically gets triggered once per frame
    //Most of an object's code will be called from Update--it controls things that happen in real time
    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0,0);
        
        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        // this is the code so it wraps around, leaves the creen and it appears the opposite side
        if (transform.position.x > 11)
        {
            transform.position = new Vector2(-11f, transform.position.y); 
            Square.color = Color.white;
        }
        
        if (transform.position.x < -11)
        { transform.position = new Vector2(11f, transform.position.y); }
        
        if (transform.position.y > 5)
        { transform.position = new Vector2(transform.position.x,-5f); }
        
        if (transform.position.y <-5)
        { transform.position = new Vector2(transform.position.x,5f); }
        
        // this is code for it to change colors when it wraps around

        if (transform.position.x < 11)
        {Square.color = Color.magenta;}

        if (transform.position.x > 11)
        {}
        
        if (transform.position.y < 5)
        {Square.color = Color.cyan;}

        if (transform.position.y > -5)
        {Square.color = Color.white;}
        
        
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.velocity = vel;
    }
}
