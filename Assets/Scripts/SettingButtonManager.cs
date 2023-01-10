using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButtonManager : MonoBehaviour
{
    public Animator settingAnimator, gearAnimator;
    private bool slideIn = false;
    private bool gearIn = false;
    public GameObject Gear;
    void Update()
    {
       if (Input.GetKeyDown (KeyCode.Escape)) {
            slideIn = false;
            gearIn = false;
            settingAnimator.SetBool("SlideIn", slideIn);
            gearAnimator.SetBool("GearIn", gearIn);
        } 
    }
    public void exitPanel() {
        slideIn = false;
        gearIn = false;
        settingAnimator.SetBool("SlideIn", slideIn);
        gearAnimator.SetBool("GearIn", gearIn);
    }
    
    public void SettingBtnMethod() {
        if (slideIn == false)
        {
            slideIn = true;
            gearIn = true;
            settingAnimator.SetBool("SlideIn", slideIn);
            gearAnimator.SetBool("GearIn", gearIn);
        } else if (slideIn == true) {
            slideIn = false;
            gearIn = false;
            settingAnimator.SetBool("SlideIn", slideIn);
            gearAnimator.SetBool("GearIn", gearIn);
        }
        // Gear.GetComponent<Animator>().SetTrigger("GearIn");
    }
}
