using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject  panelTutorial, panelInfo, panelExit;
    // public Animator closeButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown (KeyCode.Escape)) {
            panelExit.SetActive(true);
            // closeButton.SetBool("Exit", false);
        } 
    }
    public void exitPanel() {
        panelExit.SetActive(true);
        // closeButton.SetBool("Exit", false);
    }
    public void gotoExit() {
        Debug.Log("Exit This Game");
        Application.Quit();
    }
    public void gotoCancel() {
        panelExit.SetActive(false);
        // closeButton.SetBool("Exit", true);
    }
    public void levelSelect() {
        SceneManager.LoadScene("LevelSelectScene");
    }
    public void backMenu() {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void level1() {
        SceneManager.LoadScene("Level1");
    }
}
