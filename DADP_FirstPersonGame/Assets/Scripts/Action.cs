using NUnit.Framework;
using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Warrior warrior = gameObject.AddComponent<Warrior>();

        warrior.Name = "Uyanga";
        warrior.Weapon = "Sword";

        Debug.Log(warrior.Name);
        Debug.Log(warrior.Weapon);
    }
   
}
