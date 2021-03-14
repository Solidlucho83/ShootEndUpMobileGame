using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    [HideInInspector] 
    public EnemyConfig config;
     private Mover mover;

    private void Start()
    {
        mover = GetComponent<Mover>();
            if(mover != null)
            {
                mover.speed = config.moverSpeed;
            }

     }

}

