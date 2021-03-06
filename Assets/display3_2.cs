﻿// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display3_2 : MonoBehaviour
{
    public Text displayScore; // display object
    public GameObject controller; // game controller
    public int highScore = 0;
    void Start()
    {
        if (PlayerPrefs.HasKey("4x4 highScore"))
        {
            highScore = PlayerPrefs.GetInt("4x4 highScore");
        }
    }
    void Update() //check for new highscore, if so update
    {
        if (controller.GetComponent<control_4>().winstreak > highScore)
        {
            highScore = controller.GetComponent<control_4>().winstreak;
            PlayerPrefs.SetInt("4x4 highScore", highScore);
        }
        displayScore.text = "Best: " + highScore.ToString();
    }
}