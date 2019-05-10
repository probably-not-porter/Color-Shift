using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenControl : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject threePanel;
    public GameObject threeController;
    public int menuX = 0;
    public int threeX = Screen.width;

    
    // Start is called before the first frame update
    void Start()
    {
        threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(threeX, 0f);
    }
    public void play() // start from menu and shift to 3x3
    {
        menuX = -Screen.width;
        threeX = 0;
        threeController.GetComponent<control_3>().running = true;
    }
    public void pause() // start from menu and shift to 3x3
    {
        menuX = 0;
        threeX = Screen.width;
        threeController.GetComponent<control_3>().running = false;
        threeController.GetComponent<control_3>().winstreak = 0;
    }

    // Update is called once per frame
    void Update()
    {
        menuPanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(menuX,0f);
        threePanel.GetComponent<RectTransform>().anchoredPosition = new Vector2(threeX,0f);
    }
}
