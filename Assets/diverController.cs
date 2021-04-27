using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diverController : MonoBehaviour
{
    //ĳ����(diver)�̵��� ���� ���� ����
    float moveX, moveY;
    int key = -1;
    //Private������ �ν�����â�� �����ϱ� ���� SerializeField���    
    //�̷��� �ϸ� ������ ������ �̵��ӵ����� �������� �ν�����â�� ���!
    [Header("�̵��ӵ� ����")]
    [SerializeField] [Range(1f, 10f)] float moveSpeed = 5f; //�⺻ �̵� �ӵ� => 5

    
    void Start()
    {
        transform.localScale = new Vector3(key, 1, 1);
    }

    void Update()
    {
        //���� �̵��� ���� �ڵ�(position)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if(moveX > 0) { 
            this.key = -1; 
        }
        else if(moveX <0){
            this.key = 1;
        }
        //��-�� �����̴� ���⿡ ���� �̹��� ������Ű��
        transform.localScale = new Vector3(key, 1, 1);
        //���� �̵��� ���� �ڵ�
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //���� ���⿡ ���� �����Ŵ�
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            if (GameObject.Find("flag").GetComponent<flagController>().isRot == true)
            {
                Debug.Log("��������!");
                SceneManager.LoadScene("ClearScene");
            }
        
    }

    /*{
        if (GameObject.Find("flag").GetComponent<flagController>().isRot == false)
        {
            transform.Rotate(0, 0, 90);
            GameObject.Find("flag").GetComponent<flagController>().isRot = true;
        }
    }*/
}
