using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlySpaceStation : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    public void Interact(Ship ship)
    {
        Debug.Log("Space Station hit: " + ship.name);
    }
}
