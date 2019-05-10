using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public GameObject controller;
    public bool gameState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void togglePause()
    {
        Debug.Log("pause");
        gameState = controller.GetComponent<control_3>().running;
        gameState = !gameState;
        controller.GetComponent<control_3>().running = gameState;
    }
}
