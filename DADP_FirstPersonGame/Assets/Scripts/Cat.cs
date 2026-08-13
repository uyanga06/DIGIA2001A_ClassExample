using UnityEngine;

public class Cat : MonoBehaviour
{
    //properties
    public string Name;
    public int Age;

    public void Meow() //method
    {
        Debug.Log("Meow! My name is " + Name + " and I am " + Age + " years old.");
    }
}
