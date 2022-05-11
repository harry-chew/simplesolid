using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveArmour : MonoBehaviour, ICollectable
{
    private void Awake()
    {
        
    }
    public void Collect(Ship ship)
    {
        Debug.Log("Give Armour - Collect triggered");
        ship.AddArmour();

    }

    //public void Collect(PickUp pickUp)
    //{
    //    Debug.Log(gameObject.name);
    //}
}
