using UnityEngine;

public class Sword : Weapon
{
    //derived class
    public override void Attack()
    {
        Debug.Log("Sword is slashing");
    }
}
