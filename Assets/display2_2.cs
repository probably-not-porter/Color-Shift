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

public class display2_2 : MonoBehaviour
{
    public Text displayScore; // display object
    public GameObject controller; // game controller

    void Update() // update score GUI every frame
    {
        displayScore.text = controller.GetComponent<control_4>().winstreak.ToString();
    }
}
