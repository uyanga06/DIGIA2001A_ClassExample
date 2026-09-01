using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string Namw;
    public int Damage;

    public virtual void Attack()
    {
        Debug.Log("Weapon is attacking");
    }
}
