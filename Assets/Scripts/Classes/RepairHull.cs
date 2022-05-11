using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RepairHull : MonoBehaviour, ICollectable
{
    public void Collect(Ship ship)
    {
        ship.RepairHull();
    }
}
