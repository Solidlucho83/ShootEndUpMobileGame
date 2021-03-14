using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OncolisionDo : MonoBehaviour
{
    [SerializeField] private UnityEvent action;
    private GameObject collisione;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisione = collision.gameObject;
        action.Invoke();
    }
    public void DestroyColissione()
    {
        if(collisione != null)
        {
            Destroy(collisione);
        }
    }
}
