using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public GameObject[] interactables;
    void Start()
    {
        foreach(GameObject myobject in interactables)
        {
            IDamageable interactable = myobject.GetComponent<IDamageable>();
            if ( interactable != null )
            {
               // interactable.TakeDamage(int amount);
            }
        }
    }
}

