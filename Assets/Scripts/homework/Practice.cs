using UnityEngine;

class Practice : MonoBehaviour
{
    [SerializeField] int bulletCount = 10;
    [SerializeField] int magazineCount = 5;
    [SerializeField] int magazineCapacity = 10;

    [SerializeField] KeyCode shootKey = KeyCode.Space;  // Melyik gombra l�v�nk
    [SerializeField] KeyCode reloadKey = KeyCode.R;     // Melyik gombra t�lt�nk

    void Update()
    {
        bool shootKeyPress = Input.GetKeyDown(shootKey);
        bool reloadKeyPress = Input.GetKeyDown(reloadKey);

        if (shootKeyPress)
        {
            if (bulletCount > 0)
            {
                Debug.Log("Bumm");
                bulletCount--;

            }
            else
            {
                Debug.Log("Klikk");
            }
        }
        if (reloadKeyPress)
        {
            if (magazineCount > 0)
            {
                bulletCount = magazineCapacity;
                magazineCount--;
            }
        }
    }
}