using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputProviders
{
    public delegate void HasShoot();
    public static event HasShoot OnhasShoot;


    public delegate void Direction(Vector3 direction);
    public static event Direction OnDirection;
    public static void TriggerOnhasShoot()
    {
        OnhasShoot?.Invoke();
    }
    public static void TriggerDirection(Vector3 direction)
    {
        OnDirection?.Invoke(direction);
    }
}
