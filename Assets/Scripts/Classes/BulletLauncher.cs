using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour, ILauncher
{
    [SerializeField]
    private Bullet bulletPrefab;
    [SerializeField]
    private Transform weaponMountPoint;


    public void Launch(Weapon weapon)
    {
        var bullet = Instantiate(bulletPrefab, weaponMountPoint.position, weaponMountPoint.rotation);
        bullet.Launch(weapon);
    }

}
