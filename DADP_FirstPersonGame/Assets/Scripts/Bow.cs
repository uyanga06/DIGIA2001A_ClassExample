using UnityEngine;

public class Bow : Weapon
{
    //derived class
    public override void Attack()
    {
        Debug.Log("Bow is attacking with an arrow shot");
    }
}
