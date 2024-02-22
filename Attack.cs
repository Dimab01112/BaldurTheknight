using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Collider2D attackCollider;
    public int attackDamage = 1;
  private void Awake()
    {
        attackCollider = GetComponent<Collider2D>();
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damageable = collision.GetComponent<Damageable>();
        if (damageable != null)
        {
            Debug.Log(collision.name);
            damageable.Hit(attackDamage);
        }
    }
}

