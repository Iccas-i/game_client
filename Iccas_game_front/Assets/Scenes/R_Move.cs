using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Move : MonoBehaviour
{
    Vector3 pos;             //������ġ
    float delta = 0.05f;     // ��(��)�� �̵������� (x)�ִ밪
    float speed = 5.0f;   // �̵��ӵ�

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.x -= delta * Mathf.Sin(Time.time * speed);
        // �¿� �̵��� �ִ�ġ ��  ���� ó���� �̷��� ���ٿ� ���ְ� �ϳ׿�.
        transform.position = v;
    }
}