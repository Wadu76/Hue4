using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrans : MonoBehaviour
{
    public GameObject Player;
    public Transform purplet;
    [SerializeField] spawn colission_detection;
    //private Transform nPlayer, purplet;
    public bool Titd;
    RealDoor purple1, purple2;

    private void Awake()
    {
        //purplet = purple2.GetComponent<Transform>();

    }

    private void indoor()
    {
        Titd = colission_detection.collider_interact;
    }

    private void Update()
    {

        indoor();

        //if (Input.GetKey(KeyCode.W) &&  Titd == true)
        if (Titd == true && Input.GetKey(KeyCode.W))
        {
            Player.transform.position = purplet.transform.position;
        }
    }
}
