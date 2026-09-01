using UnityEngine;
using MyGame.Characters;
 public class Testings : MonoBehaviour
 {
    public Hero hero;
    public Enemyy enemy;

    void Start()
    {
        hero.PrintHealth();
        enemy.PrintDamage();
    }
 }


