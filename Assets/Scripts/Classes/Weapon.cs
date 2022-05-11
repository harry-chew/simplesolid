using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private ILauncher launcher;

    private void Awake()
    {
        launcher = GetComponent<ILauncher>();
        GetComponent<ShipInput>().OnFire += Fire;

    }
 
    private void Fire()
    {
        launcher.Launch(this);
    }

}
