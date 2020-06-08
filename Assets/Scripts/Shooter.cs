using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile = default;
    [SerializeField] private GameObject gun = default;


    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

}
