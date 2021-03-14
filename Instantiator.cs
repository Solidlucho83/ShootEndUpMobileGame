using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    public void DoInstantiator()
    {
        Instantiate(prefab, transform.position, transform.rotation);
       

    }

   
}
