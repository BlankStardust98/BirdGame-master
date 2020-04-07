using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingbackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRend;
    
    

    // Start is called before the first frame update
    void Start()
    {
        backgroundSpeed = 0;
    }

    void Update()
    
    {
        
        Scrolling();
       
    }

    // Update is called once per frame
    public void Scrolling()
    {
           
            backgroundRend.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        
        
    }
}
