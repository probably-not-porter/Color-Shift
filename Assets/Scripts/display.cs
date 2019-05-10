using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display : MonoBehaviour
{
    public Text displayTime;
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayTime.text = System.Math.Round(controller.GetComponent<control_3>().targetTime * 10).ToString();
    }
}
