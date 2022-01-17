using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpInfo : MonoBehaviour
{
    Transform Player;

    bool CanPickUp;

    public GameObject PickUp;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;

        PickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.position, transform.position) < 4)
        {
            CanPickUp = true;
        }
        else
        {
            CanPickUp = false;
        }
    }

    void OnMouseEnter()
    {
        if (CanPickUp == true)
        {
            PickUp.SetActive(true);
        }
        else
        {
            PickUp.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        PickUp.SetActive(false);
    }

}

    
