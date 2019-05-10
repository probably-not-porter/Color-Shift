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

public class display : MonoBehaviour
{
    public Text displayTime; // display object
    public GameObject controller; // game controller

    void Update() // update time GUI every second
    {
        displayTime.text = System.Math.Round(controller.GetComponent<control_3>().targetTime * 10).ToString();
    }
}
