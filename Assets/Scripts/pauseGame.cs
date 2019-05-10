// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public GameObject controller; // game controller
    public bool gameState; 

    public void togglePause() // invert game state on click
    {
        Debug.Log("pause");
        gameState = controller.GetComponent<control_3>().running;
        gameState = !gameState;
        controller.GetComponent<control_3>().running = gameState;
    }
}
