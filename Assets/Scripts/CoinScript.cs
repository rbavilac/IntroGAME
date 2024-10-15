using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        // code for the coin reapear once its hit, which actually only changing its position
       transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 
           Random.Range(-10, 0));
        
        //This destroys the coin
        //Destroy(gameObject);
    }
}
