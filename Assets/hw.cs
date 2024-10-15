using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class hw : MonoBehaviour
{
    
    public SpriteRenderer gutter;
    public Color TargetColor = Color.blue;
        
    // Start is called before the first frame update
    
    void Start()
    {  
        gutter.color = TargetColor;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
