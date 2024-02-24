using System.Collections;                                       
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5.0f;
    public Camera cam;
    private int camPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) )
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,speed* Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate( 0, -speed * Time.deltaTime, 0);
        }
    }
    private void FixedUpdate()
    {
        if (transform.position.x - camPos > 10)
        {
            cam.transform.position += new Vector3(20, 0, 0);
            camPos += 20;
        }
        if (camPos - transform.position.x  > 10)

        {
            cam.transform.position -= new Vector3(20, 0, 0);
            camPos -= 20;
        }
    }
}
