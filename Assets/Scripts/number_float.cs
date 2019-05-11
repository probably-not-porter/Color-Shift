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

public class number_float : MonoBehaviour
{
    public Text text;
    public float r=1f,g=1f,b=1f,a=1f;

    void Start()
    {
        text = GetComponent<Text>();
        text.color= new Color(r,g,b,a);
    }

    // Update is called once per frame
    void Update()
    {
        if (a > 0f)
        {
            a = a - 0.03f;
        }
        else
        {
            Destroy(gameObject);
        }
        text.color= new Color(r,g,b,a);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
