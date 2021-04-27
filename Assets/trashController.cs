using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("diver");
    }

    void Update()
    {
        //등속 낙하
        transform.Translate(0, -0.05f, 0);

        //화면 밖으로 나오면 오브젝트 삭제
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //화살의 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어의 중심 좌표(diver)
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f; //플레이어(diver)의 반경

        if(d<r1 + r2) //충돌
        {
            Destroy(gameObject); //쓰레기를 지운다
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
        }
    }
}
