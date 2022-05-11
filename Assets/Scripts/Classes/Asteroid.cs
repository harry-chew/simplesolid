using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Asteroid : MonoBehaviour, IDamageable
{
    [SerializeField] private Vector2 randomMoveVector;
    [SerializeField] private float initialForce;

    private Rigidbody2D rb;


    private void Awake()
    {
        SetVars();

        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(randomMoveVector * initialForce);
    }

    public void Damage()
    {
        Destroy(this.gameObject);
    }

    void SetVars() {
        randomMoveVector.x = UnityEngine.Random.Range(-1f, 1f);
        randomMoveVector.y = UnityEngine.Random.Range(-1f, 1f);
        initialForce = UnityEngine.Random.Range(15f, 30f);
    }
}
