using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int health = 100;
    [SerializeField] private GameObject deathVFX = default;


    public int GetHealth()
    {
        return health;
    }

    public void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    public void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        else
        {
            GameObject deathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
            Destroy(deathVFXObject, 1f);
        }
    }

}
