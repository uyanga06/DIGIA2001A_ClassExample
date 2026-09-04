using UnityEngine;
using UnityEngine.InputSystem;

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

    public void OnDamage(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
}

