using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowFishGenerator : MonoBehaviour
{
    public GameObject blowUpFishPrefab; //노란복어를 넣는 변수를 선언

    float span = 6.0f; //생성 시간 간격
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate메서드 => 생성(매개변수로 프리팹 전달, 반환으로 프리팹 인스턴스)
            GameObject go = Instantiate(blowUpFishPrefab) as GameObject; //Object형을 받지 않고 형 변환을 해서 GameObject로 받음
            int py = Random.Range(-2, 4); //복어의 y좌표(-2~3사이에서 불규칙하게 위치)
            go.transform.position = new Vector3(44, py, 0);
        }
    }
}
