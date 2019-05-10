using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display2 : MonoBehaviour
{
    public Text displayScore;
    public GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score: " + controller.GetComponent<control_3>().winstreak.ToString();
    }
}
