using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Multiply(double.NegativeInfinity, double.PositiveInfinity));
    }

    double Multiply(double a, double b)
    {
        return a * b;
    }
}
