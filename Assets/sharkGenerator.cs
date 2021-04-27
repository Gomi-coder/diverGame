using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkGenerator : MonoBehaviour
{
    float rightMax = 33.0f;
    float leftMax = 20.0f;
    float direction = 3.0f; //이동속도+방향
    float currentPosition;
    int key = 1;

    void Start()
    {
        currentPosition = transform.position.x;
    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;

        //현재 위치(x)가 우로 이동가능한 (x)최대값보다 크거나 같다면
        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 우로 이동가능한 (x)최대값으로 설정
        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
            this.key = 1;
        }

        //현재 위치(x)가 좌로 이동가능한 (x)최대값보다 크거나 같다면
        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 좌로 이동가능한 (x)최대값으로 설정
        else if (currentPosition <= leftMax)
        {
            direction *= -1;
            currentPosition = leftMax;
            this.key = -1;
        }

        transform.localScale = new Vector3(key*3, 3, 1);
        transform.position = new Vector3(currentPosition, -1, 0);
    }
}
