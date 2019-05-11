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

public class display3 : MonoBehaviour
{
    public Text displayScore; // display object
    public GameObject controller; // game controller
    public int highScore = 0;
    void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            highScore = PlayerPrefs.GetInt("highScore");
        }
    }
    void Update() //check for new highscore, if so update
    {
        if (controller.GetComponent<control_3>().winstreak > highScore)
        {
            highScore = controller.GetComponent<control_3>().winstreak;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        displayScore.text = "Best: " + highScore.ToString();
    }
}
