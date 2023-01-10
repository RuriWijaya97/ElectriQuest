using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public static int secondsLeft;
    public int timeRemain;
    public bool takingAway = false;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;     
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    void Awake() {
        secondsLeft = timeRemain;
    }
    IEnumerator TimerTake() {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        takingAway = false;
    }
}
