using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_system : MonoBehaviour
{

    [SerializeField] GameObject Position,Player;
    new spawn collider;
    //Ҫ���spawn�ļ����component�����͵ú��ļ���һ��



    void colision_detection()
    {
        GameObject[] Dfield = GameObject.FindGameObjectsWithTag("Death_trap");

        foreach (GameObject i in Dfield)
        {
            collider = i.GetComponent<spawn>();//getcomponent<Ҫ�õĴ����ļ���>��ú��иô����component
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