
using UnityEngine;

public class circle : MonoBehaviour
{

    void Start()
    {
        float radius = 7;
        float kerület = 2 * radius * Mathf.PI;
        float terület = radius * radius * Mathf.PI;

        Debug.Log($"kerület  {kerület}");
        Debug.Log($"terület {terület}");

    }
    
}
