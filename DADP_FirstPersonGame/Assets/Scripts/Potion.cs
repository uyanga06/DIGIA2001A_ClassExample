using UnityEngine;

public class Potion : MonoBehaviour
{
   public string potionName;
    public int potency;
    public float volume;

    public void Drink()
    {
        Debug.Log("Drinking " + potionName + " with strong potency of " + potency + " with a volume of " + volume);
    }
}
