using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    // 미사일 프리팹
    public GameObject bullet_impacts_0;

    // 미사일이 발사되는 순간의 속도
    public float launchSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // 플레이어가 Fire1 버튼을 눌렀는지를 체크

            // 프리팹으로부터 새로운 미사일 게임 오브젝트 생성
            GameObject missile = Instantiate(bullet_impacts_0, transform.position, transform.rotation);

            // 미사일로부터 리지드바디 2D 컴포넌트 가져옴
            Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();

            // 미사일을 전방으로 발사
            rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);

    }
}