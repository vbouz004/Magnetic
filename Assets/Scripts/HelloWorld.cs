using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    int timeSince = 0;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
       
        
        //Transform ptrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if( (Time.time-timeSince) > 1f )
       {
        Debug.Log("Hello, World!");
        pos = transform.position;
        pos.y -= 1.0001f;
        transform.position = pos;
        timeSince++;
       }
       if(pos.y < 1)
       {
           this.enabled = false;
           //GetComponent("HelloWorld").enabled = false;
           //Destroy(this);
       }
    }
}
