using UnityEngine;

namespace MyGame.Characters
{
    public class Hero : MonoBehaviour
    {
        public int VariableHealth = 100;

        public void PrintHealth()
        {
            Debug.Log("Health: " + VariableHealth);
        }

    }

}
