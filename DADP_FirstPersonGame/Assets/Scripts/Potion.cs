using UnityEngine;

public class Potion : MonoBehaviour
{
   public string potionName;
    public int potency;
    public int volume;

    public void Drink()
    {
        Debug.Log("Drinking " + potionName + " with strong potency and volume " + volume);
    }
}
