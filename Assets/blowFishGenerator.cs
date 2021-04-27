using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowFishGenerator : MonoBehaviour
{
    public GameObject blowUpFishPrefab; //������ �ִ� ������ ����

    float span = 6.0f; //���� �ð� ����
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            //Instantiate�޼��� => ����(�Ű������� ������ ����, ��ȯ���� ������ �ν��Ͻ�)
            GameObject go = Instantiate(blowUpFishPrefab) as GameObject; //Object���� ���� �ʰ� �� ��ȯ�� �ؼ� GameObject�� ����
            int py = Random.Range(-2, 4); //������ y��ǥ(-2~3���̿��� �ұ�Ģ�ϰ� ��ġ)
            go.transform.position = new Vector3(44, py, 0);
        }
    }
}
