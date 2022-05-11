using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInteract : MonoBehaviour, IInteractable
{
    [SerializeField]
    private IInteractable interactable;
    private void Awake()
    {
        interactable = GetComponent<IInteractable>();
    }
    public void Interact(Ship ship)
    {
        interactable.Interact(ship);
    }

}
