using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkGenerator : MonoBehaviour
{
    float rightMax = 33.0f;
    float leftMax = 20.0f;
    float direction = 3.0f; //�̵��ӵ�+����
    float currentPosition;
    int key = 1;

    void Start()
    {
        currentPosition = transform.position.x;
    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;

        //���� ��ġ(x)�� ��� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
        //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� ��� �̵������� (x)�ִ밪���� ����
        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
            this.key = 1;
        }

        //���� ��ġ(x)�� �·� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
        //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� �·� �̵������� (x)�ִ밪���� ����
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
