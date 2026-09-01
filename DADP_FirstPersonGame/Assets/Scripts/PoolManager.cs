using UnityEngine;
using System.Collections.Generic;
public class PoolManager : MonoBehaviour
{
    public GameObject prefab; //object to pool
    public int poolSize = 10; //size of pool/objects to pre-instantiate

    private List<GameObject> pool = new List<GameObject>(); //creating a list
    void Start()
    {
        // Create pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false); //sets camera to false on awake but it is still there
            pool.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        //trying to find an inactive object
        for (int i = 0; i < pool.Count; i++)
        {
           if (!pool[i].activeInHierarchy) //if not active in the heirarchy, then they are available in pool
            {
                pool[i].SetActive(true); //when called, set active
                return pool[i]; //return object to calling class
            }
        }

        //If we got here then all objects are active, then we must reset the pool
        for (int i = 0; i < pool.Count; i++)
        {
            pool[i].SetActive(false);
        }

        //Hand out the first object after reset
        var obj = pool[0];
        obj.SetActive(true); //the first object in the pool list must be returned to GetObject()
        return obj;
    }
}
