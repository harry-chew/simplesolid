using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    private int hullHealth;
    [SerializeField]
    private int armourHealth;
    [SerializeField]
    private int shieldHealth;
    [SerializeField]
    private bool hasShield;

    public float fireRate;

    private int maxHullHealth = 100;

    private void Awake()
    {
        fireRate = 1f;

        hullHealth = 10;
        armourHealth = 0;
        shieldHealth = 0;
        hasShield = false;
    }

    public void Update()
    {
        if(hasShield)
        {
            //if player has a shield and has taken no damage in 5 seconds then start to recharge sheild;
        }
    }
    public int DisplayHull()
    {
        return hullHealth;
    }
    public int DisplayArmour()
    {
        return armourHealth;
    }
    public int DisplayShield()
    {
        return shieldHealth;
    }
    public void RepairHull()
    {
        hullHealth = maxHullHealth;
        Debug.Log("Ships Hull 100%");
    }

    public void AddArmour()
    {
        armourHealth += 100;
        Debug.Log("Add Armour " + 100);
    }

    public void ApplyDamage(int damage)
    {
        if (shieldHealth > 0)
        {
            shieldHealth -= damage;
            Debug.Log("Damaged the shields");
            if (shieldHealth < 0)
            {
                shieldHealth = 0;
            }
        }
        else if (armourHealth > 0)
        {
            armourHealth -= damage;
            Debug.Log("Damaged the armour");
            if (armourHealth < 0)
            {
                armourHealth = 0;
            }
        }
        else if (hullHealth > 0) {
            hullHealth -= damage;
            Debug.Log("Damaged the hull");
            if (hullHealth < 0)
            {
                Die();
            }
        }
    }

    public void Die()
    {
        Debug.Log("Game Over: Please try again!");
    }

}
