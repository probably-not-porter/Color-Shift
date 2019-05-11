// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenControl : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject threePanel;
    public GameObject pausePanel;
    public GameObject losePanel;

    public GameObject threeController;

    public int activescreen = 0;

    public int onScreen = 0;
    public int offScreen = Screen.width;

    
    // Start is called before the first frame update
    void Start()
    {
        threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
        pausePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
        losePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
    }
    public void play3() // start from menu and shift to 3x3
    {
        activescreen = 1;
        threeController.GetComponent<control_3>().running = true;
    }
    public void menu() // start from menu and shift to 3x3
    {
        activescreen = 0;
        threeController.GetComponent<control_3>().running = false;
        threeController.GetComponent<control_3>().winstreak = 0;
    }
    public void pause()
    {
        activescreen = 2;
        threeController.GetComponent<control_3>().running = false;
    }
    public void lost()
    {
        activescreen = 3;
        threeController.GetComponent<control_3>().running = false;
        threeController.GetComponent<control_3>().winstreak = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (activescreen == 0) // menu
        {
            menuPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(onScreen,0f); 
            threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f);
            pausePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
            losePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
        }
        else if (activescreen == 1) // 3x3 game
        {
            menuPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f); 
            threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(onScreen,0f);
            pausePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
            losePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
        }
        else if (activescreen == 2) // paused
        {
            menuPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f); 
            threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f);
            pausePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(onScreen, 0f);
            losePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
        }
        else if (activescreen == 3) // lost
        {
            menuPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f); 
            threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen,0f);
            pausePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(offScreen, 0f);
            losePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(onScreen, 0f);
        }
        // UPDATE POSITIONS OF SCREENS IF NECISSARY
        
    }
}
