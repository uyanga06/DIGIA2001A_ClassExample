using UnityEngine;

public class HealthPotion : Potion
{
    public void RestoreHealth()
    {
        Debug.Log("Restoring health with " + potionName + "!");
    }

    void Start()
    {
        Drink();
        RestoreHealth();
    }
}
