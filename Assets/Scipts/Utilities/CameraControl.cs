using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraControl : MonoBehaviour
{
    private CinemachineConfiner2D confiner2D;
    private Collider2D ra;
    private Collider2D rc;
    private void Awake()
    {
        confiner2D = GetComponent<CinemachineConfiner2D>();
    }

    //场景切换后更改
    private void Start()
    {
        //GetNewCameraBounds();
    }
   /* private void GetNewCameraBounds()
    {
        var obj = GameObject.FindGameObjectsWithTag("Bounds");
        if (obj == null)
            return;

        confiner2D.m_BoundingShape2D = obj.GetC;

        confiner2D.InvalidateCache();
    }*/
}
