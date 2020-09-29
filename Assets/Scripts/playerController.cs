using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    //speed of player
    public float speed = 10;

    //bounds of player
    public float topBound = 4.5F;
    public float BottomBound = -4.5F;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //pause or plays game when player hits p
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
        } else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

    }

    void FixedUpdate()
    {
        //get play input and set speed
        float movementSpeedY = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, movementSpeedY, 0);

        //set bounds of player
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        } else if (transform.position.y < BottomBound)
        {
            transform.position = new Vector3(transform.position.x, BottomBound, 0);
        }
    }
    
        
 


}
