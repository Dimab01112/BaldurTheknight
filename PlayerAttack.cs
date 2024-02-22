using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public bool isHammer;
    private void Update()
    {
        if(isHammer && Input.GetKeyDown(KeyCode.Mouse1))
        {
            GetComponentInParent<Animator>().Play("player_attack 2");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy" && !isHammer)
        {
            collision.gameObject.GetComponentInParent<Damageable>()._health -= 1;
        }
        Debug.Log(collision.name);
        if (collision.gameObject.tag == "Enemy" && isHammer)
        {
            collision.gameObject.GetComponentInParent<Damageable>()._health -= 2;
            collision.gameObject.GetComponentInParent<Skeleton>().walkSpeed = 0f;
            StartCoroutine(stun(collision.GetComponentInParent<Skeleton>()));
        }
        Debug.Log(collision.name);
    }
    IEnumerator stun(Skeleton skeleton)
    {
        yield return new WaitForSeconds(3f);
        skeleton.walkSpeed = 3f;
    }
}
