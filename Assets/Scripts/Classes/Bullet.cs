using System;
using System.Collections;
using UnityEngine;
public class Bullet : Weapon
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float bulletForce;
    [SerializeField]
    private float selfDestructTimer;

    private void Awake()
    {
        selfDestructTimer = 5f;
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(SelfDestructTimer());
    }
    public void Launch(Weapon weapon)
    {
        rb.AddRelativeForce(Vector2.up * bulletForce);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damagable = collision.GetComponent<IDamageable>();
        if(damagable != null)
        {
            damagable.Damage();
            Destroy(this.gameObject);
        }
    }

    private IEnumerator SelfDestructTimer()
    {
        yield return new WaitForSeconds(selfDestructTimer);
        Destroy(this.gameObject);
    }
}
