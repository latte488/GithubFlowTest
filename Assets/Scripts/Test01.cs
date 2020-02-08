using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Multiply(double.NegativeInfinity, double.PositiveInfinity));
        Debug.Log($"surplus = {surplus(3, 2)}");
    }

    double Multiply(double a, double b)
    {
        return a * b;
    }

    int surplus(int a, int b)
    {
        return a % b;
    }
}
