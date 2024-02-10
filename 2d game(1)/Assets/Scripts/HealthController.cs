using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float health;

    public float SetHealth(float hp)
    {
        return health = hp;
    }

    public float TakeDamage(float dmg)
    {
        return health -= dmg;
    }
}
