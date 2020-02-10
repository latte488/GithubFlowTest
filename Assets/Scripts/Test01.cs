using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Multiply(double.NegativeInfinity, double.PositiveInfinity));
        Debug.Log(surplus(3,2));
    }

    double Subtract(double a,double b)
    {
        return a - b;
    }

    double Multiply(double a, double b)
    {
        return a * b;
    }

    double surplus(double a,double b)
    {
        return a % b;
    }
}
