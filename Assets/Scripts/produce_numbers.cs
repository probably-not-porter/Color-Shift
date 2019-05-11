// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produce_numbers : MonoBehaviour
{
    public GameObject plusOne; // prefab for +1 score

    public void create1() // create new +1 object
    {
        Instantiate(plusOne, transform, false);
    }
}
