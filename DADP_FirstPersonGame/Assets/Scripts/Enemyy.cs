using UnityEngine;

namespace MyGame.Characters
{
    public class Enemyy : MonoBehaviour
    {
        public int VariableDamage = 25;
        public void PrintDamage()
        {
            Debug.Log("Damage: " + VariableDamage);
        }


    }
}
