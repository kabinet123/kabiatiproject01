using UnityEngine;

class ControlStructures : MonoBehaviour
{
    void Start()
    {
        int number = 12;

        if (number > 0)
        {
            Debug.Log("Pozitiv sz�m");
        }
        else
        {
            Debug.Log("negativ sz�m");
        }

        string isEven;
        if (number % 2 == 0)
            isEven = "EVEN";// P�ros
        else
            isEven = "ODD";// P�ratlan

        isEven = number % 2 == 0 ? "EVEN" : "ODD";
        

        
    }
}
