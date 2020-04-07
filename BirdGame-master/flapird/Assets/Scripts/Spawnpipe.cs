using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpipe : MonoBehaviour
{
    // Time to wait to spawn  another pipe.
    public float maxTimebetweenspawn = 1f;
    //The time that is passing.
    private float timepassing  = 0;
    public GameObject Pipes;
    // pipe height.
    public float height;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
           // GameObject newPipes = Instantiate(Pipes);
           // newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
       if (timepassing > maxTimebetweenspawn)
        {
           // the object i want to instantiate.the newPipes Gameobject is the Carrier.
           GameObject newPipes = Instantiate(Pipes);
           // this assign a position for the new clone pipes, also changes the height by a certain value.
           newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipes,5);
           // resetting the timepassing so its executes again when  its greater than one maxTimebetweenspawn.
            timepassing = 0;
            
        }
             timepassing += Time.deltaTime;
    }
}
