using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoard : MonoBehaviour
{
    [SerializeField] private List<CircuitElement> Elements;
    [SerializeField] private float MaxHealth = 100;

    private float health;

    public float Health
    {
        get { return health; }
        set {
            health = value;
            if(health <= 0)
            {
                DestroyObject();
            }
        }
    }


    public void Damage(int damage)
    {
        Health -= damage;
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
