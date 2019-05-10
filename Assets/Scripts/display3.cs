using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display3 : MonoBehaviour
{
    public Text displayScore;
    public GameObject controller;
    public int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.GetComponent<control_3>().winstreak > highScore)
        {
            highScore = controller.GetComponent<control_3>().winstreak;
        }
        displayScore.text = "Best: " + highScore.ToString();
    }
}
