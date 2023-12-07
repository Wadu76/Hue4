using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class system : MonoBehaviour
{
    [SerializeField] GameObject background,box_r,box_g,box_b;
    B_changer colour_code;

    // Start is called before the first frame update
    void Awake()
    {
        colour_code = background.GetComponent<B_changer>();
    }


    void Update()
    {
        if (colour_code.Red == true && colour_code.Default == false)
        {
            box_r.SetActive(false);
        }
        else if (colour_code.Red != true && colour_code.Default == false)
        {
            box_r.SetActive(true);
        }

        if (colour_code.Green == true && colour_code.Default == false)
        {
            box_g.SetActive(false);
        }

        else if (colour_code.Green != true && colour_code.Default == false)
        {
            box_g.SetActive(true);
        }

        if (colour_code.Blue == true && colour_code.Default == false)
        {
            box_b.SetActive(false);
        }

        else if (colour_code.Blue != true && colour_code.Default == false)
        {
            box_b.SetActive(true);
        }
    }
}
