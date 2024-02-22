using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthBar : MonoBehaviour
{



    public GameObject[] healthObject;
    public Damageable playerDamageableScriptRelatable;

    private void Start()
    {

        playerDamageableScriptRelatable = GameObject.FindGameObjectWithTag("Player").GetComponent<Damageable>();
    }
    private void Update()
    {
        switch(playerDamageableScriptRelatable._health)
        {
            case 0:
                healthObject[0].SetActive(false); 
                healthObject[1].SetActive(false);
                healthObject[2].SetActive(false);
                healthObject[3].SetActive(false);
                break;
            case 1:
                healthObject[0].SetActive(true);
                healthObject[1].SetActive(false);
                healthObject[2].SetActive(false);
                healthObject[3].SetActive(false);
                break;
            case 2:
                healthObject[0].SetActive(true);
                healthObject[1].SetActive(true);
                healthObject[2].SetActive(false);
                healthObject[3].SetActive(false);
                break;
            case 3:
                healthObject[0].SetActive(true);
                healthObject[1].SetActive(true);
                healthObject[2].SetActive(true);
                healthObject[3].SetActive(false);
                break;
            case 4:
                healthObject[0].SetActive(true);
                healthObject[1].SetActive(true);
                healthObject[2].SetActive(true);
                healthObject[3].SetActive(true);
                break;

        }

    }
}
