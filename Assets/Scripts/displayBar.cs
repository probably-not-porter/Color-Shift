// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayBar : MonoBehaviour
{
    public GameObject controller; // game controller

    void Update() // update time bar every second
    {
        float barWidth = controller.GetComponent<control_3>().targetTime / controller.GetComponent<control_3>().roundTime * Screen.width * 0.7f;
        var selfTransform = transform as RectTransform;
        selfTransform.sizeDelta = new Vector2 (barWidth, selfTransform.sizeDelta.y);
    }

}
