using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxMountain : MonoBehaviour
{
     public float speed = -2f;
    // this refers to the speed the mountains are moving
    public GameObject mountain1, mountain2;
    // this refer to the sprites called mountains
    private GameObject okFunction;
    // this is accessing a script to check for a boolean
    public GameObject player;
    // this refers to the stationary bird
    private float mountainLength;
    // this will store the length of the mountain
    private void Start()
    {
        okFunction = GameObject.Find("ScoreManager");
        // ,he have set the okFunction to the game objcet scoremanager in the scene because we need to find its script
        mountainLength = mountain1.GetComponent<SpriteRenderer>().bounds.size.x;
        // we have set the mountainLength
    }
    private void Update()
    {
        if (okFunction.GetComponent<scoreScript>().OK == true) {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            // this will update the position of the mountain when the playe button is pressed
        }
        if (mountain1.transform.position.x + mountainLength / 2 <= player.transform.position.x - 10f) {
            mountain1.transform.position = new Vector2(mountain1.transform.position.x + ((2 * mountainLength)- 0.2f), mountain1.transform.position.y);
        }
        if (mountain2.transform.position.x + mountainLength / 2 <= player.transform.position.x - 10f)
        {
            mountain2.transform.position = new Vector2(mountain2.transform.position.x + ((2 * mountainLength) - 0.2f), mountain2.transform.position.y);
        }
        // the above conditions change the position of the mountains and make them look like they are looping
    }
}
