using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    Animator anim;
    public GameObject Saklar;
    public bool sticks;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Switch")
        {
          anim.SetBool ("goDown", true);
          Saklar.SetActive(true);
        }
        // if (col.gameObject.tag == "Player")
        // {
        //   anim.SetBool ("goDown", true);  
        //   Saklar.SetActive(true);
        // } 
    }
    void OnTriggerExit2D(Collider2D col) {
       if (col.gameObject.tag == "Switch")
        {
          // if(sticks)
          //   return;

          anim.SetBool ("goDown", false);
          // Destroy(Saklar);
          Saklar.SetActive(false);
        }
        // if (col.gameObject.tag == "Player")
        // {
        //   anim.SetBool ("goDown", false);
        //   Saklar.SetActive(false);  
        // }
    }
}
