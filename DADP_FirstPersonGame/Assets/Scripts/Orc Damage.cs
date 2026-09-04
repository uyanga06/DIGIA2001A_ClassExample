using UnityEngine;

public class OrcDamage : MonoBehaviour, IDamageable 
{
    public int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Orc took" + amount + "damage. Health is now:" + health);
    }
}
