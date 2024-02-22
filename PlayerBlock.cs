using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlock : MonoBehaviour
{
    public bool isBlocking;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            GetComponentInParent<Animator>().Play("player_block");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && collision.gameObject.GetComponentInParent<Skeleton>().HasTarget && collision.gameObject.GetComponentInParent<Skeleton>() != null)
        {
            collision.gameObject.GetComponentInParent<Skeleton>().enabled = false;
            GetComponentInParent<Animator>().Play("player_idle");
            collision.gameObject.GetComponentInParent<Animator>().Play("Enemy_idle");
            StartCoroutine(stun(collision.GetComponentInParent<Skeleton>()));
        }
        Debug.Log(collision.name);
       
    }
    IEnumerator stun(Skeleton skeleton)
    {
        yield return new WaitForSeconds(3f);
        if(skeleton != null)
        {
            skeleton.enabled = true;
        }  
    }
}
