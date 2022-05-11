using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour, ICollectable
{
    [SerializeField]
    private ICollectable collectable;

    private void Awake()
    {
        collectable = GetComponent<ICollectable>();
    }

    public void Collect(Ship ship)
    {
        collectable.Collect(ship);
    }

}
