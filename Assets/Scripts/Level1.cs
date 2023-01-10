using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level1 : MonoBehaviour
{
    // public GameObject interact1, interact2, interact3, interact4, interact5;
    public int scoring;
    public int lamps;
    public GameObject panelWin;

    public GameObject []  SwitchOn, SwitchOff, Light, LightOff, Stars;
    public Text score;
    public Text lamp;
    private static int secondsLeft;
    // Start is called before the first frame update
    void Start () {

    }
    
    void Update () {
        winPanel();
        secondsLeft = TimerCountdown.secondsLeft;
    }

    public void LightOff1() {
        if (SwitchOn[0].activeSelf == true) {
            Light[0].SetActive(false);
            SwitchOn[0].SetActive(false);
            SwitchOff[0].SetActive(true);
            LightOff[0].SetActive(true);
            lamps++;
            lamp.text = "" + lamps + "";
		} 
    }
    public void LightOff2() {
        if (SwitchOn[1].activeSelf == true) {
            Light[1].SetActive(false);
            SwitchOn[1].SetActive(false);
            SwitchOff[1].SetActive(true);
            LightOff[1].SetActive(true);
            lamps++;
            lamp.text = "" + lamps + "";
		} 
    }
    public void LightOff3() {
        if (SwitchOn[2].activeSelf == true) {
            Light[2].SetActive(false);
            SwitchOn[2].SetActive(false);
            SwitchOff[2].SetActive(true);
            LightOff[2].SetActive(true);
            lamps++;
            lamp.text = "" + lamps + "";
		} 
    }
    public void LightOff4() {
        if (SwitchOn[3].activeSelf == true) {
            Light[3].SetActive(false);
            SwitchOn[3].SetActive(false);
            SwitchOff[3].SetActive(true);
            LightOff[3].SetActive(true);
            lamps++;
            lamp.text = "" + lamps + "";
		} 
    }
    public void LightOff5() {
        if (SwitchOn[4].activeSelf == true) {
            Light[4].SetActive(false);
            SwitchOn[4].SetActive(false);
            SwitchOff[4].SetActive(true);
            LightOff[4].SetActive(true);
            lamps++;
            lamp.text = "" + lamps + "";
		} 
    }

    void winPanel() {
        if (lamps == 3 && secondsLeft == 0) {
            panelWin.SetActive(true);
            Time.timeScale = 0;
            Stars[0].SetActive(true);
        } else if (lamps == 4 && secondsLeft == 0) {
            panelWin.SetActive(true);
            Time.timeScale = 0;
            Stars[0].SetActive(true);
            Stars[1].SetActive(true);
        } else if (lamps == 5) {
            panelWin.SetActive(true);
            Time.timeScale = 0;
            Stars[0].SetActive(true);
            Stars[1].SetActive(true);
            Stars[2].SetActive(true);
        } 
    }
}
