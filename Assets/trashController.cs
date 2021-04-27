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
        //��� ����
        transform.Translate(0, -0.05f, 0);

        //ȭ�� ������ ������ ������Ʈ ����
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾��� �߽� ��ǥ(diver)
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f; //�÷��̾�(diver)�� �ݰ�

        if(d<r1 + r2) //�浹
        {
            Destroy(gameObject); //�����⸦ �����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
        }
    }
}
