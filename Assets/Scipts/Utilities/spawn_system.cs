using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_system : MonoBehaviour
{

    [SerializeField] GameObject Position,Player;
    new spawn collider;
    //要获得spawn文件里的component，类型得和文件名一样



    void colision_detection()
    {
        GameObject[] Dfield = GameObject.FindGameObjectsWithTag("Death_trap");

        foreach (GameObject i in Dfield)
        {
            collider = i.GetComponent<spawn>();//getcomponent<要用的代码文件名>获得含有该代码的component
            if (collider.collider_interact == true)
            {
                Player.transform.position = Position.transform.position;
            }
        }

    }




    void Update()
    {
        colision_detection();
    }
}







//Im taking a Break... i go eat and i continue code the jumping problem.....