using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"Add(1, 2) = {Add(1, 2)}");
    }

    int Add(int a, int b)
    {
        return a + b;
    }
}
