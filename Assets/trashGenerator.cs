using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashGenerator : MonoBehaviour
{
    public GameObject trashPrefab; //바다 쓰레기 설계도를 넣는 변수를 선언
    float span = 3.0f; //생성 시간 간격
    float delta = 0;

    void Update()
    {
        //쓰레기를 2초마다 한 개씩 생성하는 코드
        this.delta += Time.deltaTime; //앞 프레임과 현재 프레임 사이의 시간 차이
        if(this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate메서드 => 생성(매개변수로 프리팹 전달, 반환으로 프리팹 인스턴스)
            GameObject go = Instantiate(trashPrefab) as GameObject; //Object형을 받지 않고 형 변환을 해서 GameObject로 받음
            int px = Random.Range(-7, 20); //쓰레기의 X좌표(-7~19사이에서 불규칙하게 위치)
            go.transform.position = new Vector3(px, 4, 0);
        }
    }
}
