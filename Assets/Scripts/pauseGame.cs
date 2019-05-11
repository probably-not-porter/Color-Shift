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

public class pauseGame : MonoBehaviour
{
    public GameObject controller; // game controller
    public GameObject gameControl; // top level

    public GameObject square_panel;
    public GameObject pause_text;
    public bool gameState = true; 
    public Sprite pause_image;
    public Sprite play_image;
    

    public void togglePause() // invert game state on click
    {
        Debug.Log("pause");
        gameState = !gameState;
        controller.GetComponent<control_3>().running = gameState;
    }
    void Update()
    {
        gameState = controller.GetComponent<control_3>().running;
        if (gameState != true) // game is paused
        {
            GetComponent<Image>().sprite = play_image;
            if (gameControl.GetComponent<screenControl>().activescreen == 1)
            {
                gameControl.GetComponent<screenControl>().pause();
            }
            
        }
        else // game is running
        {
            GetComponent<Image>().sprite = pause_image;
            if (gameControl.GetComponent<screenControl>().activescreen == 2)
            {
                gameControl.GetComponent<screenControl>().play3();
            }
        }
    }
}
