using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produce_numbers : MonoBehaviour
{
    public GameObject plusOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void create1()
    {
        Instantiate(plusOne, transform, false);
    }
}
