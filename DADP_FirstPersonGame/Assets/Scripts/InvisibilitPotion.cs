using UnityEngine;

public class InvisibilityPotion : Potion
{
   public void BecomeInvisible()
    {
        Debug.Log("Player is now invisible after drinking " + potionName + "!");
    }

    void Start()
    {
        Drink();
        BecomeInvisible();
    }
}
