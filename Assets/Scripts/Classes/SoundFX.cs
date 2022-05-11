using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    [SerializeField] private AudioSource shootAudio;
    [SerializeField] private AudioSource hitAudio;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<ShipInput>().OnFire += Shoot;
        GetComponent<ShipCollision>().OnHit += Hit;
    }

    void Shoot()
    {
        shootAudio.Play();  
    }


    void Hit()
    {
        hitAudio.Play();
    }
}
