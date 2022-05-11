using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int health;

    [SerializeField] private Transform playerTarget;

    public float rotateSpeed = 5f;
    private void Awake()
    {
        
        health = 10;
    }

    private void Update()
    {
        if(health<=0)
        {
            Die();
        }

        //Debug.Log(Vector2.Distance(playerTarget.position, transform.position));
        if (Vector2.Distance(playerTarget.position, transform.position) <= 4f)
        {
            transform.up = playerTarget.position - transform.position;
            //move towards player
        }
    }
    public void Damage()
    {
        health -= 2;
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
