using UnityEngine;

class ControlStructures : MonoBehaviour
{
    void Start()
    {
        int number = 12;

        if (number > 0)
        {
            Debug.Log("Pozitiv szám");
        }
        else
        {
            Debug.Log("negativ szám");
        }

        string isEven;
        if (number % 2 == 0)
            isEven = "EVEN";// Páros
        else
            isEven = "ODD";// Páratlan

        isEven = number % 2 == 0 ? "EVEN" : "ODD";
        

        
    }
}
