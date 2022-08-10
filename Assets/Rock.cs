using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rock : MonoBehaviour
{
    private Rigidbody rigid;

    private void Awake()
    {
        // ������Ʈ Ǯ��(pooling)�� ����� ���̹Ƿ� ���� �� ��Ȱ��ȭ.
        if (!rigid) rigid = GetComponent<Rigidbody>();
        gameObject.SetActive(false);

    }

    //public event Action EventHadleOnCollisionPlayer;

    public void SetPosition(Vector3 pos)
    {
        transform.position = pos;
    }
    public void OnFire(Vector3 dir, float force)
    {
        gameObject.SetActive(true);
        rigid.velocity = Vector3.zero;
        rigid.AddForce(dir.normalized * force);
    }
}
