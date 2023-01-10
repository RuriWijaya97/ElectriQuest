using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
           waitTime = 0.5f; 
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            if(waitTime <= 0) {
                effector.rotationalOffset = -90f;
                // effector.surfaceArc= 120f;
                waitTime = 0.5f;
            } else {
                waitTime -= Time.deltaTime;                
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
           waitTime = 0.5f; 
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            if(waitTime <= 0) {
                effector.rotationalOffset = 90f;
                // effector.surfaceArc= 120f;
                waitTime = 0.5f;
            } else {
                waitTime -= Time.deltaTime;                
            }
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            effector.rotationalOffset= 0;
            // effector.surfaceArc = 180f;
        }
    }
}
