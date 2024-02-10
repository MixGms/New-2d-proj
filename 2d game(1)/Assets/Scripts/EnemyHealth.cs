using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    HealthController healthController = new HealthController();
    float hp;

    private void Awake()
    {
        healthController.SetHealth(10);
        hp = healthController.health;
    }

    public void TakeDamage(float dmg)
    {
        healthController.TakeDamage(dmg);
        hp = healthController.health;
        if (hp <= 0) Destroy(gameObject);
        Debug.Log("Hit");
    }

    private void Update()
    {
        Debug.Log("Enemy health is " + hp.ToString());
    }

}
