// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayBar2 : MonoBehaviour
{
    public GameObject controller; // game controller

    void Update() // update time bar every second
    {
        float barWidth = controller.GetComponent<control_4>().targetTime / controller.GetComponent<control_4>().roundTime * Screen.width * 0.75f;
        var selfTransform = transform as RectTransform;
        selfTransform.sizeDelta = new Vector2(barWidth, selfTransform.sizeDelta.y);
    }

}
