using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollision : MonoBehaviour
{
    public event Action OnHit = delegate { };
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectable collectable = collision.GetComponent<ICollectable>();
        if (collectable != null)
        {
            collectable.Collect(GetComponent<Ship>());
            Destroy(collision.gameObject);
        }

        IInteractable interactable = collision.GetComponent<IInteractable>();
        if(interactable != null)
        {
            interactable.Interact(GetComponent<Ship>());
        }

        IDamageable damageable = collision.GetComponent<IDamageable>();
        if(damageable != null)
        {
            damageable.Damage();
            OnHit();
        }
    }
}
