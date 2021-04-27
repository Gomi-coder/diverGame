using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    GameObject player; //카메라의 타겟을 player로 하자!

    void Start()
    {
        this.player = GameObject.Find("diver");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;

        if (this.player.transform.position.x > -0.99 && this.player.transform.position.x < 34.0)
        {
            transform.position = new Vector3(2 + playerPos.x, transform.position.y, transform.position.z);
        }
    }
}
