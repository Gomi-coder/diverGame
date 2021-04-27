using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diverController : MonoBehaviour
{
    //캐릭터(diver)이동을 위한 변수 선언
    float moveX, moveY;
    int key = -1;
    //Private변수를 인스펙터창에 노출하기 위해 SerializeField사용    
    //이렇게 하면 변수로 선언한 이동속도조절 게이지가 인스펙터창에 뜬다!
    [Header("이동속도 조절")]
    [SerializeField] [Range(1f, 10f)] float moveSpeed = 5f; //기본 이동 속도 => 5

    
    void Start()
    {
        transform.localScale = new Vector3(key, 1, 1);
    }

    void Update()
    {
        //수직 이동을 위한 코딩(position)
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if(moveX > 0) { 
            this.key = -1; 
        }
        else if(moveX <0){
            this.key = 1;
        }
        //좌-우 움직이는 방향에 따라 이미지 반전시키기
        transform.localScale = new Vector3(key, 1, 1);
        //수평 이동을 위한 코딩
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //받은 방향에 따른 포지셔닝
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            if (GameObject.Find("flag").GetComponent<flagController>().isRot == true)
            {
                Debug.Log("지상으로!");
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
