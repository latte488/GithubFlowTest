using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("surplus = "surplus(3,2));
    }

    int surplus(int a, int b)
    {
        return a % b;
    }
}
