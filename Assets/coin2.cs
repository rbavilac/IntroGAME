using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2 : MonoBehaviour
{
    public void GetBumped()
    {
        transform.position = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 
            Random.Range(-10, 0));
    }
}
