using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotter : MonoBehaviour
{
    [SerializeField] private Transform shootOrigins;
    [SerializeField] private GameObject shootPrefabs;


    public void DoShoot()
    {
        //Instantiate(shootPrefabs, shootOrigins, false); #esta config se puede usar con laser, el disparo es hijo del origins
        Instantiate(shootPrefabs, shootOrigins.position, shootOrigins.rotation);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
