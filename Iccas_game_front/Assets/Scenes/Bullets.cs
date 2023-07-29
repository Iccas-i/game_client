using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    // �̻��� ������
    public GameObject bullet_impacts_0;

    // �̻����� �߻�Ǵ� ������ �ӵ�
    public float launchSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // �÷��̾ Fire1 ��ư�� ���������� üũ

            // ���������κ��� ���ο� �̻��� ���� ������Ʈ ����
            GameObject missile = Instantiate(bullet_impacts_0, transform.position, transform.rotation);

            // �̻��Ϸκ��� ������ٵ� 2D ������Ʈ ������
            Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();

            // �̻����� �������� �߻�
            rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);

    }
}