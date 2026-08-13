using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;

    public void TakeDamage(int damage)
    {
        health -= damage;
        
    }
}
