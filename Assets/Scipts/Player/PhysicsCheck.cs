using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCheck : MonoBehaviour
{
    [Header("状态")]
    
    [Header("检测参数")]
    public float checkSize;
    public Vector2 bottomOffset, frontoffset;
    public LayerMask groundlayer;
    private void Update()
    {
        Check();
    }
    public void Check()
    {
        
        
    }

    private void OnDrawGizmosSelected()
    {   //检测脚下的有没有着地
        Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, checkSize);

        //检测面前有无地 把坐标往右上提一提即可 后续改
        Gizmos.DrawWireSphere((Vector2)transform.position + frontoffset, checkSize);
    }
}
