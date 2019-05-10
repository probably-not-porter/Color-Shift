using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayBar : MonoBehaviour
{
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float barWidth = controller.GetComponent<control_3>().targetTime / controller.GetComponent<control_3>().roundTime * Screen.width * 0.8f;
        Debug.Log(barWidth);
        Debug.Log(Screen.width);
        
        var selfTransform = transform as RectTransform;
        selfTransform.sizeDelta = new Vector2 (barWidth, selfTransform.sizeDelta.y);
    }
}
