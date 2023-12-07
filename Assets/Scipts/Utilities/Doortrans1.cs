using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Doortrans1 : MonoBehaviour
{   
    public GameObject Player;
    public Transform purplet;
    //private Transform nPlayer, purplet;
    public bool Titd;
    RealDoor purple1, purple2;

    private void Awake()
    {
        gameObject.GetComponent<Doortrans>().enabled = true;
        purplet = purple2.GetComponent<Transform>();
    }

    private void indoor()
    {
        //nPlayer = Player.GetComponent<Transform>();
        if (Player.transform.position.x >= 52 && Player.transform.position.x <=57)
        {
            Titd = true;
        }
        else
        {
            Titd = false;
        }
    }

    private void Update()
    {
        
        indoor();

        //if (Input.GetKey(KeyCode.W) &&  Titd == true)
        if(Titd == true && Input.GetKey(KeyCode.W))
        {
            Player.transform.position = purplet.transform.position;
        }
    }
}
