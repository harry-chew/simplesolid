using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticUI : MonoBehaviour
{
    [SerializeField]
    private Text hullHealth;
    [SerializeField]
    private Text armourHealth;
    [SerializeField]
    private Text shieldHealth;

    [SerializeField]
    private Ship ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hullHealth.text = "Hull: " + ship.DisplayHull();
        armourHealth.text = "Armour: " + ship.DisplayArmour();
    }

    void UpdateHull()
    {

    }

    void UpdateArmour(int armourHealth)
    {

    }

    
}
