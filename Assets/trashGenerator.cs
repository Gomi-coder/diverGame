using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashGenerator : MonoBehaviour
{
    public GameObject trashPrefab; //�ٴ� ������ ���赵�� �ִ� ������ ����
    float span = 3.0f; //���� �ð� ����
    float delta = 0;

    void Update()
    {
        //�����⸦ 2�ʸ��� �� ���� �����ϴ� �ڵ�
        this.delta += Time.deltaTime; //�� �����Ӱ� ���� ������ ������ �ð� ����
        if(this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate�޼��� => ����(�Ű������� ������ ����, ��ȯ���� ������ �ν��Ͻ�)
            GameObject go = Instantiate(trashPrefab) as GameObject; //Object���� ���� �ʰ� �� ��ȯ�� �ؼ� GameObject�� ����
            int px = Random.Range(-7, 20); //�������� X��ǥ(-7~19���̿��� �ұ�Ģ�ϰ� ��ġ)
            go.transform.position = new Vector3(px, 4, 0);
        }
    }
}
