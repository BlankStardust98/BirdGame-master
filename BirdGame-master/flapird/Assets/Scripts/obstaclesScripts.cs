using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesScripts : MonoBehaviour
{
    
    
    public float pipeSpeed;
   
   
    // Start is called before the first frame update
    void Start()
    {
        pipeSpeed = 3f;
    }

    // Update is called once per frame
   public  void Update()
    {
        
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
