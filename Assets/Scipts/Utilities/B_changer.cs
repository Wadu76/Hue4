using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class B_changer : MonoBehaviour
{
    public bool Red,Green,Blue,Default;
    private SpriteRenderer background;
 

    


    void Awake()
    {
        background = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            background.color = Color.red;
            Red = true;
            Green = false;
            Blue = false;
            Default = false;
        }
        if (Input.GetKey(KeyCode.V))
        {
            background.color = Color.green;
            Red = false;
            Green = true;
            Blue = false;
            Default = false;
        }
        if (Input.GetKey(KeyCode.B))
        {
            background.color = Color.blue;
            Red = false;
            Green = false;
            Blue = true;
            Default = false;
        }
    }
}
