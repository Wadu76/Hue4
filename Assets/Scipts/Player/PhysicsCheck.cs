using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCheck : MonoBehaviour
{
    [Header("״̬")]
    
    [Header("������")]
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
    {   //�����µ���û���ŵ�
        Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, checkSize);

        //�����ǰ���޵� ��������������һ�ἴ�� ������
        Gizmos.DrawWireSphere((Vector2)transform.position + frontoffset, checkSize);
    }
}
